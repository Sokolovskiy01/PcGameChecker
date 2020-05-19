using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        List<Game> GameList = new List<Game>();
        private int driveleftmargin = 230;
        private int gametopmargin = 92;
        public FormMain()
        {
            InitializeComponent();
        }
        private void GetDiskspaces()
        {
            double a = 0;
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo MyDriveInfo in allDrives)
            {
                if (MyDriveInfo.IsReady == true)
                {
                    a = (MyDriveInfo.AvailableFreeSpace / 1024) / 1024 / 1024;
                    HardDriveInfo h = new HardDriveInfo(MyDriveInfo.Name, a.ToString("#.##") + " GB");
                    h.Location = new Point(driveleftmargin, 8);
                    h.Font = new Font(Program.Comfortaa.Families[0], HomeFreeDiskLabel.Font.Size);
                    h.BackColor = Color.White;
                    HomeGamesPanel.Controls.Add(h);
                    driveleftmargin += 190;
                }
            }
        }
        private void DeserializeGames(/*Panel parent*/)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                FileStream fs1 = new FileStream("gamelist.dat", FileMode.Open);
                GameList = (List<Game>)formatter.Deserialize(fs1);
                fs1.Close();
                Color c;
                int count = 1;
                foreach (var game in GameList)
                {
                    if (count % 3 == 0) {
                        c = Color.FromArgb(203, 51, 51);
                    }
                    else if (count % 2 == 0) {
                        c = Color.FromArgb(231, 178, 52);
                    }
                    else c = Color.FromArgb(36, 173, 117);
                    GameBlockHorizontal gbh = new GameBlockHorizontal(game, c);
                    gbh.Location = new Point(57, gametopmargin);
                    HomeGamesPanel.Controls.Add(gbh);
                    //ExistingGamesRichTextBox.Text += count.ToString() + ") " + game.Name + "\n";
                    gametopmargin += 85;
                    count++;
                }
            }
            catch
            {
                MessageBox.Show("gamelist.dat does not exist");
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
            HomeInfoPanelGPULabel.Font = new Font(Program.Comfortaa.Families[0], HomeInfoPanelGPULabel.Font.Size);
            HomeInfoPanelProcessorLabel.Font = new Font(Program.Comfortaa.Families[0], HomeInfoPanelProcessorLabel.Font.Size);
            HomeInfoPanelRAMLabel.Font = new Font(Program.Comfortaa.Families[0], HomeInfoPanelRAMLabel.Font.Size);
            HomeFreeDiskLabel.Font = new Font(Program.Comfortaa.Families[0], HomeFreeDiskLabel.Font.Size);
            HomeInfoProcessorCounterLabel.Font = new Font(Program.Comfortaa.Families[0], HomeInfoProcessorCounterLabel.Font.Size);
            HomeGamesPanel.Font = new Font(Program.Comfortaa.Families[0], HomeGamesPanel.Font.Size);

            closeButton1.BringToFront();
            minimizeButton1.BringToFront();

            HomeButton_Click(sender, e);
            GetDiskspaces();
            DeserializeGames();
        }

        private void closeButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsPanel.BringToFront();
            SettingsButton.IsActive = true;
            DisableButtons();
            Invalidate();
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomePanel.BringToFront();
            HomeButton.IsActive = true;
            driveleftmargin = 230;
            gametopmargin = 92;
            DeserializeGames();
            GetDiskspaces();
            DisableButtons();
            Invalidate();
        }
        private void GamesButton_Click(object sender, EventArgs e)
        {
            DisableButtons();
            HomeGamesPanel.Controls.Clear();
            GamesPanel.BringToFront();
            GamesButton.IsActive = true;
            DisableButtons();
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float pcpu = CPU_perf.NextValue();
            HomeInfoProcessorCounterLabel.Text = string.Format("{0:0.0}%", pcpu);
        }
    }
}
