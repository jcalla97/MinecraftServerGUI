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
            this.startPanel = new System.Windows.Forms.Panel();
            this.worldFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.startFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.tabController.SuspendLayout();
            this.serverTab.SuspendLayout();
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
            this.worldCombobox.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxChange);
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
            this.tabController.Size = new System.Drawing.Size(727, 470);
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
            this.serverTab.Size = new System.Drawing.Size(719, 442);
            this.serverTab.TabIndex = 0;
            this.serverTab.Text = "Server";
            this.serverTab.UseVisualStyleBackColor = true;
            // 
            // consoleLog
            // 
            this.consoleLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleLog.Location = new System.Drawing.Point(3, 38);
            this.consoleLog.Name = "consoleLog";
            this.consoleLog.Size = new System.Drawing.Size(713, 301);
            this.consoleLog.TabIndex = 1;
            this.consoleLog.Text = "";
            // 
            // worldInfoPanel
            // 
            this.worldInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.worldInfoPanel.Location = new System.Drawing.Point(3, 339);
            this.worldInfoPanel.Name = "worldInfoPanel";
            this.worldInfoPanel.Size = new System.Drawing.Size(713, 100);
            this.worldInfoPanel.TabIndex = 8;
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.worldFlowLayout);
            this.startPanel.Controls.Add(this.startFlowLayout);
            this.startPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.startPanel.Location = new System.Drawing.Point(3, 3);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(713, 35);
            this.startPanel.TabIndex = 7;
            // 
            // worldFlowLayout
            // 
            this.worldFlowLayout.AutoSize = true;
            this.worldFlowLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.worldFlowLayout.Controls.Add(this.deleteWorldButton);
            this.worldFlowLayout.Controls.Add(this.worldCombobox);
            this.worldFlowLayout.Dock = System.Windows.Forms.DockStyle.Right;
            this.worldFlowLayout.Location = new System.Drawing.Point(495, 0);
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
            this.ClientSize = new System.Drawing.Size(727, 470);
            this.Controls.Add(this.tabController);
            this.Name = "ServerTabUI";
            this.Text = "Minecraft Server";
            this.tabController.ResumeLayout(false);
            this.serverTab.ResumeLayout(false);
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
    }
}