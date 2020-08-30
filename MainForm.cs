using PcGameChecker.Animation;
using PcGameChecker.GraphExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker
{
	public partial class MainForm : Form
	{
		private int MinimalLeftPanelWidemodeWidth = 0;
		public MainForm()
		{
			DoubleBuffered = true;
			SetStyle(ControlStyles.ResizeRedraw, true);
			SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			InitializeComponent();
			Program.screenMode = ScreenMode.Normal;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			LeftPanelMainButton.IsSelected = true;
			MainPagePanel.BringToFront();
			foreach (LeftPanelButton lpb in LeftPanel.Controls)
            {
				lpb.Font = new Font(Program.Comfortaa.Families[0], 65, GraphicsUnit.Pixel);
            }
			mainPanelHardwareInfo1.Font = new Font(Program.Comfortaa.Families[0], 60, GraphicsUnit.Pixel);
			mainPanelHardwareInfo1.HardwareFont = new Font(Program.Comfortaa.Families[0], 24, GraphicsUnit.Pixel);
		}

		private void MainForm_Shown(object sender, EventArgs e)
		{
			//MessageBox.Show(Math.Log(4, 200).ToString());
		}

		private void GetMinimalLeftPanelButtonWidth()
		{
			foreach (LeftPanelButton lpb in LeftPanel.Controls)
			{
				if (MinimalLeftPanelWidemodeWidth < lpb.MinimalIconTextwidth) MinimalLeftPanelWidemodeWidth = lpb.MinimalIconTextwidth;
			}
		}

		private void MainForm_Resize(object sender, EventArgs e)
		{
			if (MinimalLeftPanelWidemodeWidth == 0)	GetMinimalLeftPanelButtonWidth();

			if (this.Width > 1580)
			{
				LeftPanel.MinimumSize = new Size(MinimalLeftPanelWidemodeWidth, 0);
				LeftPanel.Width = (this.Width * 20) / 100;
			}
			else
			{
				LeftPanel.MinimumSize = new Size(100, 0);
				LeftPanel.Width = (this.Width * 10) / 100;
			}
		}

		private void LeftPanelMainButton_Click(object sender, EventArgs e)
		{
			LeftPanelMainButton.IsSelected = true;
			LeftPanelGamesButton.IsSelected = false;
			LeftPanelSettingsButton.IsSelected = false;

			MainPagePanel.BringToFront();

			LeftPanelGamesButton.Invalidate();
			LeftPanelSettingsButton.Invalidate();
		}

		private void LeftPanelGamesButton_Click(object sender, EventArgs e)
		{
			LeftPanelMainButton.IsSelected = false;
			LeftPanelGamesButton.IsSelected = true;
			LeftPanelSettingsButton.IsSelected = false;

			//GamesPagePanel.BringToFront();

			LeftPanelMainButton.Invalidate();
			LeftPanelSettingsButton.Invalidate();
		}

		private void LeftPanelSettingsButton_Click(object sender, EventArgs e)
		{
			LeftPanelMainButton.IsSelected = false;
			LeftPanelGamesButton.IsSelected = false;
			LeftPanelSettingsButton.IsSelected = true;

			//SettingsPagePanel.BringToFront();

			LeftPanelMainButton.Invalidate();
			LeftPanelGamesButton.Invalidate();
		}

	}
}