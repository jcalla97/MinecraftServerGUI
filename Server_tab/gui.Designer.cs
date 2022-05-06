namespace MinecraftServerCSharp.Server_tab
{
    partial class gui_ui
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
            this.serverGroupBox = new System.Windows.Forms.GroupBox();
            this.worldCombobox = new System.Windows.Forms.ComboBox();
            this.restartButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.tabController = new System.Windows.Forms.TabControl();
            this.serverTab = new System.Windows.Forms.TabPage();
            this.consoleLog = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.serverGroupBox.SuspendLayout();
            this.tabController.SuspendLayout();
            this.serverTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverGroupBox
            // 
            this.serverGroupBox.AutoSize = true;
            this.serverGroupBox.Controls.Add(this.button1);
            this.serverGroupBox.Controls.Add(this.worldCombobox);
            this.serverGroupBox.Controls.Add(this.restartButton);
            this.serverGroupBox.Controls.Add(this.startButton);
            this.serverGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.serverGroupBox.Location = new System.Drawing.Point(3, 3);
            this.serverGroupBox.MinimumSize = new System.Drawing.Size(0, 50);
            this.serverGroupBox.Name = "serverGroupBox";
            this.serverGroupBox.Size = new System.Drawing.Size(979, 69);
            this.serverGroupBox.TabIndex = 0;
            this.serverGroupBox.TabStop = false;
            this.serverGroupBox.Text = "Server";
            // 
            // worldCombobox
            // 
            this.worldCombobox.Dock = System.Windows.Forms.DockStyle.Right;
            this.worldCombobox.FormattingEnabled = true;
            this.worldCombobox.Location = new System.Drawing.Point(855, 19);
            this.worldCombobox.Name = "worldCombobox";
            this.worldCombobox.Size = new System.Drawing.Size(121, 23);
            this.worldCombobox.TabIndex = 2;
            this.worldCombobox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChange);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(87, 22);
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
            this.startButton.Location = new System.Drawing.Point(6, 22);
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
            this.tabController.Size = new System.Drawing.Size(993, 878);
            this.tabController.TabIndex = 1;
            // 
            // serverTab
            // 
            this.serverTab.Controls.Add(this.consoleLog);
            this.serverTab.Controls.Add(this.serverGroupBox);
            this.serverTab.Location = new System.Drawing.Point(4, 24);
            this.serverTab.Name = "serverTab";
            this.serverTab.Padding = new System.Windows.Forms.Padding(3);
            this.serverTab.Size = new System.Drawing.Size(985, 850);
            this.serverTab.TabIndex = 0;
            this.serverTab.Text = "Server";
            this.serverTab.UseVisualStyleBackColor = true;
            // 
            // consoleLog
            // 
            this.consoleLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleLog.Location = new System.Drawing.Point(3, 72);
            this.consoleLog.Name = "consoleLog";
            this.consoleLog.Size = new System.Drawing.Size(979, 775);
            this.consoleLog.TabIndex = 1;
            this.consoleLog.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gui_ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 878);
            this.Controls.Add(this.tabController);
            this.Name = "gui_ui";
            this.Text = "Minecraft Server";
            this.serverGroupBox.ResumeLayout(false);
            this.serverGroupBox.PerformLayout();
            this.tabController.ResumeLayout(false);
            this.serverTab.ResumeLayout(false);
            this.serverTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox serverGroupBox;
        private Button startButton;
        private TabPage serverTab;
        private TabControl tabController;
        private Button restartButton;
        private ComboBox worldCombobox;
        private RichTextBox consoleLog;
        private Button button1;
    }
}