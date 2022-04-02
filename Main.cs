using System;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;
using System.Timers;
using System.Reflection;
using MinecraftServerCSharp.common;

namespace MinecraftServerCSharp
{
    public partial class mainWindow : Form
    {
        private string typeName = "";
        public mainWindow()
        {
            // Retrieve working directory
            string workingDirectory = Environment.CurrentDirectory;
            projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            // Initialize window
            InitializeComponent();

            // Instantiate Controllers
            string @namespace = "MinecraftServerCSharp";
            string @class = "Controller";
            string[] directories = Directory.GetDirectories(projectDirectory);

            foreach (string dir in directories)
            {
                Controller control;
                if (File.Exists(dir + "\\Controller.cs"))
                {
                    try
                    {
                        string[] dir_list = dir.Split("\\");
                        string d = dir_list[dir_list.Length - 1];
                        control = load_controller(d);
                        controllers.Add(d, control);
                        this.tabController.Controls.Add(control.GetTabPage());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e);
                        continue;
                    }
                }
            }

            // Start a Timer
            System.Timers.Timer backupTimmer = new System.Timers.Timer(3600);
            // backupTimmer.Elapsed += backup;
            // backupTimmer.Enabled = true;
        }

        private Controller load_controller(string name)
        {
            typeName = "MinecraftServerCSharp." + name + ".Controller";
            object?[] args = new object?[] { this.projectDirectory, this };
            Type type = Type.GetType(typeName);
            Assembly assem = type.Assembly;
            Controller control = (Controller)assem.CreateInstance(typeName, true, BindingFlags.Default, null, args:args, null, null);
            return control;
        }

        public void Shutdown()
        {
            foreach(Controller control in this.controllers.Values)
            {
                control.Shutdown();
            }
        }

        private string projectDirectory;
        Dictionary<string, object> controllers = new Dictionary<string, object>();
    }
}