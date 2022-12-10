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
    public partial class ServerTabUI : Form
    {
        public ServerTabUI(string pd, Form parent)
        {
            // Setup variables
            running = false;
            projectDirectory = pd;
            worldsDir = projectDirectory + "\\Server\\worlds\\";
            cfgPath = projectDirectory + "\\Server\\server.properties";
            newWorldOpen = false;
            this.parent = parent;
            cfg = File.ReadAllLines(cfgPath);
            //Initialize tab
            InitializeComponent();
            tab = serverTab;
            // Setup buttons
            restartButton.Enabled = false;
            InitWorldCombobox();
            InitWorldInfoTable();
        }
        /// <summary>
        /// Server Initialization Functions
        /// </summary>
        private void writeConfig()
        {
            foreach (KeyValuePair<string, (string, int)> conf in serverProperties){
                cfg[conf.Value.Item2] = conf.Key + "=" + conf.Value.Item1;
            }
            File.WriteAllLines(cfgPath, cfg);
            File.Copy(cfgPath, worldsDir + worldCombobox.Text + "\\server.properties", true);
        }
        private void InitWorldInfoTable()
        {
            int index = 0;
            int row = 0;
            foreach (string line in cfg)
            {
                string[] split = line.Split('=');
                if (serverProperties.ContainsKey(split[0]))
                {
                    serverProperties[split[0]] = (split[1], index);
                    Label name = new Label();
                    name.Text = split[0];
                    Label value = new Label();
                    value.Text = split[1];
                    row++;
                }
                index++;
            }
            return;
        }
        private void setServerControlsEnabled(bool val)
        {
            startButton.Enabled = val;
        }
        /// <summary>
        /// Server Start
        /// </summary>
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
                ServerOutput(outLine.Data);
            }
        }
        private void ServerOutput(string s)
        {
            this.Invoke(new Action<string>(ConsoleWriter), new object[] { s });
        }
       //
       // Worlds  Combo Box
       //
        private void InitWorldCombobox()
        {
            try
            {
                string[] directories = Directory.GetDirectories(worldsDir);
                this.worldCombobox.Items.Clear();
                this.worldCombobox.Items.Add("<New>");
                init = true;
                for (int i = 0; i < directories.Length; i++)
                {
                    string[] dir_list = directories[i].Split("\\");
                    string dir = dir_list[dir_list.Length - 1];
                    if (dir == "worlds")
                    {
                        continue;
                    }
                    this.worldCombobox.Items.Add(dir);
                }
                this.worldCombobox.SelectedIndex = 0;
            } catch (DirectoryNotFoundException e)
            {
                ConsoleWriter("Please create a world and run a server to initialize certain files.");
            } 
        }

       private void ComboBoxChange(object sender, EventArgs args)
       {
            if (init)
            {
                init = false;
                return;
            }
            string world = worldCombobox.SelectedItem.ToString();
            if (world == "<New>")
            {
                this.NewWorld();
                return;
            }
            // TODO:: Copy server.properties
            string wsp = projectDirectory + "\\Server\\worlds\\";
            string sp = projectDirectory + "\\Server\\server.properties";
            try { File.Copy(wsp, sp); } 
            catch { 
                ConsoleWriter("Failed to copy server.properties");
                setServerControlsEnabled(false);
                worldCombobox.SelectedIndex = 0;
            }
        }
        private void DeleteWorldClick(object sender, EventArgs args)
        {
            int currentIndex = worldCombobox.SelectedIndex;
            string world = worldCombobox.Text;
            string worldPath = worldsDir + world;
            string msg = "Are you sure you want to delete the save data of " + world + 
                "? You will not be able recover the world!";
            string title = "Delete World?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show(msg, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Directory.Delete(worldPath, true);
                    worldCombobox.Items.Remove(worldCombobox.Items[currentIndex]);
                    worldCombobox.SelectedIndex = 0;
                    setServerControlsEnabled(false);
                    writeConfig();
                }
                catch (Exception e)
                {
                    var ex = e.Data;
                }
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
            ServerTabUI gui = new ServerTabUI(projectDirectory, parent);
            this.tab = gui.tab;
        }
    }
}
