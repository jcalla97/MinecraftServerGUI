using System;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;

namespace MinecraftServerCSharp
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            this.running = false;

            string workingDirectory = Environment.CurrentDirectory;
            this.projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            this.server = new();
            InitializeComponent();
            this.restartButton.Enabled = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (this.running) {
                this.startButton.Text = "Start";
                AppendTextBox("=====================================");
                AppendTextBox("============ Stoping the Server ============");
                AppendTextBox("=====================================");
                server.StandardInput.WriteLine("stop");
                server.Close();
                this.restartButton.Enabled = false;
                this.running = false;
            }
            else if (!this.running) {
                this.startButton.Text = "Stop";
                this.running = true;
                runServer();
                this.restartButton.Enabled = true;
            }
        }

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            this.consoleLog.AppendText(value + "\n");
        }

        private void runServer()
        {
            try
            {
                this.server.StartInfo.FileName = this.javaHome;
                this.server.StartInfo.RedirectStandardInput = true;
                this.server.StartInfo.RedirectStandardOutput = true;
                this.server.StartInfo.RedirectStandardError = true;
                this.server.StartInfo.CreateNoWindow = true;
                this.server.StartInfo.WorkingDirectory = this.projectDirectory + "\\Server";
                this.server.StartInfo.Arguments = "-Xmx3G -Xms1G -jar server.jar nogui";
                this.server.OutputDataReceived += consoleWriter;
                this.server.Exited += serverExit;
                AppendTextBox("=====================================");
                AppendTextBox("============ Starting the Server ============");
                AppendTextBox("=====================================");
                this.server.Start();
                this.server.BeginOutputReadLine();
                this.server.BeginErrorReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e);
            }
        }

        private void consoleWriter(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                AppendTextBox(outLine.Data);
            }
        }

        private void serverExit(object sendingProcess, EventArgs e)
        {
            AppendTextBox("Server has exited on its own!");
        }

        private bool running;
        private string projectDirectory;
        private string javaHome = "C:\\Program Files\\Java\\jdk-17.0.2\\bin\\java.exe";
        private Process server;

        private void restartButton_Click(object sender, EventArgs e)
        {
            AppendTextBox("=====================================");
            AppendTextBox("=========== Restarting the Server ===========");
            AppendTextBox("=====================================");
            this.server.StandardInput.WriteLine("stop");
            Thread.Sleep(10);
            this.server.Close();
            this.server = new Process();
            runServer();
        }
    }
}