using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcGameChecker;
using TPcGameChecker;

namespace PcGameChecker
{
	public partial class FormMain : Form
	{
		private System.Diagnostics.PerformanceCounter CPU_perf = new PerformanceCounter();
		private int driveleftmargin = 230;
		private int gametopmargin = 92;
		int gamescount = Program.GamesList.Count();
		Point lastPoint;
		public FormMain()
		{
			InitializeComponent();
			CPU_perf.CategoryName = "Processor";
			CPU_perf.CounterName = "% Processor time";
			CPU_perf.InstanceName = "_Total";
			try	{
				((System.ComponentModel.ISupportInitialize)(this.CPU_perf)).BeginInit();
				((System.ComponentModel.ISupportInitialize)(CPU_perf)).EndInit();
			}
			catch {
				HomeInfoProcessorCounterLabel.Text = "error";
				Program.cpuPerf = false;
			}
		}
		private void GetDiskspaces()
		{
			Label fds = new Label();
			fds.Text = "Free disk space :";
			fds.Padding = new Padding(0, 2, 0, 3);
			fds.Size = new Size(230, 72);
			fds.TextAlign = ContentAlignment.MiddleCenter;
			fds.Location = new Point(0, 0);
			fds.Font = new Font(Program.Comfortaa.Families[0], 13.8F);
			HomeGamesPanel.Controls.Add(fds);
			double a;
			DriveInfo[] allDrives = DriveInfo.GetDrives();
			foreach (DriveInfo MyDriveInfo in allDrives)
			{
				if (MyDriveInfo.IsReady == true)
				{
					a = (MyDriveInfo.AvailableFreeSpace / 1024) / 1024 / 1024;
					HardDriveInfo h = new HardDriveInfo(MyDriveInfo.Name, a.ToString("#.##") + " GB", SettingsDarkModeSwitch.SwitchState == XanderUI.XUISwitch.State.On);
					h.Location = new Point(driveleftmargin, 8);
					h.Font = new Font(Program.Comfortaa.Families[0], HomeFreeDiskLabel.Font.Size);
					h.BackColor = Color.White;
					HomeGamesPanel.Controls.Add(h);
					driveleftmargin += 190;
				}
			}
		}
		private void SortBySelectedMethod()
		{
			if (SettingsComboBoxSort.SelectedIndex == 0) // sort by indexes
			{
				DeserializeGames(Program.GamesList);
			}
			else if (SettingsComboBoxSort.SelectedIndex == 1) // sort a-z
			{
				List<Game> Sorted = Program.GamesList.OrderBy(o => o.Name).ToList();
				DeserializeGames(Sorted);
				Sorted.Clear();
			}
			else if (SettingsComboBoxSort.SelectedIndex == 2) //sort z-a
			{
				List<Game> Sorted = Program.GamesList.OrderBy(o => o.Name).ToList();
				Sorted.Reverse();
				DeserializeGames(Sorted);
				Sorted.Clear();
			}
			else if (SettingsComboBoxSort.SelectedIndex == 3) // sort yes-no
			{
				List<Game> Sorted = Program.GamesList.OrderBy(o => o.Name).ToList();
				List<Game> Sorted2 = new List<Game>();
				foreach (Game g in Sorted) { // add every Yes
					if (g.CanYouRunItColor == Color.FromArgb(36, 173, 117))	{
						Sorted2.Add(g);
					}
				}
				foreach (Game g in Sorted) { // add every maybe
					if (g.CanYouRunItColor == Color.FromArgb(231, 178, 52))	{
						Sorted2.Add(g);
					}
				}
				foreach (Game g in Sorted) { // add every no
					if (g.CanYouRunItColor == Color.FromArgb(203, 51, 51)) {
						Sorted2.Add(g);
					}
				}
				DeserializeGames(Sorted2);
				Sorted.Clear();
				Sorted2.Clear();
			}
			else if (SettingsComboBoxSort.SelectedIndex == 4) // sort no-yes
			{
				List<Game> Sorted = Program.GamesList.OrderBy(o => o.Name).ToList();
				Sorted.Reverse();
				List<Game> Sorted2 = new List<Game>();
				foreach (Game g in Sorted) { // add every no
					if (g.CanYouRunItColor == Color.FromArgb(203, 51, 51)) {
						Sorted2.Add(g);
					}
				}
				foreach (Game g in Sorted) { // add every maybe
					if (g.CanYouRunItColor == Color.FromArgb(231, 178, 52))	{
						Sorted2.Add(g);
					}
				}
				foreach (Game g in Sorted) { // add every Yes
					if (g.CanYouRunItColor == Color.FromArgb(36, 173, 117))	{
						Sorted2.Add(g);
					}
				}
				DeserializeGames(Sorted2);
				Sorted.Clear();
				Sorted2.Clear();
			}
		}
		private void DeserializeGames(List<Game> SelectedList)
		{
			foreach (Game game in SelectedList)
			{
				if (game.CanYouRunItColor == Color.FromArgb(36, 173, 117) && SettingsGamesYesSwitch.SwitchState == XanderUI.XUISwitch.State.On)
				{
					GameBlockHorizontal gbh = new GameBlockHorizontal(game, game.CanYouRunItColor, Program.GamesList.IndexOf(game));
					gbh.Location = new Point(57, gametopmargin);
					HomeGamesPanel.Controls.Add(gbh);
					gametopmargin += 85;
				}
				if (game.CanYouRunItColor == Color.FromArgb(231, 178, 52) && SettingsGamesMaybeSwitch.SwitchState == XanderUI.XUISwitch.State.On)
				{
					GameBlockHorizontal gbh = new GameBlockHorizontal(game, game.CanYouRunItColor, Program.GamesList.IndexOf(game));
					gbh.Location = new Point(57, gametopmargin);
					HomeGamesPanel.Controls.Add(gbh);
					gametopmargin += 85;
				}
				if (game.CanYouRunItColor == Color.FromArgb(203, 51, 51) && SettingsGamesNoSwitch.SwitchState == XanderUI.XUISwitch.State.On)
				{
					GameBlockHorizontal gbh = new GameBlockHorizontal(game, game.CanYouRunItColor, Program.GamesList.IndexOf(game));
					gbh.Location = new Point(57, gametopmargin);
					HomeGamesPanel.Controls.Add(gbh);
					gametopmargin += 85;
				}
			}
		}
		private void CreateGamesList()
		{
			int marginleft = 12;
			int margintop = 6;
			Color c;
			Color body;
			if (SettingsDarkModeSwitch.SwitchState == XanderUI.XUISwitch.State.On) {
				body = Color.FromArgb(225, 225, 225);
				GamesGamesList.BackColor = Color.FromArgb(40, 40, 40);
			}
			else {
				body = Color.White;
				GamesGamesList.BackColor = Color.White;
			}
			foreach (Game game in Program.GamesList)
			{
				c = SetCYRIColor(game);
				GameBlockVertical gbv = new GameBlockVertical(game, c, body, Program.GamesList.IndexOf(game));
				if (marginleft > GamesGamesList.Width - 270) {
					marginleft = 12;
					margintop += 450;
				}
				gbv.Location = new Point(marginleft, margintop);
				gbv.Cursor = Cursors.Hand;
				GamesGamesList.Controls.Add(gbv);
				marginleft += 298;
			}
		}
		private void DisableButtons()
		{
			SettingsButton.IsActive = false;
			HomeButton.IsActive = false;
			GamesButton.IsActive = false;
			SettingsButton.Invalidate();
			HomeButton.Invalidate();
			GamesButton.Invalidate();
			minimizeButton1.BringToFront();
			closeButton1.BringToFront();
		}
		private void FormMain_Load(object sender, EventArgs e)
		{
			HomePanelInfoCMName.Font = new Font(Program.Comfortaa.Families[0], HomePanelInfoCMName.Font.Size);
			HomePanelInfoCMName.Text = Program.ThisPC.SystemName;
			HomeInfoPanelGPULabel.Font = new Font(Program.Comfortaa.Families[0], HomeInfoPanelGPULabel.Font.Size);
			HomeInfoPanelGPULabel.Text = Program.ThisPC.GraphicsCard.Name + " VRAM : " + Program.ThisPC.GraphicsCard.Vram + " MB";
			HomeInfoPanelProcessorLabel.Font = new Font(Program.Comfortaa.Families[0], HomeInfoPanelProcessorLabel.Font.Size);
			HomeInfoPanelProcessorLabel.Text = Program.ThisPC.Processor.Name;
			HomeInfoPanelRAMLabel.Font = new Font(Program.Comfortaa.Families[0], HomeInfoPanelRAMLabel.Font.Size);
			HomeInfoPanelRAMLabel.Text = "RAM capacity: " + Program.ThisPC.RamCapacity.ToString() + " MB";
			HomeFreeDiskLabel.Font = new Font(Program.Comfortaa.Families[0], HomeFreeDiskLabel.Font.Size);
			HomeInfoProcessorCounterLabel.Font = new Font(Program.Comfortaa.Families[0], HomeInfoProcessorCounterLabel.Font.Size);
			HomeGamesPanel.Font = new Font(Program.Comfortaa.Families[0], HomeGamesPanel.Font.Size);

			GamesLabelCount.Font = new Font(Program.Comfortaa.Families[0], GamesLabelCount.Font.Size);
			GamesGamesList.Font = new Font(Program.Comfortaa.Families[0], GamesGamesList.Font.Size);
			SettingsComboBoxSort.Font = new Font(Program.Comfortaa.Families[0], SettingsComboBoxSort.Font.Size);
			SettingsScanComputerAgainButton.Font = new Font(Program.Comfortaa.Families[0], SettingsScanComputerAgainButton.Font.Size);
			SettingsComboBoxSort.SelectedIndex = 0;

			SettingsLabel.Font = new Font(Program.Comfortaa.Families[0], SettingsLabel.Font.Size);
			SettingsDarkModeLabel.Font = new Font(Program.Comfortaa.Families[0], SettingsDarkModeLabel.Font.Size);
			SettingsGamesYesLabel.Font = new Font(Program.Comfortaa.Families[0], SettingsGamesYesLabel.Font.Size);
			SettingsGameMaybeLabel.Font = new Font(Program.Comfortaa.Families[0], SettingsGameMaybeLabel.Font.Size);
			SettingsGamesNoLabel.Font = new Font(Program.Comfortaa.Families[0], SettingsGamesNoLabel.Font.Size);
			SettingsPreviewLabel.Font = new Font(Program.Comfortaa.Families[0], SettingsPreviewLabel.Font.Size);
			SettingsGamesYesSwitch.Location = new Point(SettingsGamesYesLabel.Location.X + SettingsGamesYesLabel.Width, SettingsGamesYesSwitch.Location.Y);
			SettingsGamesMaybeSwitch.Location = new Point(SettingsGameMaybeLabel.Location.X + SettingsGameMaybeLabel.Width, SettingsGamesMaybeSwitch.Location.Y);
			SettingsGamesNoSwitch.Location = new Point(SettingsGamesNoLabel.Location.X + SettingsGamesNoLabel.Width, SettingsGamesNoSwitch.Location.Y);
			SettingsApplyButton.Font = new Font(Program.Comfortaa.Families[0], SettingsApplyButton.Font.Size);
			SettingsResetButton.Font = new Font(Program.Comfortaa.Families[0], SettingsResetButton.Font.Size);
		}
		private void FormMain_Shown(object sender, EventArgs e)
		{
			foreach (Game game in Program.GamesList)
			{
				game.CanYouRunItColor = SetCYRIColor(game);
			}
			HomeButton_Click(sender, e);
		}

