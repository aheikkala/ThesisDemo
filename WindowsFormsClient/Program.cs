using System;
using System.Windows.Forms;

namespace ThesisDemo
{
    static class Program
    {

        // The main entry point for the application.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WinFormsClient());
        }
    }
}
