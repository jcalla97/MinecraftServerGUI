using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftServerCSharp.common
{
    internal class MVC
    {

        public Dictionary<string, object?> views = new Dictionary<string, object?>();
        public Dictionary<string, object?> models = new Dictionary<string, object?>();
        public string projectDirectory = "";
        public TabPage tab;
    }

    internal class Controller : MVC
    {
        public void Shutdown()
        {
            foreach (var model in this.models.Values)
            {

            }
            foreach (var view in this.views.Values)
            {

            }
        }
        public TabPage GetTabPage()
        { 
            return this.tab;
        }
    }

    internal class Model : MVC
    {

    }

    internal class View : MVC
    {
        
    }
}
