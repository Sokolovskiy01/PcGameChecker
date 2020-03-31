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

        private void gameName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
                Image tmp = Image.FromFile(OpenGamePicture.FileName);
                pictureBox1.Height = tmp.Height;
                pictureBox1.Width = tmp.Width;
                pictureBox1.Image = tmp;
                
            }
        }
    }
}