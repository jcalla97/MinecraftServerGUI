namespace MinecraftServerCSharp.Server_tab
{
    partial class ServerTabUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deleteWorldButton = new System.Windows.Forms.Button();
            this.worldCombobox = new System.Windows.Forms.ComboBox();
            this.restartButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.tabController = new System.Windows.Forms.TabControl();
            this.serverTab = new System.Windows.Forms.TabPage();
            this.consoleLog = new System.Windows.Forms.RichTextBox();
            this.worldInfoPanel = new System.Windows.Forms.Panel();
            this.motdTextBox = new System.Windows.Forms.RichTextBox();
            this.motdLabel = new System.Windows.Forms.Label();
            this.checkBoxPanel2 = new System.Windows.Forms.Panel();
            this.resourcePackCheckBox = new System.Windows.Forms.CheckBox();
            this.whitelistCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBoxPanel = new System.Windows.Forms.Panel();
            this.onlineMode = new System.Windows.Forms.CheckBox();
            this.pvpCheckBox = new System.Windows.Forms.CheckBox();
            this.difficultyPanel = new System.Windows.Forms.Panel();
            this.difficultyComboBox = new System.Windows.Forms.ComboBox();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.spawnProtectionPanel = new System.Windows.Forms.Panel();
            this.spawnProtectionTextBox = new System.Windows.Forms.TextBox();
            this.spawnProtectionLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.playerIdleTextBox = new System.Windows.Forms.TextBox();
            this.playerIdleLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.maxPlayersTextBox = new System.Windows.Forms.TextBox();
            this.maxPlayersLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.serverPortTextBox = new System.Windows.Forms.TextBox();
            this.serverPortLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.serverIpTextbox = new System.Windows.Forms.TextBox();
            this.serverIpLabel = new System.Windows.Forms.Label();
            this.startPanel = new System.Windows.Forms.Panel();
            this.worldFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.startFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.tabController.SuspendLayout();
            this.serverTab.SuspendLayout();
            this.worldInfoPanel.SuspendLayout();
            this.checkBoxPanel2.SuspendLayout();
            this.checkBoxPanel.SuspendLayout();
            this.difficultyPanel.SuspendLayout();
            this.spawnProtectionPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.startPanel.SuspendLayout();
            this.worldFlowLayout.SuspendLayout();
            this.startFlowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteWorldButton
            // 
            this.deleteWorldButton.AutoSize = true;
            this.deleteWorldButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteWorldButton.Location = new System.Drawing.Point(3, 3);
            this.deleteWorldButton.MaximumSize = new System.Drawing.Size(85, 25);
            this.deleteWorldButton.MinimumSize = new System.Drawing.Size(85, 25);
            this.deleteWorldButton.Name = "deleteWorldButton";
            this.deleteWorldButton.Size = new System.Drawing.Size(85, 25);
            this.deleteWorldButton.TabIndex = 3;
            this.deleteWorldButton.Text = "Delete World";
            this.deleteWorldButton.UseVisualStyleBackColor = true;
            this.deleteWorldButton.Click += new System.EventHandler(this.DeleteWorldClick);
            // 
            // worldCombobox
            // 
            this.worldCombobox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.worldCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.worldCombobox.FormattingEnabled = true;
            this.worldCombobox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.worldCombobox.Location = new System.Drawing.Point(94, 4);
            this.worldCombobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.worldCombobox.Name = "worldCombobox";
            this.worldCombobox.Size = new System.Drawing.Size(121, 23);
            this.worldCombobox.TabIndex = 2;
            this.worldCombobox.SelectionChangeCommitted += new System.EventHandler(this.worldComboBoxChange);
            // 
            // restartButton
            // 
            this.restartButton.AutoSize = true;
            this.restartButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.restartButton.Location = new System.Drawing.Point(84, 3);
            this.restartButton.MaximumSize = new System.Drawing.Size(75, 25);
            this.restartButton.MinimumSize = new System.Drawing.Size(75, 25);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 25);
            this.restartButton.TabIndex = 1;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.RestartButtonClick);
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.startButton.Location = new System.Drawing.Point(3, 3);
            this.startButton.MaximumSize = new System.Drawing.Size(75, 25);
            this.startButton.MinimumSize = new System.Drawing.Size(75, 25);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 25);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.serverTab);
            this.tabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabController.Location = new System.Drawing.Point(0, 0);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(838, 692);
            this.tabController.TabIndex = 1;
            // 
            // serverTab
            // 
            this.serverTab.Controls.Add(this.consoleLog);
            this.serverTab.Controls.Add(this.worldInfoPanel);
            this.serverTab.Controls.Add(this.startPanel);
            this.serverTab.Location = new System.Drawing.Point(4, 24);
            this.serverTab.Name = "serverTab";
            this.serverTab.Padding = new System.Windows.Forms.Padding(3);
            this.serverTab.Size = new System.Drawing.Size(830, 664);
            this.serverTab.TabIndex = 0;
            this.serverTab.Text = "Server";
            this.serverTab.UseVisualStyleBackColor = true;
            // 
            // consoleLog
            // 
            this.consoleLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleLog.Location = new System.Drawing.Point(208, 38);
            this.consoleLog.Name = "consoleLog";
            this.consoleLog.Size = new System.Drawing.Size(619, 623);
            this.consoleLog.TabIndex = 1;
            this.consoleLog.Text = "";
            // 
            // worldInfoPanel
            // 
            this.worldInfoPanel.AutoSize = true;
            this.worldInfoPanel.Controls.Add(this.motdTextBox);
            this.worldInfoPanel.Controls.Add(this.motdLabel);
            this.worldInfoPanel.Controls.Add(this.checkBoxPanel2);
            this.worldInfoPanel.Controls.Add(this.checkBoxPanel);
            this.worldInfoPanel.Controls.Add(this.difficultyPanel);
            this.worldInfoPanel.Controls.Add(this.spawnProtectionPanel);
            this.worldInfoPanel.Controls.Add(this.panel5);
            this.worldInfoPanel.Controls.Add(this.panel4);
            this.worldInfoPanel.Controls.Add(this.panel2);
            this.worldInfoPanel.Controls.Add(this.panel1);
            this.worldInfoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.worldInfoPanel.Location = new System.Drawing.Point(3, 38);
            this.worldInfoPanel.MinimumSize = new System.Drawing.Size(205, 0);
            this.worldInfoPanel.Name = "worldInfoPanel";
            this.worldInfoPanel.Size = new System.Drawing.Size(205, 623);
            this.worldInfoPanel.TabIndex = 8;
            // 
            // motdTextBox
            // 
            this.motdTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motdTextBox.Location = new System.Drawing.Point(0, 265);
            this.motdTextBox.Name = "motdTextBox";
            this.motdTextBox.Size = new System.Drawing.Size(205, 358);
            this.motdTextBox.TabIndex = 6;
            this.motdTextBox.Text = "";
            this.motdTextBox.Leave += new System.EventHandler(this.motdTextBoxChange);
            // 
            // motdLabel
            // 
            this.motdLabel.AutoSize = true;
            this.motdLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.motdLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.motdLabel.Location = new System.Drawing.Point(0, 240);
            this.motdLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.motdLabel.Name = "motdLabel";
            this.motdLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.motdLabel.Size = new System.Drawing.Size(113, 25);
            this.motdLabel.TabIndex = 5;
            this.motdLabel.Text = "Message of the Day:";
            // 
            // checkBoxPanel2
            // 
            this.checkBoxPanel2.AutoSize = true;
            this.checkBoxPanel2.Controls.Add(this.resourcePackCheckBox);
            this.checkBoxPanel2.Controls.Add(this.whitelistCheckBox);
            this.checkBoxPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxPanel2.Location = new System.Drawing.Point(0, 210);
            this.checkBoxPanel2.MinimumSize = new System.Drawing.Size(200, 30);
            this.checkBoxPanel2.Name = "checkBoxPanel2";
            this.checkBoxPanel2.Size = new System.Drawing.Size(205, 30);
            this.checkBoxPanel2.TabIndex = 8;
            // 
            // resourcePackCheckBox
            // 
            this.resourcePackCheckBox.AutoSize = true;
            this.resourcePackCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.resourcePackCheckBox.Location = new System.Drawing.Point(72, 0);
            this.resourcePackCheckBox.Name = "resourcePackCheckBox";
            this.resourcePackCheckBox.Size = new System.Drawing.Size(145, 30);
            this.resourcePackCheckBox.TabIndex = 1;
            this.resourcePackCheckBox.Text = "Require Resource Pack";
            this.resourcePackCheckBox.UseVisualStyleBackColor = true;
            this.resourcePackCheckBox.Click += new System.EventHandler(this.worldInfoCheckboxChanged);
            // 
            // whitelistCheckBox
            // 
            this.whitelistCheckBox.AutoSize = true;
            this.whitelistCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.whitelistCheckBox.Location = new System.Drawing.Point(0, 0);
            this.whitelistCheckBox.Name = "whitelistCheckBox";
            this.whitelistCheckBox.Size = new System.Drawing.Size(72, 30);
            this.whitelistCheckBox.TabIndex = 0;
            this.whitelistCheckBox.Text = "Whitelist";
            this.whitelistCheckBox.UseVisualStyleBackColor = true;
            this.whitelistCheckBox.Click += new System.EventHandler(this.worldInfoCheckboxChanged);
            // 
            // checkBoxPanel
            // 
            this.checkBoxPanel.AutoSize = true;
            this.checkBoxPanel.Controls.Add(this.onlineMode);
            this.checkBoxPanel.Controls.Add(this.pvpCheckBox);
            this.checkBoxPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxPanel.Location = new System.Drawing.Point(0, 180);
            this.checkBoxPanel.MinimumSize = new System.Drawing.Size(200, 30);
            this.checkBoxPanel.Name = "checkBoxPanel";
            this.checkBoxPanel.Size = new System.Drawing.Size(205, 30);
            this.checkBoxPanel.TabIndex = 7;
            // 
            // onlineMode
            // 
            this.onlineMode.AutoSize = true;
            this.onlineMode.Dock = System.Windows.Forms.DockStyle.Left;
            this.onlineMode.Location = new System.Drawing.Point(80, 0);
            this.onlineMode.Name = "onlineMode";
            this.onlineMode.Size = new System.Drawing.Size(95, 30);
            this.onlineMode.TabIndex = 1;
            this.onlineMode.Text = "Online Mode";
            this.onlineMode.UseVisualStyleBackColor = true;
            this.onlineMode.Click += new System.EventHandler(this.worldInfoCheckboxChanged);
            // 
            // pvpCheckBox
            // 
            this.pvpCheckBox.AutoSize = true;
            this.pvpCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pvpCheckBox.Location = new System.Drawing.Point(0, 0);
            this.pvpCheckBox.Name = "pvpCheckBox";
            this.pvpCheckBox.Size = new System.Drawing.Size(80, 30);
            this.pvpCheckBox.TabIndex = 0;
            this.pvpCheckBox.Text = "Pvp Mode";
            this.pvpCheckBox.UseVisualStyleBackColor = true;
            this.pvpCheckBox.Click += new System.EventHandler(this.worldInfoCheckboxChanged);
            // 
            // difficultyPanel
            // 
            this.difficultyPanel.AutoSize = true;
            this.difficultyPanel.Controls.Add(this.difficultyComboBox);
            this.difficultyPanel.Controls.Add(this.difficultyLabel);
            this.difficultyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.difficultyPanel.Location = new System.Drawing.Point(0, 150);
            this.difficultyPanel.MinimumSize = new System.Drawing.Size(0, 30);
            this.difficultyPanel.Name = "difficultyPanel";
            this.difficultyPanel.Size = new System.Drawing.Size(205, 30);
            this.difficultyPanel.TabIndex = 5;
            // 
            // difficultyComboBox
            // 
            this.difficultyComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.difficultyComboBox.FormattingEnabled = true;
            this.difficultyComboBox.Items.AddRange(new object[] {
            "Peaceful",
            "Easy",
            "Normal",
            "Hard"});
            this.difficultyComboBox.Location = new System.Drawing.Point(55, 0);
            this.difficultyComboBox.Name = "difficultyComboBox";
            this.difficultyComboBox.Size = new System.Drawing.Size(150, 23);
            this.difficultyComboBox.TabIndex = 1;
            this.difficultyComboBox.SelectionChangeCommitted += new System.EventHandler(this.difficultyComboBoxChange);
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.difficultyLabel.Location = new System.Drawing.Point(0, 0);
            this.difficultyLabel.MinimumSize = new System.Drawing.Size(0, 23);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.difficultyLabel.Size = new System.Drawing.Size(55, 23);
            this.difficultyLabel.TabIndex = 0;
            this.difficultyLabel.Text = "Difficulty";
            // 
            // spawnProtectionPanel
            // 
            this.spawnProtectionPanel.AutoSize = true;
            this.spawnProtectionPanel.Controls.Add(this.spawnProtectionTextBox);
            this.spawnProtectionPanel.Controls.Add(this.spawnProtectionLabel);
            this.spawnProtectionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.spawnProtectionPanel.Location = new System.Drawing.Point(0, 120);
            this.spawnProtectionPanel.MinimumSize = new System.Drawing.Size(0, 30);
            this.spawnProtectionPanel.Name = "spawnProtectionPanel";
            this.spawnProtectionPanel.Size = new System.Drawing.Size(205, 30);
            this.spawnProtectionPanel.TabIndex = 9;
            // 
            // spawnProtectionTextBox
            // 
            this.spawnProtectionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spawnProtectionTextBox.Location = new System.Drawing.Point(150, 0);
            this.spawnProtectionTextBox.Name = "spawnProtectionTextBox";
            this.spawnProtectionTextBox.Size = new System.Drawing.Size(55, 23);
            this.spawnProtectionTextBox.TabIndex = 1;
            this.spawnProtectionTextBox.Leave += new System.EventHandler(this.worldInfoTextBoxChanged);
            // 
            // spawnProtectionLabel
            // 
            this.spawnProtectionLabel.AutoSize = true;
            this.spawnProtectionLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.spawnProtectionLabel.Location = new System.Drawing.Point(0, 0);
            this.spawnProtectionLabel.MinimumSize = new System.Drawing.Size(150, 23);
            this.spawnProtectionLabel.Name = "spawnProtectionLabel";
            this.spawnProtectionLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.spawnProtectionLabel.Size = new System.Drawing.Size(150, 23);
            this.spawnProtectionLabel.TabIndex = 0;
            this.spawnProtectionLabel.Text = "Spawn Protection Bounds:";
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.playerIdleTextBox);
            this.panel5.Controls.Add(this.playerIdleLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 90);
            this.panel5.MinimumSize = new System.Drawing.Size(0, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(205, 30);
            this.panel5.TabIndex = 4;
            // 
            // playerIdleTextBox
            // 
            this.playerIdleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerIdleTextBox.Location = new System.Drawing.Point(150, 0);
            this.playerIdleTextBox.Name = "playerIdleTextBox";
            this.playerIdleTextBox.Size = new System.Drawing.Size(55, 23);
            this.playerIdleTextBox.TabIndex = 1;
            this.playerIdleTextBox.Leave += new System.EventHandler(this.worldInfoTextBoxChanged);
            // 
            // playerIdleLabel
            // 
            this.playerIdleLabel.AutoSize = true;
            this.playerIdleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.playerIdleLabel.Location = new System.Drawing.Point(0, 0);
            this.playerIdleLabel.MinimumSize = new System.Drawing.Size(150, 23);
            this.playerIdleLabel.Name = "playerIdleLabel";
            this.playerIdleLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.playerIdleLabel.Size = new System.Drawing.Size(150, 23);
            this.playerIdleLabel.TabIndex = 0;
            this.playerIdleLabel.Text = "Player Idle Timeout (s):";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.maxPlayersTextBox);
            this.panel4.Controls.Add(this.maxPlayersLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 60);
            this.panel4.MinimumSize = new System.Drawing.Size(0, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 30);
            this.panel4.TabIndex = 3;
            // 
            // maxPlayersTextBox
            // 
            this.maxPlayersTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxPlayersTextBox.Location = new System.Drawing.Point(150, 0);
            this.maxPlayersTextBox.Name = "maxPlayersTextBox";
            this.maxPlayersTextBox.Size = new System.Drawing.Size(55, 23);
            this.maxPlayersTextBox.TabIndex = 1;
            this.maxPlayersTextBox.Leave += new System.EventHandler(this.worldInfoTextBoxChanged);
            // 
            // maxPlayersLabel
            // 
            this.maxPlayersLabel.AutoSize = true;
            this.maxPlayersLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.maxPlayersLabel.Location = new System.Drawing.Point(0, 0);
            this.maxPlayersLabel.MinimumSize = new System.Drawing.Size(150, 23);
            this.maxPlayersLabel.Name = "maxPlayersLabel";
            this.maxPlayersLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.maxPlayersLabel.Size = new System.Drawing.Size(150, 23);
            this.maxPlayersLabel.TabIndex = 0;
            this.maxPlayersLabel.Text = "Max Players:";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.serverPortTextBox);
            this.panel2.Controls.Add(this.serverPortLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.MinimumSize = new System.Drawing.Size(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 30);
            this.panel2.TabIndex = 1;
            // 
            // serverPortTextBox
            // 
            this.serverPortTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverPortTextBox.Location = new System.Drawing.Point(125, 0);
            this.serverPortTextBox.Name = "serverPortTextBox";
            this.serverPortTextBox.Size = new System.Drawing.Size(80, 23);
            this.serverPortTextBox.TabIndex = 1;
            this.serverPortTextBox.Leave += new System.EventHandler(this.worldInfoTextBoxChanged);
            // 
            // serverPortLabel
            // 
            this.serverPortLabel.AutoSize = true;
            this.serverPortLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.serverPortLabel.Location = new System.Drawing.Point(0, 0);
            this.serverPortLabel.MinimumSize = new System.Drawing.Size(125, 23);
            this.serverPortLabel.Name = "serverPortLabel";
            this.serverPortLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.serverPortLabel.Size = new System.Drawing.Size(125, 23);
            this.serverPortLabel.TabIndex = 0;
            this.serverPortLabel.Text = "Server Port:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.serverIpTextbox);
            this.panel1.Controls.Add(this.serverIpLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 30);
            this.panel1.TabIndex = 0;
            // 
            // serverIpTextbox
            // 
            this.serverIpTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverIpTextbox.Location = new System.Drawing.Point(55, 0);
            this.serverIpTextbox.Name = "serverIpTextbox";
            this.serverIpTextbox.Size = new System.Drawing.Size(150, 23);
            this.serverIpTextbox.TabIndex = 1;
            this.serverIpTextbox.Leave += new System.EventHandler(this.worldInfoTextBoxChanged);
            // 
            // serverIpLabel
            // 
            this.serverIpLabel.AutoSize = true;
            this.serverIpLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.serverIpLabel.Location = new System.Drawing.Point(0, 0);
            this.serverIpLabel.MinimumSize = new System.Drawing.Size(0, 23);
            this.serverIpLabel.Name = "serverIpLabel";
            this.serverIpLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.serverIpLabel.Size = new System.Drawing.Size(55, 23);
            this.serverIpLabel.TabIndex = 0;
            this.serverIpLabel.Text = "Server IP:";
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.worldFlowLayout);
            this.startPanel.Controls.Add(this.startFlowLayout);
            this.startPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.startPanel.Location = new System.Drawing.Point(3, 3);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(824, 35);
            this.startPanel.TabIndex = 7;
            // 
            // worldFlowLayout
            // 
            this.worldFlowLayout.AutoSize = true;
            this.worldFlowLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.worldFlowLayout.Controls.Add(this.deleteWorldButton);
            this.worldFlowLayout.Controls.Add(this.worldCombobox);
            this.worldFlowLayout.Dock = System.Windows.Forms.DockStyle.Right;
            this.worldFlowLayout.Location = new System.Drawing.Point(606, 0);
            this.worldFlowLayout.MaximumSize = new System.Drawing.Size(218, 31);
            this.worldFlowLayout.MinimumSize = new System.Drawing.Size(218, 31);
            this.worldFlowLayout.Name = "worldFlowLayout";
            this.worldFlowLayout.Size = new System.Drawing.Size(218, 31);
            this.worldFlowLayout.TabIndex = 6;
            // 
            // startFlowLayout
            // 
            this.startFlowLayout.AutoSize = true;
            this.startFlowLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startFlowLayout.Controls.Add(this.startButton);
            this.startFlowLayout.Controls.Add(this.restartButton);
            this.startFlowLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.startFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.startFlowLayout.MaximumSize = new System.Drawing.Size(162, 31);
            this.startFlowLayout.MinimumSize = new System.Drawing.Size(162, 31);
            this.startFlowLayout.Name = "startFlowLayout";
            this.startFlowLayout.Size = new System.Drawing.Size(162, 31);
            this.startFlowLayout.TabIndex = 5;
            // 
            // ServerTabUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 692);
            this.Controls.Add(this.tabController);
            this.Name = "ServerTabUI";
            this.Text = "Minecraft Server";
            this.tabController.ResumeLayout(false);
            this.serverTab.ResumeLayout(false);
            this.serverTab.PerformLayout();
            this.worldInfoPanel.ResumeLayout(false);
            this.worldInfoPanel.PerformLayout();
            this.checkBoxPanel2.ResumeLayout(false);
            this.checkBoxPanel2.PerformLayout();
            this.checkBoxPanel.ResumeLayout(false);
            this.checkBoxPanel.PerformLayout();
            this.difficultyPanel.ResumeLayout(false);
            this.difficultyPanel.PerformLayout();
            this.spawnProtectionPanel.ResumeLayout(false);
            this.spawnProtectionPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            this.worldFlowLayout.ResumeLayout(false);
            this.worldFlowLayout.PerformLayout();
            this.startFlowLayout.ResumeLayout(false);
            this.startFlowLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button startButton;
        private TabPage serverTab;
        private TabControl tabController;
        private Button restartButton;
        private ComboBox worldCombobox;
        private RichTextBox consoleLog;
        private Button deleteWorldButton;
        private Panel startPanel;
        private FlowLayoutPanel worldFlowLayout;
        private FlowLayoutPanel startFlowLayout;
        private Panel worldInfoPanel;
        private Panel panel1;
        private TextBox serverIpTextbox;
        private Label serverIpLabel;
        private Panel panel2;
        private TextBox serverPortTextBox;
        private Label serverPortLabel;
        private Panel panel4;
        private TextBox maxPlayersTextBox;
        private Label maxPlayersLabel;
        private Panel panel5;
        private TextBox playerIdleTextBox;
        private Label playerIdleLabel;
        private RichTextBox motdTextBox;
        private Label motdLabel;
        private Panel difficultyPanel;
        private ComboBox difficultyComboBox;
        private Label difficultyLabel;
        private Panel checkBoxPanel2;
        private CheckBox resourcePackCheckBox;
        private CheckBox whitelistCheckBox;
        private Panel checkBoxPanel;
        private CheckBox onlineMode;
        private CheckBox pvpCheckBox;
        private Panel spawnProtectionPanel;
        private TextBox spawnProtectionTextBox;
        private Label spawnProtectionLabel;
    }
}