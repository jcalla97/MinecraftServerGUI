using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

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
        public NewWorldForm(String pd, string[] worlds)
        {
            this.world_names = worlds;
            this.sp_path = pd + "\\Server\\server.properties";
            this.world_path = pd + "\\Server\\worlds";
            InitializeComponent();
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
            catch (Exception e)
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //
        // CFG methods
        //
        private string[] readCFG(string path)
        {
            string[] allLines = File.ReadAllLines(path); int i = 0;
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
            if (this.nameTextbox.Text == "")
            {
                return;
            }
            else
            {
                foreach (string world in world_names)
                {
                    if (this.nameTextbox.Text == world)
                    {
                        return;
                    }
                }
            }
            string new_dir = Path.Combine(this.world_path, this.nameTextbox.Text);
            Directory.CreateDirectory(new_dir);
            
            File.WriteAllLines(sp_path, cfg);
            this.Close();
        }

    }
}