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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GamesPanel = new System.Windows.Forms.Panel();
            this.GamesGamesList = new System.Windows.Forms.Panel();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.SettingsComboBoxSort = new System.Windows.Forms.ComboBox();
            this.SettingsSortByLabel = new System.Windows.Forms.Label();
            this.SettingsPreviewLabel = new System.Windows.Forms.Label();
            this.SettingsFontColorPicker = new XanderUI.XUIColorPicker();
            this.SettingsGamesNoSwitch = new XanderUI.XUISwitch();
            this.SettingsGamesMaybeSwitch = new XanderUI.XUISwitch();
            this.SettingsGamesYesSwitch = new XanderUI.XUISwitch();
            this.SettingsDarkModeSwitch = new XanderUI.XUISwitch();
            this.SettingsGamesNoLabel = new System.Windows.Forms.Label();
            this.SettingsGameMaybeLabel = new System.Windows.Forms.Label();
            this.SettingsGamesYesLabel = new System.Windows.Forms.Label();
            this.SettingsForeColorLabel = new System.Windows.Forms.Label();
            this.SettingsDarkModeLabel = new System.Windows.Forms.Label();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.GamesPanelGamesCount = new PcGameChecker.PanelWithBorder();
            this.GamesLabelCount = new System.Windows.Forms.Label();
            this.SettingsScanComputerAgainButton = new PcGameChecker.RoundedButton();
            this.SettingsApplyButton = new PcGameChecker.RoundedButton();
            this.SettingsResetButton = new PcGameChecker.RoundedButton();
            this.minimizeButton1 = new PcGameChecker.MinimizeButton();
            this.closeButton1 = new PcGameChecker.CloseButton();
            this.LeftPanel = new PcGameChecker.PanelWithBorder();
            this.GamesButton = new PcGameChecker.PictureButton();
            this.HomeButton = new PcGameChecker.PictureButton();
            this.SettingsButton = new PcGameChecker.PictureButton();
            this.HomePanel.SuspendLayout();
            this.HomeGamesPanel.SuspendLayout();
            this.HomeInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeInfoPanelGPUIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeInfoPanelRAMIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeInfoPanelProcessorIcon)).BeginInit();
            this.GamesPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.GamesPanelGamesCount.SuspendLayout();
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
            this.HomeInfoPanel.BackgroundImage = global::PcGameChecker.Properties.Resources.HomeInfoBackground;
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
            this.HomeInfoPanel.Cursor = System.Windows.Forms.Cursors.Default;
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
            this.HomeInfoPanelGPUIcon.BackgroundImage = global::PcGameChecker.Properties.Resources.GPU;
            this.HomeInfoPanelGPUIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomeInfoPanelGPUIcon.Location = new System.Drawing.Point(540, 98);
            this.HomeInfoPanelGPUIcon.Name = "HomeInfoPanelGPUIcon";
            this.HomeInfoPanelGPUIcon.Size = new System.Drawing.Size(143, 100);
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
            this.HomeInfoPanelRAMIcon.BackgroundImage = global::PcGameChecker.Properties.Resources.RAM;
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
            this.HomeInfoPanelProcessorIcon.BackgroundImage = global::PcGameChecker.Properties.Resources.Processor;
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
            this.HomePanelInfoCMName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomePanelInfoCMName_MouseDown);
            this.HomePanelInfoCMName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomePanelInfoCMName_MouseMove);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GamesPanel
            // 
            this.GamesPanel.BackColor = System.Drawing.Color.Transparent;
            this.GamesPanel.Controls.Add(this.GamesGamesList);
            this.GamesPanel.Controls.Add(this.GamesPanelGamesCount);
            this.GamesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamesPanel.Location = new System.Drawing.Point(106, 0);
            this.GamesPanel.Name = "GamesPanel";
            this.GamesPanel.Size = new System.Drawing.Size(1214, 730);
            this.GamesPanel.TabIndex = 3;
            // 
            // GamesGamesList
            // 
            this.GamesGamesList.AutoScroll = true;
            this.GamesGamesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamesGamesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.GamesGamesList.Location = new System.Drawing.Point(0, 100);
            this.GamesGamesList.Name = "GamesGamesList";
            this.GamesGamesList.Size = new System.Drawing.Size(1214, 630);
            this.GamesGamesList.TabIndex = 1;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsPanel.Controls.Add(this.SettingsScanComputerAgainButton);
            this.SettingsPanel.Controls.Add(this.SettingsComboBoxSort);
            this.SettingsPanel.Controls.Add(this.SettingsSortByLabel);
            this.SettingsPanel.Controls.Add(this.SettingsApplyButton);
            this.SettingsPanel.Controls.Add(this.SettingsResetButton);
            this.SettingsPanel.Controls.Add(this.SettingsPreviewLabel);
            this.SettingsPanel.Controls.Add(this.SettingsFontColorPicker);
            this.SettingsPanel.Controls.Add(this.SettingsGamesNoSwitch);
            this.SettingsPanel.Controls.Add(this.SettingsGamesMaybeSwitch);
            this.SettingsPanel.Controls.Add(this.SettingsGamesYesSwitch);
            this.SettingsPanel.Controls.Add(this.SettingsDarkModeSwitch);
            this.SettingsPanel.Controls.Add(this.SettingsGamesNoLabel);
            this.SettingsPanel.Controls.Add(this.SettingsGameMaybeLabel);
            this.SettingsPanel.Controls.Add(this.SettingsGamesYesLabel);
            this.SettingsPanel.Controls.Add(this.SettingsForeColorLabel);
            this.SettingsPanel.Controls.Add(this.SettingsDarkModeLabel);
            this.SettingsPanel.Controls.Add(this.SettingsLabel);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsPanel.Location = new System.Drawing.Point(106, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(1214, 730);
            this.SettingsPanel.TabIndex = 4;
            // 
            // SettingsComboBoxSort
            // 
            this.SettingsComboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SettingsComboBoxSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsComboBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsComboBoxSort.FormattingEnabled = true;
            this.SettingsComboBoxSort.Items.AddRange(new object[] {
            "Index (Default)",
            "Name A - Z",
            "Name Z - A",
            "CYRI (From Yes to No)",
            "CYRI (From No to Yes)"});
            this.SettingsComboBoxSort.Location = new System.Drawing.Point(264, 466);
            this.SettingsComboBoxSort.Name = "SettingsComboBoxSort";
            this.SettingsComboBoxSort.Size = new System.Drawing.Size(252, 39);
            this.SettingsComboBoxSort.TabIndex = 0;
            this.SettingsComboBoxSort.TabStop = false;
            // 
            // SettingsSortByLabel
            // 
            this.SettingsSortByLabel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsSortByLabel.Font = new System.Drawing.Font("Comfortaa", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsSortByLabel.Location = new System.Drawing.Point(0, 466);
            this.SettingsSortByLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsSortByLabel.Name = "SettingsSortByLabel";
            this.SettingsSortByLabel.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.SettingsSortByLabel.Size = new System.Drawing.Size(261, 42);
            this.SettingsSortByLabel.TabIndex = 15;
            this.SettingsSortByLabel.Text = "Sort games by";
            // 
            // SettingsPreviewLabel
            // 
            this.SettingsPreviewLabel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsPreviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsPreviewLabel.Location = new System.Drawing.Point(309, 190);
            this.SettingsPreviewLabel.Name = "SettingsPreviewLabel";
            this.SettingsPreviewLabel.Size = new System.Drawing.Size(270, 50);
            this.SettingsPreviewLabel.TabIndex = 11;
            this.SettingsPreviewLabel.Text = "Preview text";
            this.SettingsPreviewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsFontColorPicker
            // 
            this.SettingsFontColorPicker.BackColor = System.Drawing.Color.White;
            this.SettingsFontColorPicker.Location = new System.Drawing.Point(203, 190);
            this.SettingsFontColorPicker.Name = "SettingsFontColorPicker";
            this.SettingsFontColorPicker.PickerImage = ((System.Drawing.Image)(resources.GetObject("SettingsFontColorPicker.PickerImage")));
            this.SettingsFontColorPicker.SelectedColor = System.Drawing.Color.Empty;
            this.SettingsFontColorPicker.ShowColorPreview = true;
            this.SettingsFontColorPicker.Size = new System.Drawing.Size(100, 100);
            this.SettingsFontColorPicker.TabIndex = 10;
            this.SettingsFontColorPicker.Text = "xuiColorPicker1";
            this.SettingsFontColorPicker.SelectedColorChanged += new System.EventHandler(this.SettingsFontColorPicker_SelectedColorChanged);
            // 
            // SettingsGamesNoSwitch
            // 
            this.SettingsGamesNoSwitch.BackColor = System.Drawing.Color.Transparent;
            this.SettingsGamesNoSwitch.HandleOffColor = System.Drawing.Color.White;
            this.SettingsGamesNoSwitch.HandleOnColor = System.Drawing.Color.White;
            this.SettingsGamesNoSwitch.Location = new System.Drawing.Point(560, 421);
            this.SettingsGamesNoSwitch.Name = "SettingsGamesNoSwitch";
            this.SettingsGamesNoSwitch.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.SettingsGamesNoSwitch.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.SettingsGamesNoSwitch.Size = new System.Drawing.Size(60, 30);
            this.SettingsGamesNoSwitch.SwitchState = XanderUI.XUISwitch.State.On;
            this.SettingsGamesNoSwitch.SwitchStyle = XanderUI.XUISwitch.Style.Horizontal;
            this.SettingsGamesNoSwitch.TabIndex = 9;
            this.SettingsGamesNoSwitch.Text = "xuiSwitch4";
            // 
            // SettingsGamesMaybeSwitch
            // 
            this.SettingsGamesMaybeSwitch.BackColor = System.Drawing.Color.Transparent;
            this.SettingsGamesMaybeSwitch.HandleOffColor = System.Drawing.Color.White;
            this.SettingsGamesMaybeSwitch.HandleOnColor = System.Drawing.Color.White;
            this.SettingsGamesMaybeSwitch.Location = new System.Drawing.Point(447, 372);
            this.SettingsGamesMaybeSwitch.Name = "SettingsGamesMaybeSwitch";
            this.SettingsGamesMaybeSwitch.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.SettingsGamesMaybeSwitch.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.SettingsGamesMaybeSwitch.Size = new System.Drawing.Size(60, 30);
            this.SettingsGamesMaybeSwitch.SwitchState = XanderUI.XUISwitch.State.On;
            this.SettingsGamesMaybeSwitch.SwitchStyle = XanderUI.XUISwitch.Style.Horizontal;
            this.SettingsGamesMaybeSwitch.TabIndex = 8;
            this.SettingsGamesMaybeSwitch.Text = "xuiSwitch3";
            // 
            // SettingsGamesYesSwitch
            // 
            this.SettingsGamesYesSwitch.BackColor = System.Drawing.Color.Transparent;
            this.SettingsGamesYesSwitch.HandleOffColor = System.Drawing.Color.White;
            this.SettingsGamesYesSwitch.HandleOnColor = System.Drawing.Color.White;
            this.SettingsGamesYesSwitch.Location = new System.Drawing.Point(375, 321);
            this.SettingsGamesYesSwitch.Name = "SettingsGamesYesSwitch";
            this.SettingsGamesYesSwitch.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.SettingsGamesYesSwitch.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.SettingsGamesYesSwitch.Size = new System.Drawing.Size(60, 30);
            this.SettingsGamesYesSwitch.SwitchState = XanderUI.XUISwitch.State.On;
            this.SettingsGamesYesSwitch.SwitchStyle = XanderUI.XUISwitch.Style.Horizontal;
            this.SettingsGamesYesSwitch.TabIndex = 7;
            // 
            // SettingsDarkModeSwitch
            // 
            this.SettingsDarkModeSwitch.BackColor = System.Drawing.Color.Transparent;
            this.SettingsDarkModeSwitch.HandleOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SettingsDarkModeSwitch.HandleOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SettingsDarkModeSwitch.Location = new System.Drawing.Point(203, 123);
            this.SettingsDarkModeSwitch.Name = "SettingsDarkModeSwitch";
            this.SettingsDarkModeSwitch.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.SettingsDarkModeSwitch.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.SettingsDarkModeSwitch.Size = new System.Drawing.Size(58, 30);
            this.SettingsDarkModeSwitch.SwitchState = XanderUI.XUISwitch.State.Off;
            this.SettingsDarkModeSwitch.SwitchStyle = XanderUI.XUISwitch.Style.Horizontal;
            this.SettingsDarkModeSwitch.TabIndex = 6;
            this.SettingsDarkModeSwitch.SwitchStateChanged += new System.EventHandler(this.SettingsDarkModeSwitch_SwitchStateChanged);
            // 
            // SettingsGamesNoLabel
            // 
            this.SettingsGamesNoLabel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsGamesNoLabel.Font = new System.Drawing.Font("Comfortaa", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsGamesNoLabel.Location = new System.Drawing.Point(0, 415);
            this.SettingsGamesNoLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsGamesNoLabel.Name = "SettingsGamesNoLabel";
            this.SettingsGamesNoLabel.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.SettingsGamesNoLabel.Size = new System.Drawing.Size(575, 42);
            this.SettingsGamesNoLabel.TabIndex = 5;
            this.SettingsGamesNoLabel.Text = "Show the games i don\'t want to cry about";
            // 
            // SettingsGameMaybeLabel
            // 
            this.SettingsGameMaybeLabel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsGameMaybeLabel.Font = new System.Drawing.Font("Comfortaa", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsGameMaybeLabel.Location = new System.Drawing.Point(0, 364);
            this.SettingsGameMaybeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsGameMaybeLabel.Name = "SettingsGameMaybeLabel";
            this.SettingsGameMaybeLabel.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.SettingsGameMaybeLabel.Size = new System.Drawing.Size(460, 42);
            this.SettingsGameMaybeLabel.TabIndex = 4;
            this.SettingsGameMaybeLabel.Text = "Show the games i can try to run";
            // 
            // SettingsGamesYesLabel
            // 
            this.SettingsGamesYesLabel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsGamesYesLabel.Font = new System.Drawing.Font("Comfortaa", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsGamesYesLabel.Location = new System.Drawing.Point(0, 313);
            this.SettingsGamesYesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsGamesYesLabel.Name = "SettingsGamesYesLabel";
            this.SettingsGamesYesLabel.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.SettingsGamesYesLabel.Size = new System.Drawing.Size(390, 42);
            this.SettingsGamesYesLabel.TabIndex = 3;
            this.SettingsGamesYesLabel.Text = "Show the games i can run";
            // 
            // SettingsForeColorLabel
            // 
            this.SettingsForeColorLabel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsForeColorLabel.Font = new System.Drawing.Font("Comfortaa", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsForeColorLabel.Location = new System.Drawing.Point(0, 157);
            this.SettingsForeColorLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsForeColorLabel.Name = "SettingsForeColorLabel";
            this.SettingsForeColorLabel.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.SettingsForeColorLabel.Size = new System.Drawing.Size(200, 156);
            this.SettingsForeColorLabel.TabIndex = 2;
            this.SettingsForeColorLabel.Text = "Font color";
            this.SettingsForeColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SettingsDarkModeLabel
            // 
            this.SettingsDarkModeLabel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsDarkModeLabel.Font = new System.Drawing.Font("Comfortaa", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsDarkModeLabel.Location = new System.Drawing.Point(0, 115);
            this.SettingsDarkModeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsDarkModeLabel.Name = "SettingsDarkModeLabel";
            this.SettingsDarkModeLabel.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.SettingsDarkModeLabel.Size = new System.Drawing.Size(200, 42);
            this.SettingsDarkModeLabel.TabIndex = 1;
            this.SettingsDarkModeLabel.Text = "Dark mode";
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsLabel.Location = new System.Drawing.Point(0, 0);
            this.SettingsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(1214, 115);
            this.SettingsLabel.TabIndex = 0;
            this.SettingsLabel.Text = "Settings";
            this.SettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SettingsLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomePanelInfoCMName_MouseDown);
            this.SettingsLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomePanelInfoCMName_MouseMove);
            // 
            // GamesPanelGamesCount
            // 
            this.GamesPanelGamesCount.BackgroundColor = System.Drawing.Color.White;
            this.GamesPanelGamesCount.BorderBottom = true;
            this.GamesPanelGamesCount.BorderColor = System.Drawing.Color.Black;
            this.GamesPanelGamesCount.BorderLeft = false;
            this.GamesPanelGamesCount.BorderRight = false;
            this.GamesPanelGamesCount.BorderTop = false;
            this.GamesPanelGamesCount.BorderWidth = 6;
            this.GamesPanelGamesCount.Controls.Add(this.GamesLabelCount);
            this.GamesPanelGamesCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.GamesPanelGamesCount.Location = new System.Drawing.Point(0, 0);
            this.GamesPanelGamesCount.Name = "GamesPanelGamesCount";
            this.GamesPanelGamesCount.Size = new System.Drawing.Size(1214, 100);
            this.GamesPanelGamesCount.TabIndex = 0;
            // 
            // GamesLabelCount
            // 
            this.GamesLabelCount.BackColor = System.Drawing.Color.Transparent;
            this.GamesLabelCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamesLabelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GamesLabelCount.Location = new System.Drawing.Point(0, 0);
            this.GamesLabelCount.Name = "GamesLabelCount";
            this.GamesLabelCount.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.GamesLabelCount.Size = new System.Drawing.Size(1214, 100);
            this.GamesLabelCount.TabIndex = 0;
            this.GamesLabelCount.Text = "Games in database : 7 ... and this number constantly grows.";
            this.GamesLabelCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GamesLabelCount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomePanelInfoCMName_MouseDown);
            this.GamesLabelCount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomePanelInfoCMName_MouseMove);
            // 
            // SettingsScanComputerAgainButton
            // 
            this.SettingsScanComputerAgainButton.BackColor = System.Drawing.Color.White;
            this.SettingsScanComputerAgainButton.BorderColor = System.Drawing.Color.Black;
            this.SettingsScanComputerAgainButton.BorderWidth = 4;
            this.SettingsScanComputerAgainButton.ButtonColor = System.Drawing.Color.White;
            this.SettingsScanComputerAgainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsScanComputerAgainButton.Font = new System.Drawing.Font("Comfortaa", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsScanComputerAgainButton.FontColor = System.Drawing.Color.Black;
            this.SettingsScanComputerAgainButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.SettingsScanComputerAgainButton.HoverButtonColor = System.Drawing.Color.White;
            this.SettingsScanComputerAgainButton.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.SettingsScanComputerAgainButton.Location = new System.Drawing.Point(50, 658);
            this.SettingsScanComputerAgainButton.Name = "SettingsScanComputerAgainButton";
            this.SettingsScanComputerAgainButton.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.SettingsScanComputerAgainButton.Rounding = 30F;
            this.SettingsScanComputerAgainButton.Size = new System.Drawing.Size(290, 60);
            this.SettingsScanComputerAgainButton.TabIndex = 16;
            this.SettingsScanComputerAgainButton.Text = "Scan PC again";
            this.SettingsScanComputerAgainButton.Click += new System.EventHandler(this.SettingsScanComputerAgainButton_Click);
            // 
            // SettingsApplyButton
            // 
            this.SettingsApplyButton.BackColor = System.Drawing.Color.White;
            this.SettingsApplyButton.BorderColor = System.Drawing.Color.Black;
            this.SettingsApplyButton.BorderWidth = 3;
            this.SettingsApplyButton.ButtonColor = System.Drawing.Color.White;
            this.SettingsApplyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsApplyButton.Font = new System.Drawing.Font("Comfortaa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsApplyButton.FontColor = System.Drawing.Color.Black;
            this.SettingsApplyButton.ForeColor = System.Drawing.Color.Transparent;
            this.SettingsApplyButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(117)))));
            this.SettingsApplyButton.HoverButtonColor = System.Drawing.Color.White;
            this.SettingsApplyButton.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(117)))));
            this.SettingsApplyButton.Location = new System.Drawing.Point(309, 250);
            this.SettingsApplyButton.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsApplyButton.Name = "SettingsApplyButton";
            this.SettingsApplyButton.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.SettingsApplyButton.Rounding = 40F;
            this.SettingsApplyButton.Size = new System.Drawing.Size(135, 40);
            this.SettingsApplyButton.TabIndex = 14;
            this.SettingsApplyButton.Text = "Apply";
            this.SettingsApplyButton.Click += new System.EventHandler(this.SettingsApplyButton_Click);
            // 
            // SettingsResetButton
            // 
            this.SettingsResetButton.BackColor = System.Drawing.Color.White;
            this.SettingsResetButton.BorderColor = System.Drawing.Color.Black;
            this.SettingsResetButton.BorderWidth = 3;
            this.SettingsResetButton.ButtonColor = System.Drawing.Color.White;
            this.SettingsResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsResetButton.Font = new System.Drawing.Font("Comfortaa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsResetButton.FontColor = System.Drawing.Color.Black;
            this.SettingsResetButton.ForeColor = System.Drawing.Color.Transparent;
            this.SettingsResetButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.SettingsResetButton.HoverButtonColor = System.Drawing.Color.White;
            this.SettingsResetButton.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.SettingsResetButton.Location = new System.Drawing.Point(444, 250);
            this.SettingsResetButton.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsResetButton.Name = "SettingsResetButton";
            this.SettingsResetButton.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.SettingsResetButton.Rounding = 40F;
            this.SettingsResetButton.Size = new System.Drawing.Size(135, 40);
            this.SettingsResetButton.TabIndex = 13;
            this.SettingsResetButton.Text = "Reset";
            this.SettingsResetButton.Click += new System.EventHandler(this.SettingsResetButton_Click);
            // 
            // minimizeButton1
            // 
            this.minimizeButton1.Buttoncolor = System.Drawing.Color.Transparent;
            this.minimizeButton1.ButtonHoverColor = System.Drawing.Color.Silver;
            this.minimizeButton1.icon = global::PcGameChecker.Properties.Resources.minimize;
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
            this.closeButton1.icon = global::PcGameChecker.Properties.Resources.close;
            this.closeButton1.icon2 = global::PcGameChecker.Properties.Resources.close2;
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
            this.GamesButton.Picture1 = global::PcGameChecker.Properties.Resources.games;
            this.GamesButton.Picture2 = global::PcGameChecker.Properties.Resources.games2;
            this.GamesButton.Size = new System.Drawing.Size(80, 80);
            this.GamesButton.TabIndex = 2;
            this.GamesButton.Click += new System.EventHandler(this.GamesButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.Location = new System.Drawing.Point(10, 12);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Picture1 = global::PcGameChecker.Properties.Resources.Home;
            this.HomeButton.Picture2 = global::PcGameChecker.Properties.Resources.Home2;
            this.HomeButton.Size = new System.Drawing.Size(80, 80);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.Location = new System.Drawing.Point(10, 638);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Picture1 = global::PcGameChecker.Properties.Resources.settings;
            this.SettingsButton.Picture2 = global::PcGameChecker.Properties.Resources.settings2;
            this.SettingsButton.Size = new System.Drawing.Size(80, 80);
            this.SettingsButton.TabIndex = 0;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
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
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.HomePanel.ResumeLayout(false);
            this.HomeGamesPanel.ResumeLayout(false);
            this.HomeInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeInfoPanelGPUIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeInfoPanelRAMIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeInfoPanelProcessorIcon)).EndInit();
            this.GamesPanel.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.GamesPanelGamesCount.ResumeLayout(false);
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
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Panel HomeGamesPanel;
		private System.Windows.Forms.Panel panelfakeborder;
		private System.Windows.Forms.Panel GamesPanel;
		private System.Windows.Forms.Panel SettingsPanel;
		private PanelWithBorder GamesPanelGamesCount;
		private System.Windows.Forms.Label GamesLabelCount;
		private System.Windows.Forms.Label SettingsLabel;
		private XanderUI.XUISwitch SettingsGamesNoSwitch;
		private XanderUI.XUISwitch SettingsGamesMaybeSwitch;
		private XanderUI.XUISwitch SettingsGamesYesSwitch;
		private XanderUI.XUISwitch SettingsDarkModeSwitch;
		private System.Windows.Forms.Label SettingsGamesNoLabel;
		private System.Windows.Forms.Label SettingsGameMaybeLabel;
		private System.Windows.Forms.Label SettingsGamesYesLabel;
		private System.Windows.Forms.Label SettingsForeColorLabel;
		private System.Windows.Forms.Label SettingsDarkModeLabel;
		private System.Windows.Forms.Label SettingsPreviewLabel;
		private XanderUI.XUIColorPicker SettingsFontColorPicker;
		private RoundedButton SettingsApplyButton;
		private RoundedButton SettingsResetButton;
		private System.Windows.Forms.Panel GamesGamesList;
		private System.Windows.Forms.Label SettingsSortByLabel;
		private System.Windows.Forms.ComboBox SettingsComboBoxSort;
		private RoundedButton SettingsScanComputerAgainButton;
    }
}

