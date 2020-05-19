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
    public partial class InitForm : Form
    {
        public InitForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100) progressBar1.Value += 10;
            else Close();
        }

        private void InitForm_Load(object sender, EventArgs e)
        {
            InitLabel.Font = new Font(Program.Comfortaa.Families[0], InitLabel.Font.Size);
            MainLabel.Font = new Font(Program.Comfortaa.Families[0], MainLabel.Font.Size);
            //TODO check files
        }
    }
}
