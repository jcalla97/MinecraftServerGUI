using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinecraftServerCSharp.common;

namespace MinecraftServerCSharp.Server_tab
{
    internal class Controller : common.Controller
    {
        public Controller(string projectDirectory, Form parent)
        {
            Gui view = new Gui(projectDirectory, parent);
            this.views.Add("gui", view);
            this.tab = view.tab;
        }

    }
}
