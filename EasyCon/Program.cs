using EasyCon.UI;
using System;
using System.Text;
using System.Windows.Forms;

namespace EasyCon
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalExceptionLogger);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EasyConForm());
            //Application.Run(new CaptureFrm());

        }

        private static void GlobalExceptionLogger(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                var ex = e.ExceptionObject as Exception;
                if (ex == null)
                    return;
                StringBuilder builder = new StringBuilder();
                builder.AppendLine(DateTime.Now.ToString("[yyyy.M.d h:mm:ss.fff]"));
                builder.AppendLine(ex.ToString());
                builder.AppendLine();
                System.IO.File.AppendAllText("error.log", builder.ToString());
            }
            catch
            { }
        }
    }
}
