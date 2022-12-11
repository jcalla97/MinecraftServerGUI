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
            //Initialize tab
            InitializeComponent();
            tab = serverTab;

            // Setup Dictionaries
            textBoxConfigItems = new Dictionary<string, TextBox>() {
                { "server-ip", serverIpTextbox},
                { "server-port", serverPortTextBox},
                { "max-players", maxPlayersTextBox},
                { "player-idle-timeout", playerIdleTextBox},
                {"spawn-protection", null},
            };
            checkboxConfigsItems = new Dictionary<string, CheckBox>()
            {
                {"require-resource-pack", null},
                {"pvp", null},
                {"online-mode", null},
                {"enfore-whitelist", null},
            };

            // Setup buttons
            restartButton.Enabled = false;
            InitWorldCombobox();
            InitWorldInfo();
            motdTextBox.Text = serverProperties["motd"].Item1;
        }
        /// <summary>
        /// Server Initialization Functions
        /// </summary>
        private void writeConfig(string world)
        {
            foreach (KeyValuePair<string, (string, int)> conf in serverProperties){
                cfg[conf.Value.Item2] = conf.Key + "=" + conf.Value.Item1;
            }
            File.WriteAllLines(cfgPath, cfg);
            File.Copy(worldsDir + world + "\\server.properties", cfgPath, true);
        }
        private void InitWorldInfo()
        {
            cfg = File.ReadAllLines(cfgPath);
            int index = 0;
            difficultyComboBox.SelectedIndex = 0;
            foreach (string line in cfg)
            {
                string[] split = line.Split('=');
                if (serverProperties.ContainsKey(split[0]))
                {
                    serverProperties[split[0]] = (split[1], index);
                    if (textBoxConfigItems.ContainsKey(split[0]))
                    {
                        if (textBoxConfigItems[split[0]] != null)
                        {
                            var textbox = textBoxConfigItems[split[0]];
                            textbox.Text = split[1];
                        }
                    }
                    if (checkboxConfigsItems.ContainsKey(split[0]))
                    {
                        if (checkboxConfigsItems[split[0]] != null)
                        {
                            var checkBox = checkboxConfigsItems[split[0]];
                            checkBox.Checked = bool.Parse(split[1]);
                        }
                    }
                    if (split[0] == "difficulty")
                    {
                        if (split[1] == "peaceful")
                        {
                            difficultyComboBox.SelectedIndex=0;
                        }
                        else if (split[1] == "easy")
                        {
                            difficultyComboBox.SelectedIndex = 1;
                        }
                        else if (split[1] == "normal")
                        {
                            difficultyComboBox.SelectedIndex = 2;
                        }
                        else if (split[1] == "hard")
                        {
                            difficultyComboBox.SelectedIndex = 3;
                        }
                    }
                }
                index++;
            }
            return;
        }

        private void wolrdInfoTextChange(object sender, EventArgs e)
        {
            return;
        }

        private void setServerControlsEnabled(bool val)
        {
            startButton.Enabled = val;
        }
        
        private void difficultyComboBoxChange(object sender, EventArgs args)
        {
            string difficulty = difficultyComboBox.Text;
            serverProperties["difficulty"] = (difficultyDict[difficulty], serverProperties["difficulty"].Item2);
            writeConfig(worldCombobox.Text);
            ConsoleWriter("Difficulty set to " + difficulty);
        }
        /// <summary>
        /// Server Start
        /// </summary>
        private void StartButton_Click(object sender, EventArgs args)
        // Event handler for when the Start/Stop button is pressed
        {
            if (worldCombobox.SelectedIndex == 0)
            {
                ConsoleWriter("Please select a world before starting the server!");
                return;
            }
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
                this.worldCombobox.Items.Clear();
                this.worldCombobox.Items.Add("<New>");
                this.worldCombobox.SelectedIndex = 0;
                string[] directories = Directory.GetDirectories(worldsDir);
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
            } catch (DirectoryNotFoundException e)
            {
                ConsoleWriter("Please create a world and run a server to initialize certain files.");
            } 
        }

       private void worldComboBoxChange(object sender, EventArgs args)
       {
            string world = worldCombobox.SelectedItem.ToString();

            if (world == "<New>")
            {
                this.NewWorld();
                return;
            }
            // TODO:: Copy server.properties
            string oldWorld = serverProperties["level-name"].Item1.Split('/')[1];
            string owsp = worldsDir + oldWorld + "\\server.properties";
            string wsp = worldsDir + world + "\\server.properties";
            string sp = projectDirectory + "\\Server\\server.properties";
            try {
                if (File.Exists(owsp))
                {
                    writeConfig(oldWorld);
                }
                backupServer();
                File.Copy(wsp, sp, true);
                InitWorldInfo();
            }
            catch { 
                ConsoleWriter("Failed to copy server.properties");
                setServerControlsEnabled(false);
                worldCombobox.SelectedIndex = 0;
            }
        }
        private void DeleteWorldClick(object sender, EventArgs args)
        {
            /// Deletes the world selected by the Wolr
            int currentIndex = worldCombobox.SelectedIndex;
            if (currentIndex == 0)
            {
                ConsoleWriter("Select a world to delete first!");
                return;
            }
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
                    writeConfig(worldCombobox.Text);
                }
                catch (Exception e)
                {
                    var ex = e.Data;
                }
            }
        }
        private void backupServer()
        {
            //TODO
            return;
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
            InitWorldInfo();
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

        private void serverIpTextChanged(object sender, EventArgs e)
        {
            serverProperties["server-ip"] = (serverIpTextbox.Text, serverProperties["server-ip"].Item2);
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
