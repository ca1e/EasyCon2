using System.Numerics;
using VideoCaptureCore;

namespace EasyCon2.Test.Composition
{
    class CompositionHostControl : CompositionHost
    {
        public CompositionHostControl() : base()
        {

        }

        public BasicSampleApplication GenApp()
        {
            BasicSampleApplication sample = new BasicSampleApplication(compositor);
            containerVisual.RelativeSizeAdjustment = Vector2.One;
            containerVisual.Children.InsertAtTop(sample.Visual);
            return sample;
        }
    }
}
