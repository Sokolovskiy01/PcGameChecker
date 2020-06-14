using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker
{
	public partial class GameInfoForm : Form
	{
		Point lastPoint;
		public GameInfoForm()
		{
			InitializeComponent();
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
			this.DoubleBuffered = true;
		}
		public GameInfoForm(Game game, Color bordercolor)
		{
			InitializeComponent();
			GameNameLabel.Text = game.Name;
			GamePicture.BackgroundImage = game.Poster;
			YearLabelA.Text = game.Year.ToString();
			GenreLabelA.Text = game.Genre;
			MetacriticsLabelA.Text = game.metacritic.ToString();
			if (game.metacritic >= 75) MetacriticsLabelA.ForeColor = Color.FromArgb(36, 173, 117);
			else if (game.metacritic >= 50 && game.metacritic < 75) MetacriticsLabelA.ForeColor = Color.FromArgb(231, 178, 52);
			else MetacriticsLabelA.ForeColor = Color.FromArgb(203, 51, 51);
			UserScoreLabelA.Text = game.user_score.ToString();
			if (game.user_score >= 7.5) UserScoreLabelA.ForeColor = Color.FromArgb(36, 173, 117);
			else if (game.user_score >=5.0 && game.user_score < 7.5) UserScoreLabelA.ForeColor = Color.FromArgb(231, 178, 52);
			else UserScoreLabelA.ForeColor = Color.FromArgb(203, 51, 51);
			GameMinimalProcessorCoresLabel.Text = game.Min_Processor_Cores.ToString();
			GameMinimalProcessorThreadsCount.Text = game.Min_Processor_Threads.ToString();
			GamesMinimalProcessorClock.Text = game.Min_Processor_Clock.ToString() + " MHz";
			GameMinimalRAM.Text = game.Min_RAM.ToString() + " MB";
			GameMinimalGPUVRAM.Text = game.Min_Graphics_VRAM.ToString() + " MB";
			GameMinimalGPUCLock.Text = game.Min_Graphics_Gpu_Clock.ToString() + " MHz";

			PCProcessorName.Text = Program.ThisPC.Processor.Name;
			PCProcessorCores.Text = Program.ThisPC.Processor.NumberOfCores.ToString();
			if (Program.ThisPC.Processor.NumberOfCores >= game.Min_Processor_Cores) PCProcessorCores.ForeColor = Color.FromArgb(36, 173, 117);
			else PCProcessorCores.ForeColor = Color.FromArgb(203, 51, 51);
			PCProcessorThreads.Text = Program.ThisPC.Processor.ThreadCount.ToString();
			if (Program.ThisPC.Processor.ThreadCount >= game.Min_Processor_Threads) PCProcessorThreads.ForeColor = Color.FromArgb(36, 173, 117);
			else PCProcessorThreads.ForeColor = Color.FromArgb(203, 51, 51);
			PCProcessorSpeed.Text = Program.ThisPC.Processor.MaxClockSpeed.ToString() + " MHz";
			if (Program.ThisPC.Processor.MaxClockSpeed <= game.Min_Processor_Clock) PCProcessorSpeed.ForeColor = Color.FromArgb(231, 178, 52);
			else PCProcessorSpeed.ForeColor = Color.FromArgb(36, 173, 117);

			PCRAM.Text = Program.ThisPC.RamCapacity.ToString() + " MB";
			if (Program.ThisPC.RamCapacity > game.Min_RAM) PCRAM.ForeColor = Color.FromArgb(36, 173, 117);
			else if (Math.Abs(Program.ThisPC.RamCapacity - Convert.ToInt32(game.Min_RAM)) <= 512) PCRAM.ForeColor = Color.FromArgb(231, 178, 52);
			else PCRAM.ForeColor = Color.FromArgb(203, 51, 51);

			PCGPUName.Text = Program.ThisPC.GraphicsCard.Name;
			PCGPUVRAM.Text = Program.ThisPC.GraphicsCard.Vram.ToString() + " MB";
			if (Program.ThisPC.GraphicsCard.Vram > game.Min_Graphics_VRAM) PCGPUVRAM.ForeColor = Color.FromArgb(36, 173, 117);
			else if (Math.Abs(Convert.ToInt32(Program.ThisPC.GraphicsCard.Vram) - Convert.ToInt32(game.Min_Graphics_VRAM)) < 256) PCGPUVRAM.ForeColor = Color.FromArgb(231, 178, 52);
			else PCGPUVRAM.ForeColor = Color.FromArgb(203, 51, 51);
			PCGPUClock.Text = Program.ThisPC.GraphicsCard.MaxClockFrequency.ToString() + " MHz";
			if (Program.ThisPC.GraphicsCard.MaxClockFrequency > game.Min_Graphics_Gpu_Clock) PCGPUClock.ForeColor = Color.FromArgb(36, 173, 117);
			else if (Math.Abs(Convert.ToInt32(Program.ThisPC.GraphicsCard.MaxClockFrequency) - Convert.ToInt32(game.Min_Graphics_Gpu_Clock)) < 300) PCGPUClock.ForeColor = Color.FromArgb(231, 178, 52);
			else PCGPUClock.ForeColor = Color.FromArgb(203, 51, 51);

			
			if (bordercolor == Color.FromArgb(36, 173, 117)) {
				CanYouRunItLabel.Text = "Can you run it: Yes";
			}
			if (bordercolor == Color.FromArgb(231, 178, 52)) {
				CanYouRunItLabel.Text = "Can you run it: Maybe";
			}
			if (bordercolor == Color.FromArgb(203, 51, 51))	{
				CanYouRunItLabel.Text = "Can you run it: No";
			}
			CanYouRunItLabel.ForeColor = bordercolor;

			if (game.Rec_RAM != 0) // if Recommended sys req exsists
			{
				ReccomendedSpecsLabel.Visible = true;
				TableLayoutRecSpecs.Visible = true;

				GameRecProcessorCoresLabel.Text = game.Rec_Processor_Cores.ToString();
				GameRecProcessorThreadsCount.Text = game.Rec_Processor_Threads.ToString();
				GamesRecProcessorClock.Text = game.Rec_Processor_Clock.ToString() + " MHz";
				GameRecRAM.Text = game.Rec_RAM.ToString() + " MB";
				GameRecGPUVRAM.Text = game.Rec_Graphics_VRAM.ToString() + " MB";
				GameRecGPUCLock.Text = game.Rec_Graphics_Gpu_Clock.ToString() + " MHz";

				PCProcessorName2.Text = PCProcessorName.Text;
				PCProcessorCores2.Text = Program.ThisPC.Processor.NumberOfCores.ToString();
				if (Program.ThisPC.Processor.NumberOfCores >= game.Rec_Processor_Cores) PCProcessorCores2.ForeColor = Color.FromArgb(36, 173, 117);
				else PCProcessorCores2.ForeColor = Color.FromArgb(203, 51, 51);
				PCProcessorThreads2.Text = Program.ThisPC.Processor.ThreadCount.ToString();
				if (Program.ThisPC.Processor.ThreadCount >= game.Rec_Processor_Threads) PCProcessorThreads2.ForeColor = Color.FromArgb(36, 173, 117);
				else PCProcessorThreads2.ForeColor = Color.FromArgb(203, 51, 51);
				PCProcessorSpeed2.Text = Program.ThisPC.Processor.MaxClockSpeed.ToString() + " MHz";
				if (Program.ThisPC.Processor.MaxClockSpeed <= game.Rec_Processor_Clock) PCProcessorSpeed2.ForeColor = Color.FromArgb(231, 178, 52);
				else PCProcessorSpeed2.ForeColor = Color.FromArgb(36, 173, 117);

				PCRAM2.Text = Program.ThisPC.RamCapacity.ToString() + " MB";
				if (Program.ThisPC.RamCapacity > game.Rec_RAM) PCRAM2.ForeColor = Color.FromArgb(36, 173, 117);
				else if (Math.Abs(Program.ThisPC.RamCapacity - Convert.ToInt32(game.Rec_RAM)) <= 512) PCRAM2.ForeColor = Color.FromArgb(231, 178, 52);
				else PCRAM2.ForeColor = Color.FromArgb(203, 51, 51);

				PCGPUName2.Text = Program.ThisPC.GraphicsCard.Name;
				PCGPUVRAM2.Text = Program.ThisPC.GraphicsCard.Vram.ToString() + " MB";
				if (Program.ThisPC.GraphicsCard.Vram > game.Rec_Graphics_VRAM) PCGPUVRAM2.ForeColor = Color.FromArgb(36, 173, 117);
				else if (Math.Abs(Convert.ToInt32(Program.ThisPC.GraphicsCard.Vram) - Convert.ToInt32(game.Rec_Graphics_VRAM)) < 256) PCGPUVRAM2.ForeColor = Color.FromArgb(231, 178, 52);
				else PCGPUVRAM2.ForeColor = Color.FromArgb(203, 51, 51);
				PCGPUClock2.Text = Program.ThisPC.GraphicsCard.MaxClockFrequency.ToString() + " MHz";
				if (Program.ThisPC.GraphicsCard.MaxClockFrequency > game.Rec_Graphics_Gpu_Clock) PCGPUClock2.ForeColor = Color.FromArgb(36, 173, 117);
				else if (Math.Abs(Convert.ToInt32(Program.ThisPC.GraphicsCard.MaxClockFrequency) - Convert.ToInt32(game.Rec_Graphics_Gpu_Clock)) < 300) PCGPUClock2.ForeColor = Color.FromArgb(231, 178, 52);
				else PCGPUClock2.ForeColor = Color.FromArgb(203, 51, 51);
			}
			else {
				ReccomendedSpecsLabel.Visible = false;
				TableLayoutRecSpecs.Visible = false;
			}
			GameDescriptionLabel.Font = new Font(Program.Comfortaa.Families[0], 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			GameDescriptionLabel.Text = game.Description;
		}
		private void GameInfoForm_Load(object sender, EventArgs e)
		{
			if (BackColor == Color.FromArgb(40, 40, 40)) {
				ForeColor = Color.FromArgb(225, 225, 225);
				label2.BackColor = label4.BackColor = label5.BackColor = label7.BackColor = label18.BackColor = GameMinimalProcessorThreadsCount.BackColor = 
					GameMinimalRAM.BackColor = GameMinimalGPUVRAM.BackColor = PCProcessorName.BackColor = PCProcessorThreads.BackColor = PCRAM.BackColor = PCGPUVRAM.BackColor = Color.FromArgb(50, 50, 50);
				label9.BackColor = label13.BackColor = label15.BackColor = label17.BackColor = label34.BackColor = GameRecProcessorThreadsCount.BackColor =
					GameRecRAM.BackColor = GameRecGPUVRAM.BackColor = PCProcessorName2.BackColor = PCProcessorThreads2.BackColor = PCRAM2.BackColor = PCGPUVRAM2.BackColor = Color.FromArgb(50, 50, 50);
			}
			GameNameLabel.Font = new Font(Program.Comfortaa.Families[0], GameNameLabel.Font.Size);
			TableLayaoutShortDesc.Font = new Font(Program.Comfortaa.Families[0], TableLayaoutShortDesc.Font.Size);
			GamePCComparisonPanel.Font = new Font(Program.Comfortaa.Families[0], 14.0F);
			TableLayoutMinSpecs.Font = new Font(Program.Comfortaa.Families[0], 11.5F);
			TableLayoutRecSpecs.Font = new Font(Program.Comfortaa.Families[0], 11.5F);
		}

		private void closeButton1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void minimizeButton1_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void GameNameLabel_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void GameNameLabel_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		private void GameInfoForm_Shown(object sender, EventArgs e)
		{
			this.BackgroundImage = Properties.Resources.GameInfoFormBackground;
		}
	}
}
