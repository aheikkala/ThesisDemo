using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThesisDemo
{
    // WinForms host for a SignalR server
    public partial class WinFormsServer : Form
    {
        private IDisposable SignalR { get; set; }
        const string ServerURI = "http://localhost:8080";

        internal WinFormsServer()
        {
            InitializeComponent();
        }


        // Calls the StartServer method with Task.Run to not block the UI thread. 
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            WriteToConsole("Starting server...");
            ButtonStart.Enabled = false;
            Task.Run(() => StartServer());
        }

        // Stops the server and closes the form.
        private void ButtonStop_Click(object sender, EventArgs e)
        {
            //SignalR will be disposed in the FormClosing event
            Close();
        }


        // Starts the server and checks for error thrown when another server is already running. This method is called asynchronously from Button_Start.
        private void StartServer()
        {
            try
            {
                SignalR = WebApp.Start<Startup>(ServerURI);
            }
            catch (TargetInvocationException)
            {
                WriteToConsole("Server failed to start. A server is already running on " + ServerURI);
                //Re-enable button to let user try to start server again
                this.Invoke((Action)(() => ButtonStart.Enabled = true));
                return;
            }
            this.Invoke((Action)(() => ButtonStop.Enabled = true));
            WriteToConsole("Server started at " + ServerURI);
        }

        // This method adds a line to the RichTextBoxConsole control, using Invoke if used from a SignalR hub thread rather than the UI thread.

        internal void WriteToConsole(String message)
        {
            if (RichTextBoxConsole.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                    WriteToConsole(message)
                ));
                return;
            }
            RichTextBoxConsole.AppendText(message + Environment.NewLine);
        }

        private void WinFormsServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (SignalR != null)
            {
                SignalR.Dispose();
            }
        }
    }
    
}