		private void closeButton1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void minimizeButton1_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void SettingsButton_Click(object sender, EventArgs e)
		{
			if (SettingsButton.IsActive != true) {
				GamesGamesList.Controls.Clear();
				SettingsPanel.BringToFront();
				HomeGamesPanel.Controls.Clear();
				DisableButtons();
				SettingsButton.IsActive = true;
				Invalidate();
			}
		}
		private void HomeButton_Click(object sender, EventArgs e)
		{
			if (HomeButton.IsActive != true) {
				GamesGamesList.Controls.Clear();
				HomePanel.BringToFront();
				DisableButtons();
				HomeButton.IsActive = true;
				driveleftmargin = 230;
				gametopmargin = 92;
				SortBySelectedMethod();
				GetDiskspaces();
				Invalidate();
			}
		}
		private void GamesButton_Click(object sender, EventArgs e)
		{
			if (GamesButton.IsActive != true) {
				GamesLabelCount.Text = "Games database: " + gamescount + " ... and this number constantly grows.";
				HomeGamesPanel.Controls.Clear();
				GamesPanel.BringToFront();
				CreateGamesList();
				DisableButtons();
				GamesButton.IsActive = true;
				Invalidate();
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (Program.cpuPerf) {
				float pcpu = CPU_perf.NextValue();
				HomeInfoProcessorCounterLabel.Text = string.Format("{0:0.0}%", pcpu);
			}
			else {
				timer1.Enabled = false;
			}
		}

		private void SettingsDarkModeSwitch_SwitchStateChanged(object sender, EventArgs e)
		{
			if (SettingsDarkModeSwitch.SwitchState == XanderUI.XUISwitch.State.On)
			{
				LeftPanel.BackgroundColor = Color.FromArgb(40, 40, 40);
				LeftPanel.Invalidate();
				SettingsButton.BackColor = Color.FromArgb(40, 40, 40);
				HomeButton.BackColor = Color.FromArgb(40, 40, 40);
				GamesButton.BackColor = Color.FromArgb(40, 40, 40);
				SettingsFontColorPicker.BackColor = Color.FromArgb(40, 40, 40);
				SettingsApplyButton.BackColor = Color.FromArgb(40, 40, 40);
				SettingsResetButton.BackColor = Color.FromArgb(40, 40, 40);
				SettingsScanComputerAgainButton.BackColor = Color.FromArgb(40, 40, 40);
				GamesPanelGamesCount.BackgroundColor = Color.FromArgb(40, 40, 40);
				BackColor = Color.FromArgb(40, 40, 40);
				ForeColor = Color.FromArgb(225, 225, 225);
			}
			else
			{
				LeftPanel.BackgroundColor = Color.White;
				LeftPanel.Invalidate();
				SettingsButton.BackColor = Color.White;
				HomeButton.BackColor = Color.White;
				GamesButton.BackColor = Color.White;
				SettingsFontColorPicker.BackColor = Color.White;
				SettingsApplyButton.BackColor = Color.White;
				SettingsResetButton.BackColor = Color.White;
				SettingsScanComputerAgainButton.BackColor = Color.White;
				GamesPanelGamesCount.BackgroundColor = Color.White;
				BackColor = Color.White;
				ForeColor = Color.Black;
			}
		}

		private void SettingsFontColorPicker_SelectedColorChanged(object sender, EventArgs e)
		{
			SettingsPreviewLabel.ForeColor = SettingsFontColorPicker.SelectedColor;
		}

		private void SettingsApplyButton_Click(object sender, EventArgs e)
		{
			this.ForeColor = SettingsPreviewLabel.ForeColor;
		}

		private void SettingsResetButton_Click(object sender, EventArgs e)
		{
			if (SettingsDarkModeSwitch.SwitchState == XanderUI.XUISwitch.State.On)
			{
				this.ForeColor = Color.FromArgb(225, 225, 225);
				SettingsFontColorPicker.SelectedColor = Color.FromArgb(225, 225, 225);
				SettingsPreviewLabel.ForeColor = Color.FromArgb(225, 225, 225);
			}
			else
			{
				this.ForeColor = Color.Black;
				SettingsFontColorPicker.SelectedColor = Color.Black;
				SettingsPreviewLabel.ForeColor = Color.Black;
			}
		}

		private void SettingsScanComputerAgainButton_Click(object sender, EventArgs e)
		{
			AgreementForm scanagain = new AgreementForm("Are you sure, that you want ro recsan your PC? In case of insuccess previous state could not be restored. If you want to backup your scan please, copy currentmachine.dat into another folder.");
			if(scanagain.ShowDialog() == DialogResult.OK) {
				ScanForm scan = new ScanForm();
				scan.Show();
				WindowState = FormWindowState.Minimized;
				scan.FormClosed += Scan_FormClosed;
			}
		}

		private void Scan_FormClosed(object sender, FormClosedEventArgs e)
		{
			WindowState = FormWindowState.Normal;
			HomeButton_Click(sender, e);
		}

		private void HomePanelInfoCMName_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		private void HomePanelInfoCMName_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private Color SetCYRIColor(Game G)
		{
			//1 - Yes // 2 - Maybe // 3 - No
			int IsOsOkay = 3; // There is no "Maybe" condition
			int IsRamOkay = 3;
			int IsProcessorOkay = 3;
			int IsGPUOkay = 3;
			Color result = Color.Empty;
			#region Operation system check
			string[] Osses = new string[10] { "Windows 10", "Windows 8.1", "Windows 8", "Windows 7", "Windows Vista", "Windows XP", "Windows ME", "Windows 2000", "Windows 98", "Windows 95" };
			for (int i = 0; i < 10; i++) {
				if (G.Req_OS == Osses[i]) {
					for(int j = 0; j < 10; j++) {
						if (Program.ThisPC.SystemOS == Osses[j]) {
							if (j <= i)	{
								//good
								if (G.Req_OS_Architecture.Contains("64")) {
									if (Program.ThisPC.SystemArchitecture  == 64) {
										// good
										IsOsOkay = 1;
									}
									else {
										// bad, set to NO
										IsOsOkay = 3;
										//return Color.FromArgb(203, 51, 51);
									}
								}
								else if (G.Req_OS_Architecture.Contains("32"))	{
									// good in any case
									IsOsOkay = 1;
								}
							}
							else {
								// set to NO
								IsOsOkay = 3;
								//return Color.FromArgb(203, 51, 51);
							}
						}
					}
				}
			}
			#endregion
			#region RAM check
			//if sysram >= gameram + 25% - Yes
			//if sysram == gameram - Maybe
			//if sysram < gameram - 25% - No
			if (Program.ThisPC.RamCapacity >= G.Min_RAM) {
				IsRamOkay = 1;
			}
			else if (Math.Abs(Program.ThisPC.RamCapacity - G.Min_RAM) < 256) {
				IsRamOkay = 2;
			}
			else if (Program.ThisPC.RamCapacity < G.Min_RAM) {
				IsRamOkay = 3; //this is bad, but another hardware can be more powerful
			}
			#endregion
			#region Processor check
			if (Program.ThisPC.Processor.NumberOfCores >= G.Min_Processor_Cores) {
				if (Program.ThisPC.Processor.ThreadCount >= G.Min_Processor_Threads) {
					// good
					if (Program.ThisPC.Processor.MaxClockSpeed >= G.Min_Processor_Clock) {
						// very good
						IsProcessorOkay = 1;
					}
					else {
						// bad, set to maybe because sometimes processor clock is badly detected
						if (Program.ThisPC.Processor.NumberOfCores >= G.Min_Processor_Cores * 2 && Program.ThisPC.Processor.ThreadCount >= G.Min_Processor_Threads * 2) {
							IsProcessorOkay = 1;
						}
						else if (Math.Abs(Convert.ToInt32(Program.ThisPC.Processor.MaxClockSpeed) - Convert.ToInt32(G.Min_Processor_Clock)) <= 800){
							IsProcessorOkay = 1;
						}
						else IsProcessorOkay = 2;
					}
				}
				else {
					if (Program.ThisPC.Processor.MaxClockSpeed >= G.Min_Processor_Clock) {
						//very good
						IsProcessorOkay = 2;
					}
					else {
						//bad, not enough threads and frequency can cause freezes
						IsProcessorOkay = 3;
					}
				}
			}
			else {
				//very bad
				IsProcessorOkay = 3;
			}
			#endregion
			#region GPU check
			uint MinimalResolutionСoefficient = 1280 * 720;
			//uint RecommendedResolutionCoefficient = 1920 * 1080;
			if (Program.ThisPC.GraphicsCard.Vram >= G.Min_Graphics_VRAM)
			{
				// good
				if (Program.ThisPC.GraphicsCard.MaxClockFrequency>= G.Min_Graphics_Gpu_Clock)
				{
					//very good
					// if you don't have big enough Vram your screen resolution can lower game performance
					uint MachineResolutionCoefficient = Program.ThisPC.GraphicsCard.CurrentHorizontalResolution * Program.ThisPC.GraphicsCard.CurrentVerticalResolution;
					double coefficient = Convert.ToDouble(MachineResolutionCoefficient / MinimalResolutionСoefficient); // (1920 * 1080) / (1280 * 720) = 2.25
					if (Program.ThisPC.GraphicsCard.Vram >= Convert.ToDouble(G.Min_Graphics_VRAM) * coefficient) {
						// super
						IsGPUOkay = 1;
					}
					else {
						//there should be a warnig about too high screen resolution
						IsGPUOkay = 2;
					}
				}
				else
				{
					IsGPUOkay = 2;
				}
			}
			else {
				IsGPUOkay = 3;  // no reason to compare another characteristics
			}
			#endregion
			//MessageBox.Show(G.Name + '\n' + IsOsOkay.ToString() + '\n' + IsRamOkay.ToString() + '\n' + IsProcessorOkay.ToString() + '\n' + IsGPUOkay.ToString());
			//MessageBox.Show("Processor : " + Program.ThisPC.Processor.MaxClockSpeed.ToString() + " vs Game : " + G.Min_Processor_Clock.ToString());
			if (IsOsOkay == 1) {
				if (IsRamOkay <= 2)	{
					if (IsProcessorOkay == 1 && IsGPUOkay == 1)	{
						return Color.FromArgb(36, 173, 117); // Yes
					}
					else if ((IsProcessorOkay == 2 || IsGPUOkay == 2) && (IsProcessorOkay != 3 && IsGPUOkay != 3)) {
						return Color.FromArgb(231, 178, 52); // Maybe
					}
					else if (IsProcessorOkay == 3 || IsGPUOkay == 3) {
						return Color.FromArgb(203, 51, 51); // No
					}
				}
				else {
					return Color.FromArgb(203, 51, 51); // No
				}
			}
			else if (IsOsOkay == 3)	{
				return Color.FromArgb(203, 51, 51); // No
			}
			return Color.FromArgb(231, 178, 52); // Maybe
		}
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == (Keys.Control | Keys.Shift | Keys.A))
			{
				MessageBox.Show("Аня, я тебя люблю!");
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}
	}
}