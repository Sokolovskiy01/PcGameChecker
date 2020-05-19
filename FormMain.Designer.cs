namespace PcGameChecker
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.HomePanel = new System.Windows.Forms.Panel();
            this.HomeGamesPanel = new System.Windows.Forms.Panel();
            this.HomeFreeDiskLabel = new System.Windows.Forms.Label();
            this.HomeInfoPanel = new System.Windows.Forms.Panel();
            this.panelfakeborder = new System.Windows.Forms.Panel();
            this.HomeInfoProcessorCounterLabel = new System.Windows.Forms.Label();
            this.HomeInfoPanelGPUIcon = new System.Windows.Forms.PictureBox();
            this.HomeInfoPanelRAMLabel = new System.Windows.Forms.Label();
            this.HomeInfoPanelRAMIcon = new System.Windows.Forms.PictureBox();
            this.HomeInfoPanelGPULabel = new System.Windows.Forms.Label();
            this.HomeInfoPanelProcessorIcon = new System.Windows.Forms.PictureBox();
            this.HomePanelInfoCMName = new System.Windows.Forms.Label();
            this.HomeInfoPanelProcessorLabel = new System.Windows.Forms.Label();
            this.CPU_perf = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.minimizeButton1 = new PcGameChecker.MinimizeButton();
            this.closeButton1 = new PcGameChecker.CloseButton();
            this.LeftPanel = new PcGameChecker.PanelWithBorder();
            this.GamesButton = new PcGameChecker.PictureButton();
            this.HomeButton = new PcGameChecker.PictureButton();
            this.SettingsButton = new PcGameChecker.PictureButton();
            this.GamesPanel = new System.Windows.Forms.Panel();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.HomePanel.SuspendLayout();
            this.HomeGamesPanel.SuspendLayout();
            this.HomeInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeInfoPanelGPUIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeInfoPanelRAMIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeInfoPanelProcessorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_perf)).BeginInit();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.Color.Transparent;
            this.HomePanel.Controls.Add(this.HomeGamesPanel);
            this.HomePanel.Controls.Add(this.HomeInfoPanel);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(106, 0);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(1214, 730);
            this.HomePanel.TabIndex = 0;
            // 
            // HomeGamesPanel
            // 
            this.HomeGamesPanel.AutoScroll = true;
            this.HomeGamesPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HomeGamesPanel.Controls.Add(this.HomeFreeDiskLabel);
            this.HomeGamesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeGamesPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomeGamesPanel.Location = new System.Drawing.Point(0, 280);
            this.HomeGamesPanel.Name = "HomeGamesPanel";
            this.HomeGamesPanel.Size = new System.Drawing.Size(1214, 450);
            this.HomeGamesPanel.TabIndex = 9;
            // 
            // HomeFreeDiskLabel
            // 
            this.HomeFreeDiskLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeFreeDiskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomeFreeDiskLabel.Location = new System.Drawing.Point(0, 0);
            this.HomeFreeDiskLabel.Margin = new System.Windows.Forms.Padding(0);
            this.HomeFreeDiskLabel.Name = "HomeFreeDiskLabel";
            this.HomeFreeDiskLabel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.HomeFreeDiskLabel.Size = new System.Drawing.Size(230, 72);
            this.HomeFreeDiskLabel.TabIndex = 0;
            this.HomeFreeDiskLabel.Text = "Free disk space :";
            this.HomeFreeDiskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeInfoPanel
            // 
            this.HomeInfoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeInfoPanel.BackgroundImage")));
            this.HomeInfoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HomeInfoPanel.Controls.Add(this.panelfakeborder);
            this.HomeInfoPanel.Controls.Add(this.HomeInfoProcessorCounterLabel);
            this.HomeInfoPanel.Controls.Add(this.HomeInfoPanelGPUIcon);
            this.HomeInfoPanel.Controls.Add(this.HomeInfoPanelRAMLabel);
            this.HomeInfoPanel.Controls.Add(this.HomeInfoPanelRAMIcon);
            this.HomeInfoPanel.Controls.Add(this.HomeInfoPanelGPULabel);
            this.HomeInfoPanel.Controls.Add(this.HomeInfoPanelProcessorIcon);
            this.HomeInfoPanel.Controls.Add(this.HomePanelInfoCMName);
            this.HomeInfoPanel.Controls.Add(this.HomeInfoPanelProcessorLabel);
            this.HomeInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.HomeInfoPanel.Name = "HomeInfoPanel";
            this.HomeInfoPanel.Size = new System.Drawing.Size(1214, 280);
            this.HomeInfoPanel.TabIndex = 7;
            // 
            // panelfakeborder
            // 
            this.panelfakeborder.BackColor = System.Drawing.Color.Black;
            this.panelfakeborder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelfakeborder.Location = new System.Drawing.Point(0, 274);
            this.panelfakeborder.Margin = new System.Windows.Forms.Padding(0);
            this.panelfakeborder.Name = "panelfakeborder";
            this.panelfakeborder.Size = new System.Drawing.Size(1214, 6);
            this.panelfakeborder.TabIndex = 10;
            // 
            // HomeInfoProcessorCounterLabel
            // 
            this.HomeInfoProcessorCounterLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HomeInfoProcessorCounterLabel.Font = new System.Drawing.Font("Comfortaa", 9F);
            this.HomeInfoProcessorCounterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(180)))));
            this.HomeInfoProcessorCounterLabel.Location = new System.Drawing.Point(184, 118);
            this.HomeInfoProcessorCounterLabel.Name = "HomeInfoProcessorCounterLabel";
            this.HomeInfoProcessorCounterLabel.Size = new System.Drawing.Size(60, 60);
            this.HomeInfoProcessorCounterLabel.TabIndex = 7;
            this.HomeInfoProcessorCounterLabel.Text = "100,0%";
            this.HomeInfoProcessorCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeInfoPanelGPUIcon
            // 
            this.HomeInfoPanelGPUIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeInfoPanelGPUIcon.BackgroundImage")));
            this.HomeInfoPanelGPUIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomeInfoPanelGPUIcon.Location = new System.Drawing.Point(540, 98);
            this.HomeInfoPanelGPUIcon.Name = "HomeInfoPanelGPUIcon";
            this.HomeInfoPanelGPUIcon.Size = new System.Drawing.Size(136, 100);
            this.HomeInfoPanelGPUIcon.TabIndex = 2;
            this.HomeInfoPanelGPUIcon.TabStop = false;
            // 
            // HomeInfoPanelRAMLabel
            // 
            this.HomeInfoPanelRAMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomeInfoPanelRAMLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(180)))));
            this.HomeInfoPanelRAMLabel.Location = new System.Drawing.Point(840, 201);
            this.HomeInfoPanelRAMLabel.Name = "HomeInfoPanelRAMLabel";
            this.HomeInfoPanelRAMLabel.Size = new System.Drawing.Size(320, 79);
            this.HomeInfoPanelRAMLabel.TabIndex = 6;
            this.HomeInfoPanelRAMLabel.Text = "RAM capacity";
            this.HomeInfoPanelRAMLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HomeInfoPanelRAMIcon
            // 
            this.HomeInfoPanelRAMIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeInfoPanelRAMIcon.BackgroundImage")));
            this.HomeInfoPanelRAMIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomeInfoPanelRAMIcon.Location = new System.Drawing.Point(951, 98);
            this.HomeInfoPanelRAMIcon.Name = "HomeInfoPanelRAMIcon";
            this.HomeInfoPanelRAMIcon.Size = new System.Drawing.Size(100, 100);
            this.HomeInfoPanelRAMIcon.TabIndex = 3;
            this.HomeInfoPanelRAMIcon.TabStop = false;
            // 
            // HomeInfoPanelGPULabel
            // 
            this.HomeInfoPanelGPULabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomeInfoPanelGPULabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(180)))));
            this.HomeInfoPanelGPULabel.Location = new System.Drawing.Point(447, 201);
            this.HomeInfoPanelGPULabel.Name = "HomeInfoPanelGPULabel";
            this.HomeInfoPanelGPULabel.Size = new System.Drawing.Size(320, 79);
            this.HomeInfoPanelGPULabel.TabIndex = 5;
            this.HomeInfoPanelGPULabel.Text = "GPU name";
            this.HomeInfoPanelGPULabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HomeInfoPanelProcessorIcon
            // 
            this.HomeInfoPanelProcessorIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeInfoPanelProcessorIcon.BackgroundImage")));
            this.HomeInfoPanelProcessorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomeInfoPanelProcessorIcon.Location = new System.Drawing.Point(164, 98);
            this.HomeInfoPanelProcessorIcon.Name = "HomeInfoPanelProcessorIcon";
            this.HomeInfoPanelProcessorIcon.Size = new System.Drawing.Size(100, 100);
            this.HomeInfoPanelProcessorIcon.TabIndex = 1;
            this.HomeInfoPanelProcessorIcon.TabStop = false;
            // 
            // HomePanelInfoCMName
            // 
            this.HomePanelInfoCMName.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomePanelInfoCMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomePanelInfoCMName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(180)))));
            this.HomePanelInfoCMName.Location = new System.Drawing.Point(0, 0);
            this.HomePanelInfoCMName.Margin = new System.Windows.Forms.Padding(0);
            this.HomePanelInfoCMName.Name = "HomePanelInfoCMName";
            this.HomePanelInfoCMName.Size = new System.Drawing.Size(1214, 115);
            this.HomePanelInfoCMName.TabIndex = 0;
            this.HomePanelInfoCMName.Text = "DIMON-LAPTOP";
            this.HomePanelInfoCMName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeInfoPanelProcessorLabel
            // 
            this.HomeInfoPanelProcessorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomeInfoPanelProcessorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(180)))));
            this.HomeInfoPanelProcessorLabel.Location = new System.Drawing.Point(54, 201);
            this.HomeInfoPanelProcessorLabel.Name = "HomeInfoPanelProcessorLabel";
            this.HomeInfoPanelProcessorLabel.Size = new System.Drawing.Size(320, 79);
            this.HomeInfoPanelProcessorLabel.TabIndex = 4;
            this.HomeInfoPanelProcessorLabel.Text = "Processor name";
            this.HomeInfoPanelProcessorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CPU_perf
            // 
            this.CPU_perf.CategoryName = "Processor";
            this.CPU_perf.CounterName = "% Processor time";
            this.CPU_perf.InstanceName = "_Total";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // minimizeButton1
            // 
            this.minimizeButton1.Buttoncolor = System.Drawing.Color.Transparent;
            this.minimizeButton1.ButtonHoverColor = System.Drawing.Color.Silver;
            this.minimizeButton1.icon = ((System.Drawing.Image)(resources.GetObject("minimizeButton1.icon")));
            this.minimizeButton1.Location = new System.Drawing.Point(1240, 0);
            this.minimizeButton1.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeButton1.Name = "minimizeButton1";
            this.minimizeButton1.Size = new System.Drawing.Size(40, 30);
            this.minimizeButton1.TabIndex = 2;
            this.minimizeButton1.Text = "minimizeButton1";
            this.minimizeButton1.Click += new System.EventHandler(this.minimizeButton1_Click);
            // 
            // closeButton1
            // 
            this.closeButton1.Buttoncolor = System.Drawing.Color.Transparent;
            this.closeButton1.ButtonHoverColor = System.Drawing.Color.Red;
            this.closeButton1.icon = ((System.Drawing.Image)(resources.GetObject("closeButton1.icon")));
            this.closeButton1.icon2 = ((System.Drawing.Image)(resources.GetObject("closeButton1.icon2")));
            this.closeButton1.Location = new System.Drawing.Point(1280, 0);
            this.closeButton1.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(40, 30);
            this.closeButton1.TabIndex = 1;
            this.closeButton1.Text = "closeButton1";
            this.closeButton1.Click += new System.EventHandler(this.closeButton1_Click);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.White;
            this.LeftPanel.BackgroundColor = System.Drawing.Color.White;
            this.LeftPanel.BorderBottom = false;
            this.LeftPanel.BorderColor = System.Drawing.Color.Black;
            this.LeftPanel.BorderLeft = false;
            this.LeftPanel.BorderRight = true;
            this.LeftPanel.BorderTop = false;
            this.LeftPanel.BorderWidth = 6;
            this.LeftPanel.Controls.Add(this.GamesButton);
            this.LeftPanel.Controls.Add(this.HomeButton);
            this.LeftPanel.Controls.Add(this.SettingsButton);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(106, 730);
            this.LeftPanel.TabIndex = 0;
            // 
            // GamesButton
            // 
            this.GamesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GamesButton.Location = new System.Drawing.Point(10, 98);
            this.GamesButton.Name = "GamesButton";
            this.GamesButton.Picture1 = ((System.Drawing.Image)(resources.GetObject("GamesButton.Picture1")));
            this.GamesButton.Picture2 = ((System.Drawing.Image)(resources.GetObject("GamesButton.Picture2")));
            this.GamesButton.Size = new System.Drawing.Size(80, 80);
            this.GamesButton.TabIndex = 2;
            this.GamesButton.Text = "pictureButton1";
            this.GamesButton.Click += new System.EventHandler(this.GamesButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.Location = new System.Drawing.Point(10, 12);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Picture1 = ((System.Drawing.Image)(resources.GetObject("HomeButton.Picture1")));
            this.HomeButton.Picture2 = ((System.Drawing.Image)(resources.GetObject("HomeButton.Picture2")));
            this.HomeButton.Size = new System.Drawing.Size(80, 80);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "pictureButton1";
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.Location = new System.Drawing.Point(10, 638);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Picture1 = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Picture1")));
            this.SettingsButton.Picture2 = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Picture2")));
            this.SettingsButton.Size = new System.Drawing.Size(80, 80);
            this.SettingsButton.TabIndex = 0;
            this.SettingsButton.Text = "pictureButton1";
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // GamesPanel
            // 
            this.GamesPanel.BackColor = System.Drawing.Color.LightGray;
            this.GamesPanel.Location = new System.Drawing.Point(169, 112);
            this.GamesPanel.Name = "GamesPanel";
            this.GamesPanel.Size = new System.Drawing.Size(576, 323);
            this.GamesPanel.TabIndex = 3;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.Maroon;
            this.SettingsPanel.Location = new System.Drawing.Point(143, 180);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(549, 369);
            this.SettingsPanel.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1320, 730);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.GamesPanel);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.minimizeButton1);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.HomePanel.ResumeLayout(false);
            this.HomeGamesPanel.ResumeLayout(false);
            this.HomeInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeInfoPanelGPUIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeInfoPanelRAMIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeInfoPanelProcessorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_perf)).EndInit();
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PanelWithBorder LeftPanel;
        private CloseButton closeButton1;
        private MinimizeButton minimizeButton1;
        private PictureButton SettingsButton;
        private PictureButton HomeButton;
        private PictureButton GamesButton;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Label HomePanelInfoCMName;
        private System.Windows.Forms.PictureBox HomeInfoPanelProcessorIcon;
        private System.Windows.Forms.Label HomeInfoPanelProcessorLabel;
        private System.Windows.Forms.PictureBox HomeInfoPanelRAMIcon;
        private System.Windows.Forms.PictureBox HomeInfoPanelGPUIcon;
        private System.Windows.Forms.Label HomeInfoPanelRAMLabel;
        private System.Windows.Forms.Label HomeInfoPanelGPULabel;
        private System.Windows.Forms.Panel HomeInfoPanel;
        private System.Windows.Forms.Label HomeFreeDiskLabel;
        private System.Windows.Forms.Label HomeInfoProcessorCounterLabel;
        private System.Diagnostics.PerformanceCounter CPU_perf;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel HomeGamesPanel;
        private System.Windows.Forms.Panel panelfakeborder;
        private System.Windows.Forms.Panel GamesPanel;
        private System.Windows.Forms.Panel SettingsPanel;
    }
}

