namespace MinecraftServerCSharp
{
    partial class mainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serverGroupBox = new System.Windows.Forms.GroupBox();
            this.restartButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.tabController = new System.Windows.Forms.TabControl();
            this.serverTab = new System.Windows.Forms.TabPage();
            this.pluginsTab = new System.Windows.Forms.TabPage();
            consoleLog = new System.Windows.Forms.RichTextBox();
            this.serverGroupBox.SuspendLayout();
            this.tabController.SuspendLayout();
            this.serverTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverGroupBox
            // 
            this.serverGroupBox.AutoSize = true;
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
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(87, 22);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 23);
            this.restartButton.TabIndex = 1;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
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
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.serverTab);
            this.tabController.Controls.Add(this.pluginsTab);
            this.tabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabController.Location = new System.Drawing.Point(0, 0);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(993, 878);
            this.tabController.TabIndex = 1;
            // 
            // serverTab
            // 
            this.serverTab.Controls.Add(consoleLog);
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
            consoleLog.Dock = System.Windows.Forms.DockStyle.Fill;
            consoleLog.Location = new System.Drawing.Point(3, 72);
            consoleLog.Name = "consoleLog";
            consoleLog.Size = new System.Drawing.Size(979, 775);
            consoleLog.TabIndex = 1;
            consoleLog.Text = "";
            // 
            // pluginsTab
            // 
            this.pluginsTab.Location = new System.Drawing.Point(4, 24);
            this.pluginsTab.Name = "pluginsTab";
            this.pluginsTab.Padding = new System.Windows.Forms.Padding(3);
            this.pluginsTab.Size = new System.Drawing.Size(553, 422);
            this.pluginsTab.TabIndex = 1;
            this.pluginsTab.Text = "Plugins";
            this.pluginsTab.UseVisualStyleBackColor = true;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 878);
            this.Controls.Add(this.tabController);
            this.Name = "mainWindow";
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
        private TabControl tabController;
        private TabPage serverTab;
        private TabPage pluginsTab;
        private Button restartButton;
        private RichTextBox consoleLog;
    }
}