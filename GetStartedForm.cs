using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker
{
	public partial class GetStartedForm : Form
	{
		public PrivateFontCollection pfc = new PrivateFontCollection();
		public GetStartedForm()
		{
			InitializeComponent();
		}
		private void GetStartedForm_Load(object sender, EventArgs e)
		{
			int fontlenght = Properties.Resources.Comfortaa_VariableFont_wght.Length;
			byte[] fontdata = Properties.Resources.Comfortaa_VariableFont_wght;
			System.IntPtr data = Marshal.AllocCoTaskMem(fontlenght);
			Marshal.Copy(fontdata, 0, data, fontlenght);
			pfc.AddMemoryFont(data, fontlenght);

			GetStartedLabel.Font = new Font(pfc.Families[0], GetStartedLabel.Font.Size);
			CopyrightLabel.Font = new Font(pfc.Families[0], CopyrightLabel.Font.Size);
		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void pictureBox1_MouseHover(object sender, EventArgs e)
		{
			CloseImage.Image = Properties.Resources.closeb;
		}

		private void CloseImage_MouseLeave(object sender, EventArgs e)
		{
			CloseImage.Image = Properties.Resources.closeg;
		}
	}
}
