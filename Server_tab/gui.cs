using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinecraftServerCSharp.common;
using System.Timers;
using System.Diagnostics;

namespace MinecraftServerCSharp.Server_tab
{
    public partial class gui_ui : Form
    {
        private bool running;
        private string javaHome = "C:\\Program Files\\Java\\jdk-17.0.2\\bin\\java.exe";
        private Process server;
        private string projectDirectory = "";
        public TabPage tab;
        public gui_ui(string pd)
        {
            // Setup variables
            this.running = false;
            this.projectDirectory = pd;
            
            //Initialize tab
            tab = InitializeComponent();

            // Setup buttons
            this.restartButton.Enabled = false;
            InitWorldCombobox();
        }
        //
        // Server Start
        //
        private void StartButton_Click(object sender, EventArgs e)
        // Event handler for when the Start/Stop button is pressed
        {
            if (this.running)
            {
                this.startButton.Text = "Start";
                ConsoleWriter("=====================================");
                ConsoleWriter("============ Stoping the Server ============");
                ConsoleWriter("=====================================");
                server.StandardInput.WriteLine("stop");
                Thread.Sleep(10);
                server.Close();
                this.restartButton.Enabled = false;
                this.running = false;
            }
            else if (!this.running)
            {
                this.startButton.Text = "Stop";
                this.running = true;
                this.consoleLog.Clear();
                ConsoleWriter("=====================================");
                ConsoleWriter("============ Starting the Server ============");
                ConsoleWriter("=====================================");
                this.server = new();
                RunServer();
                this.restartButton.Enabled = true;
            }
        }

        //
        //
        //
        public void ConsoleWriter(string value)
        // Adds text to consoleLog on Server tab
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(ConsoleWriter), new object[] { value });
                return;
            }
            this.consoleLog.AppendText(value + "\n");
        }

        private void RunServer()
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
                this.server.OutputDataReceived += ConsoleWriter;
                this.server.Start();
                this.server.BeginOutputReadLine();
                this.server.BeginErrorReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e);
            }
        }

        private void ConsoleWriter(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                ConsoleWriter(outLine.Data);
            }
        }

        private void ServerExit(object sendingProcess, EventArgs e)
        {
            ConsoleWriter("Server has exited on its own!");
            this.server.Kill();
            this.server = new Process();
            this.running = false;
            this.startButton.Text = "Start";
        }

        private void RestartButtonClick(object sender, EventArgs e)
        {
            ConsoleWriter("=====================================");
            ConsoleWriter("=========== Restarting the Server ===========");
            ConsoleWriter("=====================================");
            this.server.StandardInput.WriteLine("stop");
            Thread.Sleep(10);
            this.server.Close();
            this.server = new Process();
            RunServer();
        }

        private void InitWorldCombobox()
        {
            string[] directories = Directory.GetDirectories(projectDirectory + "\\Server\\worlds");
            for (int i = 0; i < directories.Length; i++)
            {
                string[] dir_list = directories[i].Split("\\");
                string dir = dir_list[dir_list.Length - 1];
                this.worldCombobox.Items.Add(dir);
            }
            this.worldCombobox.SelectedIndex = 0;
        }

        private void backup(ElapsedEventHandler e)
        {
            return;
        }

        public void Shutdown()
        {
            if (this.running)
            {
                this.server.CancelErrorRead();
                this.server.CancelOutputRead();
                Thread.Sleep(50);
                this.server.StandardInput.WriteLine("stop");
                Thread.Sleep(10);
                this.server.Close();
            }
        }
    }


    internal class Gui : common.View
    {
        public Gui(string projectDirectory)
        {
            this.projectDirectory = projectDirectory;
            gui_ui gui = new gui_ui(projectDirectory);
            this.tab = gui.tab;
        }
    }
}
