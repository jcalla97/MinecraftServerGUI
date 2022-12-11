using System.Diagnostics;

namespace MinecraftServerCSharp.Server_tab
{
    public partial class ServerTabUI
    {
        private bool running;
        private bool newWorldOpen;
        private Form parent;
        private NewWorldForm newWorldForm;
        private string javaHome = "C:\\Program Files\\Java\\jdk-17.0.2\\bin\\java.exe";
        private Process server;
        private string projectDirectory = string.Empty;
        private string cfgPath = string.Empty;
        private string worldsDir = string.Empty;
        private string[] cfg;
        public TabPage tab;
        public Dictionary<string, (string, int)> serverProperties = new Dictionary<string, (string, int)>()
        {
            {"difficulty", (string.Empty, 0)},
            {"enforce-whitelist", (string.Empty, 0)},
            {"level-seed", (string.Empty, 0) },
            {"level-name", (string.Empty, 0)},
            {"max-players", (string.Empty, 0)},
            {"motd", (string.Empty, 0)},
            {"online-mode", (string.Empty, 0)},
            {"player-idle-timeout", (string.Empty, 0)},
            {"pvp", (string.Empty, 0)},
            {"require-resource-pack", (string.Empty, 0)},
            {"resource-pack", (string.Empty, 0)},
            {"server-ip", (string.Empty, 0)},
            {"server-port", (string.Empty, 0)},
            {"spawn-protection", (string.Empty, 0)},
        };
        Dictionary<string, string> difficultyDict = new Dictionary<string, string>()
        {
                {"Peaceful", "peaceful"},
                {"Easy", "easy"},
                {"Normal", "normal"},
                {"Hard", "hard"},
        };
        public static Dictionary<string, CheckBox> checkboxConfigsItems;
        public static Dictionary<string, ComboBox> dropDownConfigItems;
        public static Dictionary<string, TextBox> textBoxConfigItems; 
    }
}