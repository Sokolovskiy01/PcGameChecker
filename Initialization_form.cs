using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;

namespace PcGameChecker
{
	public partial class Initialization_form : Form
	{
		private int progressvalue = 10;
		public PrivateFontCollection pfc = new PrivateFontCollection();
		public Initialization_form()
		{
			InitializeComponent();
		}

		private void Initialization_form_Load(object sender, EventArgs e)
		{
			int fontlenght = Properties.Resources.Comfortaa_VariableFont_wght.Length;
			byte[] fontdata = Properties.Resources.Comfortaa_VariableFont_wght;
			System.IntPtr data = Marshal.AllocCoTaskMem(fontlenght);
			Marshal.Copy(fontdata, 0, data, fontlenght);
			pfc.AddMemoryFont(data, fontlenght);

			Program_title.Font = new Font(pfc.Families[0], Program_title.Font.Size);
			Initializing.Font = new Font(pfc.Families[0], Initializing.Font.Size);

			
			Marshal.FreeCoTaskMem(data);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Initialization_form_FormClosing(object sender, FormClosingEventArgs e)
		{
			pfc.Dispose();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			//TODO check all required resourses
			progressvalue += 10;
			Progressbar.Value = progressvalue;
			if (progressvalue == Progressbar.Maximum)
			{
				Close();
			}
		}
	}
}
