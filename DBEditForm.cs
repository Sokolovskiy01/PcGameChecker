using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker
{
	public partial class DBEditForm : Form
	{
		private static GamesDatabaseDataContext DatabaseDC = new GamesDatabaseDataContext();
		private IQueryable<Game> QuarableGames = DatabaseDC.Games.AsQueryable();
		private IQueryable<Platform> QuarablePlatforms = DatabaseDC.Platforms.AsQueryable();
		private IQueryable<GameToPlatform> QuarableGTP = DatabaseDC.GameToPlatforms.AsQueryable();
		public Game SelectedGame;
		Platform SelectedPlatform;
		GameToPlatform GTP;
		bool AreFieldsOkay = true;
		bool DataChanged = false;
		public DBEditForm()
		{
			DoubleBuffered = true;
			SetStyle(ControlStyles.ResizeRedraw, true);
			SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			InitializeComponent();
		}

		private bool IsRecommendedEmpty()
		{
			if (string.IsNullOrEmpty(RecRAMTextbox.Text) && string.IsNullOrEmpty(RecCPUTextbox.Text) && string.IsNullOrEmpty(RecCPUCoresTextbox.Text)
				&& string.IsNullOrEmpty(RecCPUThreadsTextbox.Text) && string.IsNullOrEmpty(RecCPUSpeedTextbox.Text) && string.IsNullOrEmpty(RecGPUNameTextbox.Text)
				&& string.IsNullOrEmpty(RecGPUCoreClockTextbox.Text) && string.IsNullOrEmpty(RecGPUMemoryClockTextbox.Text) && string.IsNullOrEmpty(RecGPUMemoryClockTextbox.Text)
				&& string.IsNullOrEmpty(RecGPUMemoryCapacityTextbox.Text) && string.IsNullOrEmpty(RecGPUBusWidthTextbox.Text)
				&& string.IsNullOrEmpty(RecGPUMemoryTypeTextbox.Text) && string.IsNullOrEmpty(RecGPUShadersTextbox.Text)
				&& string.IsNullOrEmpty(RecGPUROPsTextbox.Text) && string.IsNullOrEmpty(RecGPUTMUsTextbox.Text))
			{
				return true;
			}
			return false;
		}
		
		private void FillFields(Game G)
		{
			GameNameTextbox.Text = G.Name;
			GenreTextbox.Text = G.Genre;
			DescriptionTextBox.Text = G.Description;
			DateTextbox.Value = G.Release;
			MetacriticLink.Text = G.MetacriticsCheckLink;
			CriticsTextbox.Text = G.MetacriticsCritics.ToString();
			UserTextbox.Text = G.MetacriticsUserScore.ToString();
			byte[] b = G.Poster.ToArray();
			MemoryStream ms = new MemoryStream(b);
			PosterBox.BackgroundImage = Image.FromStream(ms);
			b = G.Icon.ToArray();
			ms = new MemoryStream(b);
			IconBox.BackgroundImage = Image.FromStream(ms);
			ms = null;
			//images
			OSComboBox.SelectedItem = G.MinOS;
			OSArchitectureComboBox.SelectedItem = G.MinOSArchitecture.ToString();
			MinFreeDiskTextbox.Text = G.MinDiskSpace.ToString();
			MinRAMTextbox.Text = G.MinRAM.ToString();
			MinCPUTextbox.Text = G.MinProcesorName;
			MinCPUCoresTextbox.Text = G.MinProcessorCores.ToString();
			MinCPUThreadsTextbox.Text = G.MinProcessorThreads.ToString();
			MinCPUSpeedTextbox.Text = G.MinProcessorClock.ToString();
			MinGPUNameTextbox.Text = G.MinGPUName;
			MinGPUCoreClockTextbox.Text = G.MinGPUClock.ToString();
			MinGPUMemoryClockTextbox.Text = G.MinGPUMemoryClock.ToString();
			MinGPUMemoryCapacityTextbox.Text = G.MinGPUMemoryCapacity.ToString();
			MinGPUBusWidthTextbox.Text = G.MinGPUBusWidth.ToString();
			MinGPUMemoryTypeTextbox.Text = G.MinGPUMemoryType;
			MinGPUDirectXTextbox.Text = G.MinGPUDirectX;
			MinGPUShadersTextbox.Text = G.MinGPUShaderUnitCount.ToString();
			MinGPUROPsTextbox.Text = G.MinGPUROPCount.ToString();
			MinGPUTMUsTextbox.Text = G.MinGPUTMUCount.ToString();
			if(!string.IsNullOrEmpty(G.RecProcesorName) || !string.IsNullOrEmpty(G.RecGPUName))	{
				RecRAMTextbox.Text = G.RecRAM.ToString();
				RecCPUTextbox.Text = G.RecProcesorName;
				RecCPUCoresTextbox.Text = G.RecProcessorCores.ToString();
				RecCPUThreadsTextbox.Text = G.RecProcessorThreads.ToString();
				RecCPUSpeedTextbox.Text = G.RecProcessorClock.ToString();
				RecGPUNameTextbox.Text = G.RecGPUName;
				RecGPUCoreClockTextbox.Text = G.RecGPUClock.ToString();
				RecGPUMemoryClockTextbox.Text = G.RecGPUMemoryClock.ToString();
				RecGPUMemoryCapacityTextbox.Text = G.RecGPUMemoryCapacity.ToString();
				RecGPUBusWidthTextbox.Text = G.RecGPUBusWidth.ToString();
				RecGPUMemoryTypeTextbox.Text = G.RecGPUMemoryType;
				RecGPUDirectXTextbox.Text = G.RecGPUDirectX;
				RecGPUShadersTextbox.Text = G.RecGPUShaderUnitCount.ToString();
				RecGPUROPsTextbox.Text = G.RecGPUROPCount.ToString();
				RecGPUTMUsTextbox.Text = G.RecGPUTMUCount.ToString();	
			}
			var query = from GameToPlatform in QuarableGTP
						where GameToPlatform.Game == G
						select GameToPlatform;
			foreach (GameToPlatform gtp in query)
			{
				ListboxPlatforms.SetSelected(gtp.PlatformId - 9, true);
			}
		}
		private void FillFields(Platform P)
		{
			PlatformNameTextbox.Text = P.Name;
			PlatformSubnameTextBox.Text = P.Subname;
			byte[] b = P.Icon.ToArray();
			MemoryStream ms = new MemoryStream(b);
			PlatformIconBox.BackgroundImage = Image.FromStream(ms);
			ms = null;
		}
		private void ClearFields()
		{
			if (SelectedDatabase.SelectedItem.ToString() == "Games")
			{
				foreach (Control c in MainTableLayout.Controls)
				{
					if (c.GetType() == GameNameTextbox.GetType() || c.GetType() == DescriptionTextBox.GetType()) c.Text = "";
				}
				DateTextbox.Value = DateTime.Today;
				DataChanged = false;
				PosterBox.BackgroundImage = null;
				IconBox.BackgroundImage = null;
				SelectedGame = null;
				for(int i = 0; i < ListboxPlatforms.Items.Count; i++)
				{
					ListboxPlatforms.SetSelected(i, false);
				}
			}
			if (SelectedDatabase.SelectedItem.ToString() == "Platforms")
			{
				foreach (Control c in PlatformTableLayout.Controls)
				{
					if (c.GetType() == PlatformNameTextbox.GetType()) c.Text = "";
				}
				PlatformIconBox.BackgroundImage = null;
				SelectedPlatform = null;
			}
		}
		private void CheckFields()
		{
			if (SelectedDatabase.SelectedItem.ToString() == "Games")
			{
				foreach (Control c in MainTableLayout.Controls)
				{
					c.BackColor = MainTableLayout.BackColor;
				}
				AreFieldsOkay = true;
				if (SelectedGame == null) SelectedGame = new Game();
				string MessageError = "";
				//Name check
				if (string.IsNullOrEmpty(GameNameTextbox.Text) || GameNameTextbox.Text.Length > 255)
				{
					GameNameTextbox.BackColor = Color.LightCoral;
					MessageError += "Game name field is empty or longer than 256 char.\n";
					AreFieldsOkay = false;
				}
				//Genre check
				if (string.IsNullOrEmpty(GenreTextbox.Text) || GenreTextbox.Text.Length > 63)
				{
					GenreTextbox.BackColor = Color.LightCoral;
					MessageError += "Game genre field is empty or longer than 63 char.\n";
					AreFieldsOkay = false;
				}
				//Description check
				if (string.IsNullOrEmpty(DescriptionTextBox.Text))
				{
					DescriptionTextBox.BackColor = Color.LightCoral;
					MessageError += "Game description field is empty.\n";
					AreFieldsOkay = false;
				}
				//Release check
				if (!DataChanged)
				{
					DateTextbox.BackColor = Color.LightCoral;
					MessageError += "Game release date is not set.\n";
					AreFieldsOkay = false;
				}
				//Metacritic link check
				if (string.IsNullOrEmpty(MetacriticLink.Text))
				{
					MetacriticLink.BackColor = Color.LightCoral;
					MessageError += "Metacritics check link is is empty.\n";
					AreFieldsOkay = false;
				}
				//Metacritic critics check
				if (string.IsNullOrEmpty(CriticsTextbox.Text))
				{
					CriticsTextbox.BackColor = Color.LightCoral;
					MessageError += "Critics score is empty.\n";
					AreFieldsOkay = false;
				}
				else
				{
					try
					{
						Convert.ToInt32(CriticsTextbox.Text);
						if (Convert.ToInt32(CriticsTextbox.Text) > 100 && Convert.ToInt32(CriticsTextbox.Text) < 0)
						{
							CriticsTextbox.BackColor = Color.LightCoral;
							MessageError += "Critics score is not in range 1-100.\n";
							AreFieldsOkay = false;
						}
					}
					catch
					{
						CriticsTextbox.BackColor = Color.LightCoral;
						MessageError += "Critics score is not a digit.\n";
						AreFieldsOkay = false;
					}
				}
				//Metacritics users check
				if (string.IsNullOrEmpty(UserTextbox.Text))
				{
					UserTextbox.BackColor = Color.LightCoral;
					MessageError += "Critics score is empty.\n";
					AreFieldsOkay = false;
				}
				else
				{
					try
					{
						Convert.ToDecimal(UserTextbox.Text);
						if (Convert.ToDecimal(UserTextbox.Text) < 0 && Convert.ToDecimal(UserTextbox.Text) > 10)
						{
							UserTextbox.BackColor = Color.LightCoral;
							MessageError += "User score is not in range 1-100.\n";
							AreFieldsOkay = false;
						}
					}
					catch
					{
						UserTextbox.BackColor = Color.LightCoral;
						MessageError += "User score is not a double value or put \",\" instead \".\"\n";
						AreFieldsOkay = false;
					}
				}
				//OS check
				if (OSComboBox.SelectedItem == null)
				{
					OSComboBox.BackColor = Color.LightCoral;
					MessageError += "Operation system is not set.\n";
					AreFieldsOkay = false;
				}
				//OS architecture check
				if (OSArchitectureComboBox.SelectedItem == null)
				{
					OSArchitectureComboBox.BackColor = Color.LightCoral;
					MessageError += "Operation system architecture is not set.\n";
					AreFieldsOkay = false;
				}
				//Disk space check
				if (string.IsNullOrEmpty(MinFreeDiskTextbox.Text))
				{
					MinFreeDiskTextbox.BackColor = Color.LightCoral;
					MessageError += "Minimal disk space is empty.\n";
					AreFieldsOkay = false;
				}
				else
				{
					try
					{
						Convert.ToInt32(MinFreeDiskTextbox.Text);
						if (Convert.ToInt32(MinFreeDiskTextbox.Text) <= 0)
						{
							MinFreeDiskTextbox.BackColor = Color.LightCoral;
							MessageError += "Minimal disk space must be higher than 0.\n";
							AreFieldsOkay = false;
						}
					}
					catch
					{
						MinFreeDiskTextbox.BackColor = Color.LightCoral;
						MessageError += "Minimal disk space is not a digit.\n";
						AreFieldsOkay = false;
					}
				}
				//Min RAM check
				if (string.IsNullOrEmpty(MinRAMTextbox.Text))
				{
					MinRAMTextbox.BackColor = Color.LightCoral;
					MessageError += "Minimal RAM is empty.\n";
					AreFieldsOkay = false;
				}
				else
				{
					try
					{
						Convert.ToInt32(MinRAMTextbox.Text);
						if (Convert.ToInt32(MinRAMTextbox.Text) <= 0)
						{
							MinRAMTextbox.BackColor = Color.LightCoral;
							MessageError += "Minimal RAM must be higher than 0.\n";
							AreFieldsOkay = false;
						}
					}
					catch
					{
						MinRAMTextbox.BackColor = Color.LightCoral;
						MessageError += "Minimal RAM is not a digit.\n";
						AreFieldsOkay = false;
					}
				}
				//CPU name check
				if (string.IsNullOrEmpty(MinCPUTextbox.Text))
				{
					MinCPUTextbox.BackColor = Color.LightCoral;
					MessageError += "Minimal CPU name is empty.\n";
					AreFieldsOkay = false;
				}
				//CPU cores check
				if (string.IsNullOrEmpty(MinCPUCoresTextbox.Text))
				{
					MinCPUCoresTextbox.BackColor = Color.LightCoral;
					MessageError += "Minimal CPU cores count is empty.\n";
					AreFieldsOkay = false;
				}
				else
				{
					try
					{
						Convert.ToInt32(MinCPUCoresTextbox.Text);
						if (Convert.ToInt32(MinCPUCoresTextbox.Text) <= 0)
						{
							MinCPUCoresTextbox.BackColor = Color.LightCoral;
							MessageError += "Minimal CPU cores value must be higher than 0.\n";
							AreFieldsOkay = false;
						}
					}
					catch
					{
						MinCPUCoresTextbox.BackColor = Color.LightCoral;
						MessageError += "Minimal CPU cores count is not a digits.\n";
						AreFieldsOkay = false;
					}
				}
				//CPU threads check
				if (string.IsNullOrEmpty(MinCPUThreadsTextbox.Text))
				{
					MinCPUThreadsTextbox.BackColor = Color.LightCoral;
					MessageError += "Minimal CPU threads count is empty.\n";
					AreFieldsOkay = false;
				}
				else
				{
					try
					{
						Convert.ToInt32(MinCPUThreadsTextbox.Text);
						if (Convert.ToInt32(MinCPUThreadsTextbox.Text) <= 0)
						{
							MinCPUThreadsTextbox.BackColor = Color.LightCoral;
							MessageError += "Minimal CPU threads value must be higher than 0.\n";
							AreFieldsOkay = false;
						}
						for (int i = 1; i < 9; i++)
						{
							//if there is 2, 3, 4, ... threads for one procesor core (if there is right threads number) 
							if ((Convert.ToInt32(MinCPUCoresTextbox.Text) * i) == Convert.ToInt32(MinCPUThreadsTextbox.Text)) break;
							if (i == 8)
							{
								MinCPUThreadsTextbox.BackColor = Color.LightCoral;
								MessageError += "Minimal CPU threads are incorrect.\n";
								AreFieldsOkay = false;
							}
						}
					}
					catch
					{
						MinCPUThreadsTextbox.BackColor = Color.LightCoral;
						MessageError += "Minimal CPU threads count is not a digits.\n";
						AreFieldsOkay = false;
					}
				}
				//CPU speed check
				if (string.IsNullOrEmpty(MinCPUSpeedTextbox.Text))
				{
					MinCPUSpeedTextbox.BackColor = Color.LightCoral;
					MessageError += "Minimal CPU speed is empty.\n";
					AreFieldsOkay = false;
				}
				else
				{
					try
					{
						Convert.ToInt32(MinCPUSpeedTextbox.Text);
						if (Convert.ToInt32(MinCPUSpeedTextbox.Text) <= 0)
						{
							MinCPUSpeedTextbox.BackColor = Color.LightCoral;
							MessageError += "Minimal CPU speed value must be higher than 0.\n";
							AreFieldsOkay = false;
						}
					}
					catch
					{
						MinCPUSpeedTextbox.BackColor = Color.LightCoral;
						MessageError += "Minimal CPU speed is not a digits.\n";
						AreFieldsOkay = false;
					}
				}
				//Min GPU name cheeck
				if (string.IsNullOrEmpty(MinGPUNameTextbox.Text) || MinGPUNameTextbox.Text.Length > 128)
				{
					MinGPUNameTextbox.BackColor = Color.LightCoral;
					MessageError += "Minimal GPU name is empty or longer than 128 char.\n";
					AreFieldsOkay = false;
				}
				//Min GPU core speed check
				if (string.IsNullOrEmpty(MinGPUCoreClockTextbox.Text))
				{
					MinGPUCoreClockTextbox.BackColor = Color.LightCoral;
					MessageError += "Minimal GPU core speed is empty.\n";
					AreFieldsOkay = false;
				}
				else
				{
					try
					{
						Convert.ToInt32(MinGPUCoreClockTextbox.Text);
						if (Convert.ToInt32(MinGPUCoreClockTextbox.Text) <= 0)
						{
							MinGPUCoreClockTextbox.BackColor = Color.LightCoral;
							MessageError += "Minimal GPU core speed value must be higher than 0.\n";
							AreFieldsOkay = false;
						}
					}
					catch
					{
						MinGPUCoreClockTextbox.BackColor = Color.LightCoral;
						MessageError += "Minimal GPU core speed is not a digits.\n";
						AreFieldsOkay = false;
					}
				}
				//Min GPU memory clock check
				if (string.IsNullOrEmpty(MinGPUMemoryClockTextbox.Text))
				{
					MinGPUMemoryClockTextbox.BackColor = Color.LightCoral;
					MessageError += "Minimal GPU memory clock is empty.\n";
					AreFieldsOkay = false;
				}
				else
				{
					try
					{
						Convert.ToInt32(MinGPUMemoryClockTextbox.Text);
						if (Convert.ToInt32(MinGPUMemoryClockTextbox.Text) <= 0)
						{
							MinGPUMemoryClockTextbox.BackColor = Color.LightCoral;
							MessageError += "Minimal GPU memory clock value must be higher than 0.\n";
							AreFieldsOkay = false;
						}
					}
					catch
					{
						MinGPUMemoryClockTextbox.BackColor = Color.LightCoral;
						MessageError += "Minimal GPU memory clock is not a digits.\n";
						AreFieldsOkay = false;
					}
				}
				//Min GPU memory capacity check
				if (string.IsNullOrEmpty(MinGPUMemoryCapacityTextbox.Text))
				{
					MinGPUMemoryCapacityTextbox.BackColor = Color.LightCoral;
					MessageError += "Minimal GPU memory capacity is empty.\n";
					AreFieldsOkay = false;
				}
				else
				{
					try
					{
						Convert.ToInt32(MinGPUMemoryCapacityTextbox.Text);
						if (Convert.ToInt32(MinGPUMemoryCapacityTextbox.Text) <= 0)
						{
							MinGPUMemoryCapacityTextbox.BackColor = Color.LightCoral;
							MessageError += "Minimal GPU memory capacity must be higher than 0.\n";
							AreFieldsOkay = false;
						}
					}
					catch
					{
						MinGPUMemoryCapacityTextbox.BackColor = Color.LightCoral;
						MessageError += "Minimal GPU memory capacity is not a digits.\n";
						AreFieldsOkay = false;
					}
				}
				//Min GPU bus width check
				if (string.IsNullOrEmpty(MinGPUBusWidthTextbox.Text))
				{
					MinGPUBusWidthTextbox.BackColor = Color.LightCoral;
					MessageError += "Minimal GPU bus width is empty.\n";
					AreFieldsOkay = false;
				}
				else
				{
					try
					{
						Convert.ToInt32(MinGPUBusWidthTextbox.Text);
						if (Convert.ToInt32(MinGPUBusWidthTextbox.Text) <= 0)
						{
							MinGPUBusWidthTextbox.BackColor = Color.LightCoral;
							MessageError += "Minimal GPU bus width must be higher than 0.\n";
							AreFieldsOkay = false;
						}
					}
					catch
					{
						MinGPUBusWidthTextbox.BackColor = Color.LightCoral;
						MessageError += "Minimal GPU bus width is not a digits.\n";
						AreFieldsOkay = false;
					}
				}
				//Min GPU memory type check
				if (string.IsNullOrEmpty(MinGPUMemoryTypeTextbox.Text) || MinGPUMemoryTypeTextbox.Text.Length > 16)
				{
					MinGPUMemoryTypeTextbox.BackColor = Color.LightCoral;
					MessageError += "Minimal GPU memory type is empty or longer than 16 char.\n";
					AreFieldsOkay = false;
				}
				//Min GPU DirectX check
				if (string.IsNullOrEmpty(MinGPUDirectXTextbox.Text) || MinGPUDirectXTextbox.Text.Length > 16)
				{
					MinGPUDirectXTextbox.BackColor = Color.LightCoral;
					MessageError += "Minimal GPU DirectX version is empty or longer than 16 char.\n";
					AreFieldsOkay = false;
				}
				//Min GPU Shader units check
				if (string.IsNullOrEmpty(MinGPUShadersTextbox.Text))
				{
					MinGPUShadersTextbox.BackColor = Color.LightCoral;
					MessageError += "Minimal GPU shaders is empty.\n";
					AreFieldsOkay = false;
				}
				else
				{
					try
					{
						Convert.ToInt32(MinGPUShadersTextbox.Text);
						if (Convert.ToInt32(MinGPUShadersTextbox.Text) <= 0)
						{
							MinGPUShadersTextbox.BackColor = Color.LightCoral;
							MessageError += "Minimal GPU shaders count must be higher than 0.\n";
							AreFieldsOkay = false;
						}
					}
					catch
					{
						MinGPUShadersTextbox.BackColor = Color.LightCoral;
						MessageError += "Minimal GPU shaders is not a digits.\n";
						AreFieldsOkay = false;
					}
				}
				//Min GPU ROPs check
				if (string.IsNullOrEmpty(MinGPUROPsTextbox.Text))
				{
					MinGPUROPsTextbox.BackColor = Color.LightCoral;
					MessageError += "Minimal GPU ROP\'s is empty.\n";
					AreFieldsOkay = false;
				}
				else
				{
					try
					{
						Convert.ToInt32(MinGPUROPsTextbox.Text);
						if (Convert.ToInt32(MinGPUROPsTextbox.Text) <= 0)
						{
							MinGPUROPsTextbox.BackColor = Color.LightCoral;
							MessageError += "Minimal GPU ROP\'s count must be higher than 0.\n";
							AreFieldsOkay = false;
						}
					}
					catch
					{
						MinGPUROPsTextbox.BackColor = Color.LightCoral;
						MessageError += "Minimal GPU ROP\'s is not a digits.\n";
						AreFieldsOkay = false;
					}
				}
				//Min GPU TMU's check
				if (string.IsNullOrEmpty(MinGPUTMUsTextbox.Text))
				{
					MinGPUTMUsTextbox.BackColor = Color.LightCoral;
					MessageError += "Minimal GPU TMU\'s is empty.\n";
					AreFieldsOkay = false;
				}
				else
				{
					try
					{
						Convert.ToInt32(MinGPUTMUsTextbox.Text);
						if (Convert.ToInt32(MinGPUTMUsTextbox.Text) <= 0)
						{
							MinGPUTMUsTextbox.BackColor = Color.LightCoral;
							MessageError += "Minimal GPU TMU\'s count must be higher than 0.\n";
							AreFieldsOkay = false;
						}
					}
					catch
					{
						MinGPUTMUsTextbox.BackColor = Color.LightCoral;
						MessageError += "Minimal GPU TMU\'s is not a digits.\n";
						AreFieldsOkay = false;
					}
				}
				//Recommnded requirements field check
				if (!IsRecommendedEmpty())
				{
					//Rec RAM check
					if (string.IsNullOrEmpty(RecRAMTextbox.Text))
					{
						RecRAMTextbox.BackColor = Color.LightCoral;
						MessageError += "Recommended RAM is empty.\n";
						AreFieldsOkay = false;
						try
						{
							Convert.ToInt32(RecRAMTextbox.Text);
							if (Convert.ToInt32(RecRAMTextbox.Text) <= 0)
							{
								RecRAMTextbox.BackColor = Color.LightCoral;
								MessageError += "Recommended RAM value must be higher than 0.\n";
								AreFieldsOkay = false;
							}
						}
						catch
						{
							RecRAMTextbox.BackColor = Color.LightCoral;
							MessageError += "Recommended RAM value must be a digit.\n";
							AreFieldsOkay = false;
						}
					}
					//Rec GPU name check
					if (string.IsNullOrEmpty(RecCPUTextbox.Text) || RecCPUTextbox.Text.Length > 128)
					{
						RecCPUTextbox.BackColor = Color.LightCoral;
						MessageError += "Recommended CPU name is empty or longer than 128 char.\n";
						AreFieldsOkay = false;
					}
					//Rec CPU cores check
					if (string.IsNullOrEmpty(RecCPUCoresTextbox.Text))
					{
						RecCPUCoresTextbox.BackColor = Color.LightCoral;
						MessageError += "Recommended CPU cores field is empty.\n";
						AreFieldsOkay = false;
					}
					else
					{
						try
						{
							Convert.ToInt32(RecCPUCoresTextbox.Text);
							if (Convert.ToInt32(RecCPUCoresTextbox.Text) <= 0)
							{
								RecCPUCoresTextbox.BackColor = Color.LightCoral;
								MessageError += "Recommended CPU cores count must be higher than 0.\n";
								AreFieldsOkay = false;
							}
						}
						catch
						{
							RecCPUCoresTextbox.BackColor = Color.LightCoral;
							MessageError += "Recommended CPU cores is not a digits.\n";
							AreFieldsOkay = false;
						}
					}
					//Rec CPU threads check
					if (string.IsNullOrEmpty(RecCPUThreadsTextbox.Text))
					{
						RecCPUThreadsTextbox.BackColor = Color.LightCoral;
						MessageError += "Recommended CPU threads field is empty.\n";
						AreFieldsOkay = false;
					}
					else
					{
						try
						{
							Convert.ToInt32(RecCPUThreadsTextbox.Text);
							if (Convert.ToInt32(RecCPUThreadsTextbox.Text) <= 0)
							{
								RecCPUThreadsTextbox.BackColor = Color.LightCoral;
								MessageError += "Recommended CPU threads count must be higher than 0.\n";
								AreFieldsOkay = false;
							}
						}
						catch
						{
							RecCPUThreadsTextbox.BackColor = Color.LightCoral;
							MessageError += "Recommended CPU threads is not a digits.\n";
							AreFieldsOkay = false;
						}
					}
					//Rec CPU speed check
					if (string.IsNullOrEmpty(RecCPUSpeedTextbox.Text))
					{
						RecCPUSpeedTextbox.BackColor = Color.LightCoral;
						MessageError += "Recommended CPU speed is empty.\n";
						AreFieldsOkay = false;
					}
					else
					{
						try
						{
							Convert.ToInt32(RecCPUSpeedTextbox.Text);
							if (Convert.ToInt32(RecCPUSpeedTextbox.Text) <= 0)
							{
								RecCPUSpeedTextbox.BackColor = Color.LightCoral;
								MessageError += "Recommended CPU speed value must be higher than 0.\n";
								AreFieldsOkay = false;
							}
						}
						catch
						{
							RecCPUSpeedTextbox.BackColor = Color.LightCoral;
							MessageError += "Recommended CPU speed is not a digits.\n";
							AreFieldsOkay = false;
						}
					}
					//Rec GPU name check
					if (string.IsNullOrEmpty(RecGPUNameTextbox.Text) || RecGPUNameTextbox.Text.Length > 128)
					{
						RecGPUNameTextbox.BackColor = Color.LightCoral;
						MessageError += "Recommended GPU name is empty or longer than 128 char.\n";
						AreFieldsOkay = false;
					}
					//Rec GPU core speed check
					if (string.IsNullOrEmpty(RecGPUCoreClockTextbox.Text))
					{
						RecGPUCoreClockTextbox.BackColor = Color.LightCoral;
						MessageError += "Recommended GPU core clock is empty.\n";
						AreFieldsOkay = false;
					}
					else
					{
						try
						{
							Convert.ToInt32(RecCPUSpeedTextbox.Text);
							if (Convert.ToInt32(RecCPUSpeedTextbox.Text) <= 0)
							{
								RecCPUSpeedTextbox.BackColor = Color.LightCoral;
								MessageError += "Recommended CPU core clock must be higher than 0.\n";
								AreFieldsOkay = false;
							}
						}
						catch
						{
							RecCPUSpeedTextbox.BackColor = Color.LightCoral;
							MessageError += "Recommended CPU core clock is not a digits.\n";
							AreFieldsOkay = false;
						}
					}
					//Rec GPU memory clock check
					if (string.IsNullOrEmpty(RecGPUMemoryClockTextbox.Text))
					{
						RecGPUMemoryClockTextbox.BackColor = Color.LightCoral;
						MessageError += "Recommended GPU memory clock is empty.\n";
						AreFieldsOkay = false;
					}
					else
					{
						try
						{
							Convert.ToInt32(RecGPUMemoryClockTextbox.Text);
							if (Convert.ToInt32(RecGPUMemoryClockTextbox.Text) <= 0)
							{
								RecGPUMemoryClockTextbox.BackColor = Color.LightCoral;
								MessageError += "Recommended CPU memory clock must be higher than 0.\n";
								AreFieldsOkay = false;
							}
						}
						catch
						{
							RecGPUMemoryClockTextbox.BackColor = Color.LightCoral;
							MessageError += "Recommended CPU memory clock is not a digits.\n";
							AreFieldsOkay = false;
						}
					}
					//Rec GPU memory capacity check
					if (string.IsNullOrEmpty(RecGPUMemoryCapacityTextbox.Text))
					{
						RecGPUMemoryCapacityTextbox.BackColor = Color.LightCoral;
						MessageError += "Recommended GPU memory capacity is empty.\n";
						AreFieldsOkay = false;
					}
					else
					{
						try
						{
							Convert.ToInt32(RecGPUMemoryCapacityTextbox.Text);
							if (Convert.ToInt32(RecGPUMemoryCapacityTextbox.Text) <= 0)
							{
								RecGPUMemoryCapacityTextbox.BackColor = Color.LightCoral;
								MessageError += "Recommended GPU memory capacity must be higher than 0.\n";
								AreFieldsOkay = false;
							}
						}
						catch
						{
							RecGPUMemoryCapacityTextbox.BackColor = Color.LightCoral;
							MessageError += "Recommended GPU memory capacity is not a digits.\n";
							AreFieldsOkay = false;
						}
					}
					//Rec GPU bus width check
					if (string.IsNullOrEmpty(RecGPUBusWidthTextbox.Text))
					{
						RecGPUBusWidthTextbox.BackColor = Color.LightCoral;
						MessageError += "Recommended GPU bus width is empty.\n";
						AreFieldsOkay = false;
					}
					else
					{
						try
						{
							Convert.ToInt32(RecGPUBusWidthTextbox.Text);
							if (Convert.ToInt32(RecGPUBusWidthTextbox.Text) <= 0)
							{
								RecGPUBusWidthTextbox.BackColor = Color.LightCoral;
								MessageError += "Recommended GPU bus width must be higher than 0.\n";
								AreFieldsOkay = false;
							}
						}
						catch
						{
							RecGPUBusWidthTextbox.BackColor = Color.LightCoral;
							MessageError += "Recommended GPU bus width is not a digits.\n";
							AreFieldsOkay = false;
						}
					}
					//Rec GPU memory type check
					if (string.IsNullOrEmpty(RecGPUMemoryTypeTextbox.Text) || RecGPUMemoryTypeTextbox.Text.Length > 16)
					{
						RecGPUMemoryTypeTextbox.BackColor = Color.LightCoral;
						MessageError += "longer GPU memory type is empty or longer than 16 char.\n";
						AreFieldsOkay = false;
					}
					//Rec GPU DirectX check
					if (string.IsNullOrEmpty(RecGPUDirectXTextbox.Text) || RecGPUDirectXTextbox.Text.Length > 16)
					{
						RecGPUDirectXTextbox.BackColor = Color.LightCoral;
						MessageError += "Recommended GPU DirectX version is empty or longer than 16 char.\n";
						AreFieldsOkay = false;
					}
					//Rec GPU shaders check
					if (string.IsNullOrEmpty(RecGPUShadersTextbox.Text))
					{
						RecGPUShadersTextbox.BackColor = Color.LightCoral;
						MessageError += "Recommended GPU shaders is empty.\n";
						AreFieldsOkay = false;
					}
					else
					{
						try
						{
							Convert.ToInt32(RecGPUShadersTextbox.Text);
							if (Convert.ToInt32(RecGPUShadersTextbox.Text) <= 0)
							{
								RecGPUShadersTextbox.BackColor = Color.LightCoral;
								MessageError += "Recommended CPU shaders count must be higher than 0.\n";
								AreFieldsOkay = false;
							}
						}
						catch
						{
							RecGPUShadersTextbox.BackColor = Color.LightCoral;
							MessageError += "Recommended CPU shaders is not a digits.\n";
							AreFieldsOkay = false;
						}
					}
					//Rec GPU ROP's check
					if (string.IsNullOrEmpty(RecGPUROPsTextbox.Text))
					{
						RecGPUROPsTextbox.BackColor = Color.LightCoral;
						MessageError += "Recommended GPU ROP\'s is empty.\n";
						AreFieldsOkay = false;
					}
					else
					{
						try
						{
							Convert.ToInt32(RecGPUROPsTextbox.Text);
							if (Convert.ToInt32(RecGPUROPsTextbox.Text) <= 0)
							{
								RecGPUROPsTextbox.BackColor = Color.LightCoral;
								MessageError += "Recommended GPU ROP\'s count must be higher than 0.\n";
								AreFieldsOkay = false;
							}
						}
						catch
						{
							RecGPUROPsTextbox.BackColor = Color.LightCoral;
							MessageError += "Recommended GPU ROP\'s is not a digits.\n";
							AreFieldsOkay = false;
						}
					}
					//Min GPU TMU's check
					if (string.IsNullOrEmpty(RecGPUTMUsTextbox.Text))
					{
						RecGPUTMUsTextbox.BackColor = Color.LightCoral;
						MessageError += "Recommended GPU TMU\'s is empty.\n";
						AreFieldsOkay = false;
					}
					else
					{
						try
						{
							Convert.ToInt32(RecGPUTMUsTextbox.Text);
							if (Convert.ToInt32(RecGPUTMUsTextbox.Text) <= 0)
							{
								RecGPUTMUsTextbox.BackColor = Color.LightCoral;
								MessageError += "Recommended GPU TMU\'s count must be higher than 0.\n";
								AreFieldsOkay = false;
							}
						}
						catch
						{
							RecGPUTMUsTextbox.BackColor = Color.LightCoral;
							MessageError += "Recommended GPU TMU\'s is not a digits.\n";
							AreFieldsOkay = false;
						}
					}
				}//end of IsRecommendedEMpty()

				if (PosterBox.BackgroundImage == null)
				{
					MessageError += "Poster image is not set. But can be dissmissed.\n";
				}
				if (IconBox.BackgroundImage == null)
				{
					IconBox.BackColor = Color.LightCoral;
					MessageError += "Icon image is not set.\n";
					AreFieldsOkay = false;
				}

				if (AreFieldsOkay)
				{
					SelectedGame.Name = GameNameTextbox.Text;
					SelectedGame.Genre = GenreTextbox.Text;
					SelectedGame.Description = DescriptionTextBox.Text;
					SelectedGame.Release = DateTextbox.Value;
					SelectedGame.MetacriticsCheckLink = MetacriticLink.Text;
					SelectedGame.MetacriticsCritics = Convert.ToInt32(CriticsTextbox.Text);
					SelectedGame.MetacriticsUserScore = Convert.ToDecimal(UserTextbox.Text);
					MemoryStream ms = new MemoryStream();
					PosterBox.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
					SelectedGame.Poster = new System.Data.Linq.Binary(ms.GetBuffer());
					ms = new MemoryStream();
					IconBox.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
					SelectedGame.Icon = new System.Data.Linq.Binary(ms.GetBuffer());
					ms = null;
					SelectedGame.MinOS = OSComboBox.SelectedItem.ToString();
					SelectedGame.MinOSArchitecture = Convert.ToInt32(OSArchitectureComboBox.SelectedItem);
					SelectedGame.MinDiskSpace = Convert.ToInt32(MinFreeDiskTextbox.Text);
					SelectedGame.MinRAM = Convert.ToInt32(MinRAMTextbox.Text);
					SelectedGame.MinProcesorName = MinCPUTextbox.Text;
					SelectedGame.MinProcessorCores = Convert.ToInt32(MinCPUCoresTextbox.Text);
					SelectedGame.MinProcessorThreads = Convert.ToInt32(MinCPUThreadsTextbox.Text);
					SelectedGame.MinProcessorClock = Convert.ToInt32(MinCPUSpeedTextbox.Text);
					SelectedGame.MinGPUName = MinGPUNameTextbox.Text;
					SelectedGame.MinGPUClock = Convert.ToInt32(MinGPUCoreClockTextbox.Text);
					SelectedGame.MinGPUMemoryClock = Convert.ToInt32(MinGPUMemoryClockTextbox.Text);
					SelectedGame.MinGPUMemoryCapacity = Convert.ToInt32(MinGPUMemoryCapacityTextbox.Text);
					SelectedGame.MinGPUBusWidth = Convert.ToInt32(MinGPUBusWidthTextbox.Text);
					SelectedGame.MinGPUMemoryType = MinGPUMemoryTypeTextbox.Text;
					SelectedGame.MinGPUDirectX = MinGPUDirectXTextbox.Text;
					SelectedGame.MinGPUShaderUnitCount = Convert.ToInt32(MinGPUShadersTextbox.Text);
					SelectedGame.MinGPUROPCount = Convert.ToInt32(MinGPUROPsTextbox.Text);
					SelectedGame.MinGPUTMUCount = Convert.ToInt32(MinGPUTMUsTextbox.Text);
					if (!IsRecommendedEmpty())
					{
						SelectedGame.RecRAM = Convert.ToInt32(RecRAMTextbox.Text);
						SelectedGame.RecProcesorName = RecCPUTextbox.Text;
						SelectedGame.RecProcessorCores = Convert.ToInt32(RecCPUCoresTextbox.Text);
						SelectedGame.RecProcessorThreads = Convert.ToInt32(RecCPUThreadsTextbox.Text);
						SelectedGame.RecProcessorClock = Convert.ToInt32(RecCPUSpeedTextbox.Text);
						SelectedGame.RecGPUName = RecGPUNameTextbox.Text;
						SelectedGame.RecGPUClock = Convert.ToInt32(RecCPUSpeedTextbox.Text);
						SelectedGame.RecGPUMemoryClock = Convert.ToInt32(RecGPUMemoryClockTextbox.Text);
						SelectedGame.RecGPUMemoryCapacity = Convert.ToInt32(RecGPUMemoryCapacityTextbox.Text);
						SelectedGame.RecGPUBusWidth = Convert.ToInt32(RecGPUBusWidthTextbox.Text);
						SelectedGame.RecGPUMemoryType = RecGPUMemoryTypeTextbox.Text;
						SelectedGame.RecGPUDirectX = RecGPUDirectXTextbox.Text;
						SelectedGame.RecGPUShaderUnitCount = Convert.ToInt32(RecGPUShadersTextbox.Text);
						SelectedGame.RecGPUROPCount = Convert.ToInt32(RecGPUROPsTextbox.Text);
						SelectedGame.RecGPUTMUCount = Convert.ToInt32(RecGPUTMUsTextbox.Text);
					}
				}
				else
				{
					MessageBox.Show(MessageError);
					SelectedGame = null;
				}
			}
			if (SelectedDatabase.SelectedItem.ToString() == "Platforms")
			{
				if (SelectedPlatform == null) SelectedPlatform = new Platform();
				AreFieldsOkay = true;
				string MessageError = "";
				foreach (Control c in PlatformTableLayout.Controls)
				{
					c.BackColor = PlatformTableLayout.BackColor;
				}
				if (string.IsNullOrEmpty(PlatformNameTextbox.Text)) {
					PlatformNameTextbox.BackColor = Color.LightCoral;
					MessageError += "Platform name is empty.\n";
					AreFieldsOkay = false;
				}
				if (string.IsNullOrEmpty(PlatformSubnameTextBox.Text)) {
					PlatformSubnameTextBox.BackColor = Color.LightCoral;
					MessageError += "Platform subname is empty.\n";
					AreFieldsOkay = false;
				}
				if (PlatformIconBox.BackgroundImage == null) {
					PlatformSubnameTextBox.BackColor = Color.LightCoral;
					MessageError += "Platform icon is unset.\n";
					AreFieldsOkay = false;
				}
				if (AreFieldsOkay)
				{
					SelectedPlatform.Name = PlatformNameTextbox.Text;
					SelectedPlatform.Subname = PlatformSubnameTextBox.Text;
					MemoryStream ms = new MemoryStream();
					PlatformIconBox.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
					SelectedPlatform.Icon = new System.Data.Linq.Binary(ms.GetBuffer());
					ms = null;
				}
				else
				{
					MessageBox.Show(MessageError);
					SelectedPlatform = null;
				}
			}
			if (SelectedDatabase.SelectedItem.ToString() == "Game to Platform")
			{

			}
		}//end of CheckFields

		private void DBEditForm_Load(object sender, EventArgs e)
		{
			LoadGamesFromDatabase();
			foreach (Platform p in DatabaseDC.Platforms) {
				ListboxPlatforms.Items.Add(p);
			}
			SelectedDatabase.SelectedItem = "Games";
		}

		private void SelectedDatabase_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (SelectedDatabase.SelectedItem.ToString() == "Games")
			{
				MainTableLayout.Visible = true;
				PlatformTableLayout.Visible = false;
				LoadGamesFromDatabase();
			}
			if (SelectedDatabase.SelectedItem.ToString() == "Platforms")
			{
				MainTableLayout.Visible = false;
				PlatformTableLayout.Visible = true;
				LoadPlatforms();
			}
			if (SelectedDatabase.SelectedItem.ToString() == "Game to Platform")
			{
				MainTableLayout.Visible = false;
				PlatformTableLayout.Visible = false;
				LoadGameToPlatforms();
			}
		}

		private void LoadGameToPlatforms()
		{
			GamesList.Items.Clear();
			foreach (GameToPlatform gtp in DatabaseDC.GameToPlatforms)
			{
				GamesList.Items.Add(gtp);
			}
		}
		private void LoadPlatforms()
		{
			GamesList.Items.Clear();
			foreach (Platform p in DatabaseDC.Platforms)
			{
				GamesList.Items.Add(p);
			}
		}
		private void LoadGamesFromDatabase()
		{
			GamesList.Items.Clear();
			foreach(Game g in DatabaseDC.Games)
			{
				GamesList.Items.Add(g);
			}
		}

		private void ButtonAcceptGame_Click(object sender, EventArgs e)
		{
			if (SelectedDatabase.SelectedItem.ToString() == "Games")
			{
				if (ButtonAcceptGame.Text == "Add")
				{
					CheckFields();
					if (AreFieldsOkay)
					{
						DatabaseDC.Games.InsertOnSubmit(SelectedGame);
						foreach (Platform p in ListboxPlatforms.SelectedItems)
						{
							GTP = new GameToPlatform();
							GTP.Game = SelectedGame;
							GTP.Platform = p;
							DatabaseDC.GameToPlatforms.InsertOnSubmit(GTP);
						}
						DatabaseDC.SubmitChanges();
						LoadGamesFromDatabase();
						ClearFields();
					}
				}
				if (ButtonAcceptGame.Text == "Save")
				{
					CheckFields();
					if (AreFieldsOkay)
					{
						foreach (GameToPlatform gtp in DatabaseDC.GameToPlatforms)
						{
							if (gtp.Game == SelectedGame) DatabaseDC.GameToPlatforms.DeleteOnSubmit(gtp);
						}
						DatabaseDC.SubmitChanges();
						foreach (Platform p in ListboxPlatforms.SelectedItems)
						{
							GTP = new GameToPlatform();
							GTP.Game = SelectedGame;
							GTP.Platform = p;
							DatabaseDC.GameToPlatforms.InsertOnSubmit(GTP);
						}
						DatabaseDC.SubmitChanges();
						GamesList.Enabled = true;
						ButtonDeleteGame.Enabled = false;
						ButtonAcceptGame.Text = "Add";
						ClearFields();
					}
				}
			}
			if (SelectedDatabase.SelectedItem.ToString() == "Platforms")
			{
				CheckFields();
				if (ButtonAcceptGame.Text == "Add")
				{
					if (AreFieldsOkay)
					{
						DatabaseDC.Platforms.InsertOnSubmit(SelectedPlatform);
						DatabaseDC.SubmitChanges();
						LoadPlatforms();
						ClearFields();
					}
				}
				if (ButtonAcceptGame.Text == "Save")
				{
					if (AreFieldsOkay)
					{
						DatabaseDC.SubmitChanges();
						GamesList.Enabled = true;
						ButtonDeleteGame.Enabled = false;
						ButtonAcceptGame.Text = "Add";
						ClearFields();
					}
				}
			}
		}

		private void GamesList_SelectedIndexChanged(object sender, EventArgs e)
		{
			ClearFields();
			if (SelectedDatabase.SelectedItem.ToString() == "Games") {
				if (GamesList.SelectedItems.Count == 1)
				{
					SelectedGame = GamesList.SelectedItem as Game;
					ButtonAcceptGame.Text = "Save";
					ButtonDeleteGame.Enabled = true;
					FillFields(SelectedGame);
				}
			}
			if (SelectedDatabase.SelectedItem.ToString() == "Platforms") {
				if (GamesList.SelectedItems.Count == 1)
				{
					SelectedPlatform = GamesList.SelectedItem as Platform;
					if (SelectedPlatform != null)
					{
						ButtonAcceptGame.Text = "Save";
						ButtonDeleteGame.Enabled = true;
						FillFields(SelectedPlatform);
					}
				}
			}
		}

		private void ButtonDeleteGame_Click(object sender, EventArgs e)
		{
			if (SelectedDatabase.SelectedItem.ToString() == "Games")
			{
				if (SelectedGame != null)
				{
					DatabaseDC.Games.DeleteOnSubmit(SelectedGame);
					DatabaseDC.SubmitChanges();
					ClearFields();
					GamesList.Enabled = true;
					LoadGamesFromDatabase();
					ButtonAcceptGame.Text = "Add";
				}
			}
			if (SelectedDatabase.SelectedItem.ToString() == "Platforms")
			{
				if (SelectedPlatform != null)
				{
					DatabaseDC.Platforms.DeleteOnSubmit(SelectedPlatform);
					DatabaseDC.SubmitChanges();
					ClearFields();
					GamesList.Enabled = true;
					LoadPlatforms();
					ButtonAcceptGame.Text = "Add";
				}
			}
		}

		#region MicsEvents
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Escape)
			{
				if(SelectedGame != null)
                {
					ButtonAcceptGame.Text = "Add";
					ButtonDeleteGame.Enabled = false;
					ClearFields();
                }
				if (SelectedPlatform != null)
                {
					ButtonAcceptGame.Text = "Add";
					ButtonDeleteGame.Enabled = false;
					ClearFields();
                }
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}
		private void IconBox_Click(object sender, EventArgs e)
		{
			if (OpenImageIcon.ShowDialog() == DialogResult.OK)
			{
				IconBox.BackgroundImage = Image.FromFile(OpenImageIcon.FileName);
				IconBox.BackgroundImageLayout = ImageLayout.Zoom;
			}
		}

		private void PosterBox_Click(object sender, EventArgs e)
		{
			if (OpenImagePoster.ShowDialog() == DialogResult.OK)
			{
				PosterBox.BackgroundImage = Image.FromFile(OpenImagePoster.FileName);
				PosterBox.BackgroundImageLayout = ImageLayout.Zoom;
			}
		}

		private void PlatformIconBox_Click(object sender, EventArgs e)
		{
			if (OpenImagePlatform.ShowDialog() == DialogResult.OK)
			{
				PlatformIconBox.BackgroundImage = Image.FromFile(OpenImagePlatform.FileName);
				PlatformIconBox.BackgroundImageLayout = ImageLayout.Zoom;
			}
		}
		private void DateTextbox_ValueChanged(object sender, EventArgs e)
		{
			DataChanged = true;
		}

        private void DBEditForm_Resize(object sender, EventArgs e)
        {
			GamesList.Width = this.Width * 20 / 100;
		}
        #endregion

    }//end of class
}//end of namespace