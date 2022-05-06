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
        private bool newWorldOpen;
        private bool init = false;
        private Form parent;
        private NewWorldForm newWorldForm;
        private string javaHome = "C:\\Program Files\\Java\\jdk-17.0.2\\bin\\java.exe";
        private Process server;
        private string projectDirectory = "";
        public TabPage tab;
        public gui_ui(string pd, Form parent)
        {
            // Setup variables
            this.running = false;
            this.projectDirectory = pd;
            this.newWorldOpen = false;
            this.parent = parent;
            
            //Initialize tab
            InitializeComponent();
            tab = this.serverTab;
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

        private void RunServer()
        // Actually runs the sever
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
                this.server.OutputDataReceived += outputDataReceived;
                this.server.Start();
                this.server.BeginOutputReadLine();
                this.server.BeginErrorReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e);
            }
        }

        private void RestartButtonClick(object sender, EventArgs e)
        // Restart the server
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
        //
        // Console Writers
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
        // Process OutputDataReceived ConsoleWriter;
        private void outputDataReceived(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                ConsoleWriter(outLine.Data);
            }
        }
       //
       // Worlds  Combo Box
       //
        private void InitWorldCombobox()
        {
            string[] directories = Directory.GetDirectories(projectDirectory + "\\Server\\worlds");
            this.worldCombobox.Items.Clear();
            this.worldCombobox.Items.Add("<New>");
            init = true;
            for (int i = 0; i < directories.Length; i++)
            {
                string[] dir_list = directories[i].Split("\\");
                string dir = dir_list[dir_list.Length - 1];
                this.worldCombobox.Items.Add(dir);
            }
            this.worldCombobox.SelectedIndex = 0;
        }

       private void ComboBoxChange(object sender, EventArgs args)
        {
            if (init)
            {
                init = false;
                return;
            }
            if (this.worldCombobox.SelectedItem.ToString() == "<New>")
            {
                this.NewWorld();
                return;
            }
        }
        //
        // New World Form Window
        //
        private void NewWorld()
        {
            this.newWorldOpen = true;
            string[] world_names = new string[this.worldCombobox.Items.Count];
            for (int i = 0; i < this.worldCombobox.Items.Count; i++)
            {
                string item = this.worldCombobox.GetItemText(worldCombobox.Items[i]);
                world_names[i] = item;
            }
            this.newWorldForm = new NewWorldForm(projectDirectory, world_names);
            this.newWorldForm.Show();
            this.newWorldForm.FormClosing += NewWorldFormClosing;
            this.parent.Enabled = false;
            this.serverTab.Enabled = false;
        }

        private void NewWorldFormClosing(object sender, EventArgs args)
        {
            this.parent.Enabled = true;
            this.serverTab.Enabled = true;
            this.newWorldOpen = false;
            this.InitWorldCombobox();
        }
        //
        // Server Commands
        //
        void backup(ElapsedEventHandler e)
        {
            return;
        }
        //
        // Server Close
        //
        private void ServerExit(object sendingProcess, EventArgs e)
        {
            ConsoleWriter("Server has exited on its own!");
            this.server.Kill();
            this.server = new Process();
            this.running = false;
            this.startButton.Text = "Start";
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
            if (this.newWorldOpen)
            {
                newWorldForm.Close();
            }
        }
    }


    internal class Gui : common.View
    {
        public Gui(string projectDirectory, Form parent)
        {
            this.projectDirectory = projectDirectory;
            gui_ui gui = new gui_ui(projectDirectory, parent);
            this.tab = gui.tab;
        }
    }
}
