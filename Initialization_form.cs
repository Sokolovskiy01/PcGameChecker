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
		private int progressvalue = 0;
		public Initialization_form()
		{
			InitializeComponent();
		}

		private void Initialization_form_Load(object sender, EventArgs e)
		{
			Progressbar.Value = progressvalue;
			Program_title.Font = new Font(Program.Comfortaa.Families[0], Program_title.Font.Size);
			Initializing.Font = new Font(Program.Comfortaa.Families[0], Initializing.Font.Size);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Initialization_form_FormClosing(object sender, FormClosingEventArgs e)
		{
			//pfc.Dispose();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			//TODO check all required resourses
			progressvalue += 50;
			Progressbar.Value = progressvalue;
			if (progressvalue == Progressbar.Maximum)
			{
				Close();
			}
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			Program.mode = 2;
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			button2.Visible = false;
			button1.Visible = false;
			Progressbar.Visible = true;
			Initializing.Visible = true;
			timer1.Enabled = true;
		}
	}
}
