using System;
using System.Windows.Forms;

namespace ThesisDemo
{
    public static class Program
    {
        internal static WinFormsServer MainForm { get; set; }
        // The main entry point for the application.
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new WinFormsServer();
            Application.Run(MainForm);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
