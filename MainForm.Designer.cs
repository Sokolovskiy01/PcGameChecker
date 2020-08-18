namespace PcGameChecker
{
    partial class MainForm
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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.LeftPanelSettingsButton = new PcGameChecker.GraphExtensions.LeftPanelButton();
            this.LeftPanelGamesButton = new PcGameChecker.GraphExtensions.LeftPanelButton();
            this.LeftPanelMainButton = new PcGameChecker.GraphExtensions.LeftPanelButton();
            this.MainPagePanel = new System.Windows.Forms.Panel();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.LeftPanel.Controls.Add(this.LeftPanelSettingsButton);
            this.LeftPanel.Controls.Add(this.LeftPanelGamesButton);
            this.LeftPanel.Controls.Add(this.LeftPanelMainButton);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.MinimumSize = new System.Drawing.Size(100, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(134, 726);
            this.LeftPanel.TabIndex = 0;
            // 
            // LeftPanelSettingsButton
            // 
            this.LeftPanelSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftPanelSettingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LeftPanelSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LeftPanelSettingsButton.HoverIcon = global::PcGameChecker.Properties.Resources.SettingsHover;
            this.LeftPanelSettingsButton.Icon = global::PcGameChecker.Properties.Resources.Settings;
            this.LeftPanelSettingsButton.IsSelected = false;
            this.LeftPanelSettingsButton.Location = new System.Drawing.Point(0, 606);
            this.LeftPanelSettingsButton.MaximumSize = new System.Drawing.Size(17895696, 120);
            this.LeftPanelSettingsButton.MinimumSize = new System.Drawing.Size(90, 90);
            this.LeftPanelSettingsButton.Name = "LeftPanelSettingsButton";
            this.LeftPanelSettingsButton.Padding = new System.Windows.Forms.Padding(10);
            this.LeftPanelSettingsButton.Size = new System.Drawing.Size(134, 120);
            this.LeftPanelSettingsButton.TabIndex = 2;
            this.LeftPanelSettingsButton.Text = "Settings";
            this.LeftPanelSettingsButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(117)))));
            this.LeftPanelSettingsButton.TextHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(180)))));
            this.LeftPanelSettingsButton.TextRectangleTopPadding = 10;
            this.LeftPanelSettingsButton.Click += new System.EventHandler(this.LeftPanelSettingsButton_Click);
            // 
            // LeftPanelGamesButton
            // 
            this.LeftPanelGamesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftPanelGamesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeftPanelGamesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LeftPanelGamesButton.HoverIcon = global::PcGameChecker.Properties.Resources.GamesHover;
            this.LeftPanelGamesButton.Icon = global::PcGameChecker.Properties.Resources.Games;
            this.LeftPanelGamesButton.IsSelected = false;
            this.LeftPanelGamesButton.Location = new System.Drawing.Point(0, 120);
            this.LeftPanelGamesButton.MaximumSize = new System.Drawing.Size(17895696, 120);
            this.LeftPanelGamesButton.MinimumSize = new System.Drawing.Size(90, 90);
            this.LeftPanelGamesButton.Name = "LeftPanelGamesButton";
            this.LeftPanelGamesButton.Padding = new System.Windows.Forms.Padding(10);
            this.LeftPanelGamesButton.Size = new System.Drawing.Size(134, 120);
            this.LeftPanelGamesButton.TabIndex = 1;
            this.LeftPanelGamesButton.Text = "Games";
            this.LeftPanelGamesButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(117)))));
            this.LeftPanelGamesButton.TextHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(180)))));
            this.LeftPanelGamesButton.TextRectangleTopPadding = 10;
            this.LeftPanelGamesButton.Click += new System.EventHandler(this.LeftPanelGamesButton_Click);
            // 
            // LeftPanelMainButton
            // 
            this.LeftPanelMainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftPanelMainButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeftPanelMainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LeftPanelMainButton.HoverIcon = global::PcGameChecker.Properties.Resources.MainHover;
            this.LeftPanelMainButton.Icon = global::PcGameChecker.Properties.Resources.Main;
            this.LeftPanelMainButton.IsSelected = false;
            this.LeftPanelMainButton.Location = new System.Drawing.Point(0, 0);
            this.LeftPanelMainButton.MaximumSize = new System.Drawing.Size(17895696, 120);
            this.LeftPanelMainButton.MinimumSize = new System.Drawing.Size(90, 90);
            this.LeftPanelMainButton.Name = "LeftPanelMainButton";
            this.LeftPanelMainButton.Padding = new System.Windows.Forms.Padding(10);
            this.LeftPanelMainButton.Size = new System.Drawing.Size(134, 120);
            this.LeftPanelMainButton.TabIndex = 0;
            this.LeftPanelMainButton.Text = "Main";
            this.LeftPanelMainButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(117)))));
            this.LeftPanelMainButton.TextHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(180)))));
            this.LeftPanelMainButton.TextRectangleTopPadding = 10;
            this.LeftPanelMainButton.Click += new System.EventHandler(this.LeftPanelMainButton_Click);
            // 
            // MainPagePanel
            // 
            this.MainPagePanel.AutoScroll = true;
            this.MainPagePanel.BackColor = System.Drawing.Color.White;
            this.MainPagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPagePanel.Location = new System.Drawing.Point(134, 0);
            this.MainPagePanel.Name = "MainPagePanel";
            this.MainPagePanel.Size = new System.Drawing.Size(1183, 726);
            this.MainPagePanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1317, 726);
            this.Controls.Add(this.MainPagePanel);
            this.Controls.Add(this.LeftPanel);
            this.MinimumSize = new System.Drawing.Size(730, 520);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private GraphExtensions.LeftPanelButton LeftPanelSettingsButton;
        private GraphExtensions.LeftPanelButton LeftPanelGamesButton;
        private GraphExtensions.LeftPanelButton LeftPanelMainButton;
        private System.Windows.Forms.Panel MainPagePanel;
    }
}