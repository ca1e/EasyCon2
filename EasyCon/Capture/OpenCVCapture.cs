using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using SharpDX.MediaFoundation;

namespace EasyCon.Capture
{
    public class OpenCVCapture
    {
        private readonly object _lock = new object();
        private int dev_index = 0;
        private int dev_type = 0;
        private OpenCvSharp.VideoCapture capture;

        private CancellationTokenSource source;
        private CancellationToken token;

        private Bitmap _image;
        
        private System.Drawing.Point _curResolution = new System.Drawing.Point(1920, 1080);

        public System.Drawing.Point CurResolution
        {
            get
            {
                return _curResolution;
            }
            set
            {
                if (_curResolution.X != value.X || _curResolution.Y != value.Y)
                {
                    lock (_lock)
                    {
                        _curResolution = value;
                        if (source != null)
                        {
                            source.Cancel();
                        }

                        capture?.Release();
                        capture?.Dispose();
                        // reopen it 
                        capture = new VideoCapture(dev_index, (VideoCaptureAPIs)dev_type);

                        capture.Set(VideoCaptureProperties.FrameWidth, _curResolution.X);
                        capture.Set(VideoCaptureProperties.FrameHeight, _curResolution.Y);
                        Thread.Sleep(300);

                        source = new CancellationTokenSource();
                        token = source.Token;
                        Task.Run(()=> {
                            Capture_Frame();
                        }, token);
                    }
                }
            }
        }

        private PictureBox displayUI;

        public void CaptureCamera(PictureBox pictureBox, int index = 0, int typeId = 0)
        {
            displayUI = pictureBox;
            dev_index = index;
            dev_type = typeId;

            try
            {
                capture = new VideoCapture(dev_index, (VideoCaptureAPIs)dev_type);
                if (!capture.IsOpened())
                {
                    MessageBox.Show("当前采集卡已经被其他程序打开，请先关闭后再尝试");
                    Close();
                }

                capture.Set(VideoCaptureProperties.FrameWidth, _curResolution.X);
                capture.Set(VideoCaptureProperties.FrameHeight, _curResolution.Y);
                capture.Set(VideoCaptureProperties.Fps, 60);

                Debug.WriteLine(capture.Get(VideoCaptureProperties.Mode));
                Debug.WriteLine(capture.Get(VideoCaptureProperties.FourCC));
                Debug.WriteLine(capture.Get(VideoCaptureProperties.Backend));
                Debug.WriteLine(capture.Get(VideoCaptureProperties.Fps));

                source = new CancellationTokenSource();
                token = source.Token;
                Task.Run(() => {
                    Capture_Frame();
                }, token);
            }
            catch(Exception ce)
            {
                MessageBox.Show("打开失败，出现错误:" + ce.Message);
                return;
            }
        }

        public void Close()
        {
            if (capture == null)
                return;
            lock (_lock)
            {
                if (source != null)
                {
                    source.Cancel();
                }
                if (!capture.IsDisposed)
                {
                    capture?.Release();
                    capture?.Dispose();
                }
            }
        }

        public static Dictionary<string, int> GetCaptureTypes()
        {
            var captureTypes = new Dictionary<string, int>();
            var values = Enum.GetValues(typeof(VideoCaptureAPIs));
            foreach (var value in values)
            {
                Debug.WriteLine(value + "--" + (int)value);//获取名称和值
                if (captureTypes.ContainsKey(value.ToString()))
                    continue;
                captureTypes.Add(value.ToString(), (int)value);
            }
            return captureTypes;
        }

        public static List<string> GetCaptureCamera()
        {
            var devs = new List<string>();

            var attributes = new MediaAttributes(1);
            attributes.Set(CaptureDeviceAttributeKeys.SourceType, CaptureDeviceAttributeKeys.SourceTypeVideoCapture.Guid);
            var devices = MediaFactory.EnumDeviceSources(attributes);
            foreach (var d in devices)
            {
                var friendlyName = d.Get(CaptureDeviceAttributeKeys.FriendlyName);
                devs.Add(friendlyName);
                Debug.WriteLine(friendlyName);
            }

            return devs;
        }

        //private static ulong frameCount = 0;
        private static Stopwatch runTime = new Stopwatch();
        private void Capture_Frame()
        {
            runTime.Start();
            while (true)
            {
                if (token.IsCancellationRequested) break;
                if (Monitor.TryEnter(_lock))
                {
                    try
                    {
                        var _fram = new Mat();
                        capture.Read(_fram);
                        using (var frameMat = capture.RetrieveMat())
                        {
                            if (!frameMat.Empty())
                            {
                                _image?.Dispose();
                                _image = BitmapConverter.ToBitmap(frameMat);
                                displayUI.Invalidate();
                            }
                        }
                    }
                    finally
                    {
                        Monitor.Exit(_lock);
                    }
                }
                Thread.Sleep(15); // 60 fps enough
            }
            runTime.Stop();
        }

        public Bitmap GetImage()
        {
            lock (_lock)
            {
                if (_image == null)
                    return null;

                var range = new Rectangle(0, 0, _image.Width, _image.Height);
                Bitmap img = _image.Clone(range, _image.PixelFormat);
                
                //Bitmap img = new Bitmap(_image.Width, _image.Height, PixelFormat.Format24bppRgb);
                //using (var g = Graphics.FromImage(img))
                //    g.DrawImage(_image, 0, 0, new Rectangle(0,0, _image.Width, _image.Height), GraphicsUnit.Pixel);
                
                return img;
            }
        }

    }
}
