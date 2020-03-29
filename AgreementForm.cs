using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker
{
    public partial class AgreementForm : Form
    {
        public PrivateFontCollection pfc = new PrivateFontCollection();
        public AgreementForm()
        {
            InitializeComponent();
        }

        private void ButtonAgree_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AgreementForm_Load(object sender, EventArgs e)
        {
            //pfc.AddFontFile("Resources\\Comfortaa-VariableFont_wght.ttf");
            AgeementLabel.Font = new Font(Program.Comfortaa.Families[0], AgeementLabel.Font.Size);
        }
    }
}
