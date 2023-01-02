﻿using System.Net;

namespace MinecraftServerCSharp.Server_tab
{
    public partial class NewWorldForm : Form
    {
        public string[] cfg;
        private string sp_path;
        private string world_path;
        private string[] world_names;
        private int difficulty;
        private int seed;
        private int name;
        private int rp;
        private int rp_enable;
        private Dictionary<string, string> difficultyDict = new Dictionary<string, string>()
        {
            {"Peaceful", "peaceful" },
            {"Easy", "easy" },
            {"Normal", "normal" },
            {"Hard", "hard" },
        };
        public NewWorldForm(String pd, string[] worlds)
        {
            this.world_names = worlds;
            this.sp_path = pd + "\\Server\\server.properties";
            this.world_path = pd + "\\Server\\worlds";
            InitializeComponent();
            initDifficultyCombobox();
            cfg = readCFG(sp_path);
        }
        public void NewWorldForm_FormClosing(object sender, EventArgs args)
        {
            return;
        }
        //
        // textboxes
        //
        private void nameTextbox_TextChanged(object sender, EventArgs e)
        {
            cfg[name] = "level-name=worlds/" + nameTextbox.Text;
        }
        private void seedTextbox_TextChanged(object sender, EventArgs e)
        {
            cfg[seed] = "level-seed=" + seedTextbox.Text;
        }
        private void resourcepackTextbox_TextChanged(object sender, EventArgs e)
        {
            if (this.resourcepackTextbox.Text == "")
            {
                cfg[rp_enable] = "require-resource-pack=false";
            }
            else
            {
                if (verifyResourcepack(resourcepackTextbox.Text))
                {
                    cfg[rp_enable] = "require-resource-pack=true";
                    string resource_pack = "resource-pack=" + resourcepackTextbox.Text;
                    cfg[rp] = resource_pack;
                }
                else 
                {
                    cfg[rp_enable] = "require-resource-pack=false";
                    cfg[rp] = "resource-pack=";
                }

            }
        }
        //
        // Resource pack verify
        //
        private bool verifyResourcepack(string url)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.Method = "HEAD";
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                bool return_val = response.StatusCode == HttpStatusCode.OK;
                response.Close();
                return return_val;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void verifyButton_Click(object sender, EventArgs e)
        {
            if (verifyResourcepack(this.resourcepackTextbox.Text))
            {
                this.verifyLabel.Text = "URL is verified!";
            }
            else
                this.verifyLabel.Text = "This URL is invalid!";
        }
        //
        // Combobox
        //
        private void difficultyCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cfg[difficulty] = "difficulty=" + difficultyDict[difficultyCombobox.Text];
        }
        private void initDifficultyCombobox()
        {
            foreach (KeyValuePair<string, string> kvp in difficultyDict)
            {
                this.difficultyCombobox.Items.Add(kvp.Key);
            }
            difficultyCombobox.SelectedIndex = 3;
        }
        //
        // CFG methods
        //
        private string[] readCFG(string path)
        {
            string[] allLines = File.ReadAllLines(path);
            resetCFG(allLines);
            return allLines;
        }
        private void resetCFG(string[] cfg)
        {
            int i = 0;
            foreach (string line in cfg)
            {
                if (line.StartsWith("level-seed"))
                {
                    string[] l = line.Split('=');
                    cfg[i] = l[0] + "=";
                    seed = i;
                }
                else if (line.StartsWith("resource-pack="))
                {
                    string[] l = line.Split("=");
                    cfg[i] = l[0] + "=";
                    rp = i;
                }
                else if (line.StartsWith("level-name"))
                {
                    string[] l = line.Split('=');
                    cfg[i] = l[0] + "=worlds/";
                    name = i;
                }
                else if (line.StartsWith("require-resource-pack="))
                {
                    string[] l = line.Split('=');
                    cfg[i] = l[0] + "=false";
                    rp_enable = i;
                }
                else if (line.StartsWith("difficulty"))
                {

                    string[] l = line.Split('=');
                    cfg[i] = l[0] + "=hard";
                    difficulty = i;
                }
                i++;
            }
        }

        private void createWorldButton_Click(object sender, EventArgs e)
        {
            if (this.nameTextbox.Text == "" || world_names.Contains(this.nameTextbox.Text))
            {
                return;
            }
            string new_dir = Path.Combine(this.world_path, this.nameTextbox.Text);
            Directory.CreateDirectory(new_dir);
            File.WriteAllLines(sp_path, cfg);
            File.Copy(sp_path, new_dir + "\\server.properties", true);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to close out of the world creator? You will lose all data.";
            string title = "Warning!";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}