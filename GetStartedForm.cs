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
	public partial class GetStartedForm : Form
	{
		private AgreementForm agreement = new AgreementForm();
		public GetStartedForm()
		{
			InitializeComponent();
		}

		private void GetStartedForm_Load(object sender, EventArgs e)
		{
			GetStartedLabel.Font = new Font(Program.Comfortaa.Families[0], GetStartedLabel.Font.Size);
			ScanButton.Font = new Font(Program.Comfortaa.Families[0], ScanButton.Font.Size);
			CopyrightLabel.Font = new Font(Program.Comfortaa.Families[0], CopyrightLabel.Font.Size);
		}

		private void minimizeButton1_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void closeButton1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void ScanButton_Click(object sender, EventArgs e)
		{
			if (agreement.ShowDialog() == DialogResult.OK)
			{
				Close();
			}
		}
	}
}
