using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PcGameChecker
{

    public partial class GameADD : Form
    {

        public GameADD()
        {
            InitializeComponent();
        }
        private void GameADD_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmGame_Click(object sender, EventArgs e)
        {
            //newGame g1 = new newGame(gameName.Text, Description.Text, Convert.ToUInt32(YearGame.Text), GenreName.Text, pictureBox1.Image, Req_OS.Text, Req_OS_Ar.Text, Req_Disk_Space.Text, Convert.ToUInt32(Min_Processor_Cores.Text), Convert.ToUInt32(Min_Processor_Threads.Text), Convert.ToUInt32(Min_Processor_Clock.Text), Convert.ToUInt32(Min_Graphics_VRAM.Text), Convert.ToUInt32(Min_Graphics_Gpu_Clock.Text));
        }

        private void label13_Click_1(object sender, EventArgs e)
        {
            if(OpenGamePicture.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = Image.FromFile(OpenGamePicture.FileName);
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {
            if(OpenGameIcon.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.BackgroundImage = Image.FromFile(OpenGameIcon.FileName);
                pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }
    }
}