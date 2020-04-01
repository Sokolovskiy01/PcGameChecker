using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker
{
	public partial class GetStartedForm : Form
	{
		Color bordercolor = new Color();
		Color buttoncolor = new Color();
		private AgreementForm agreement = new AgreementForm();
		Point lastPoint;
		public GetStartedForm()
		{
			InitializeComponent();
		}
		private void GetStartedForm_Load(object sender, EventArgs e)
		{
			BringToFront();
			SendToBack();

			bordercolor = Color.FromArgb(36, 173, 117);
			buttoncolor = Color.White;

			GetStartedLabel.Font = new Font(Program.Comfortaa.Families[0], GetStartedLabel.Font.Size);
			CopyrightLabel.Font = new Font(Program.Comfortaa.Families[0], CopyrightLabel.Font.Size);
			ScanPCLabel.Font = new Font(Program.Comfortaa.Families[0], ScanPCLabel.Font.Size);
			//ExtendedGraphics
		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void CloseImage_MouseLeave(object sender, EventArgs e)
		{
			CloseImage.Image = Properties.Resources.closeg;
		}
		private void CloseImage_MouseMove(object sender, MouseEventArgs e)
		{
			CloseImage.Image = Properties.Resources.closeb;
		}
		private void Panel_fake_rectangle_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.SmoothingMode = SmoothingMode.AntiAlias;
			g.FillRoundedRectangle(new SolidBrush(bordercolor), 0, 0, Panel_fake_rectangle.Width - 1, Panel_fake_rectangle.Height - 1, 12);
			g.FillRoundedRectangle(new SolidBrush(buttoncolor), 5, 5, Panel_fake_rectangle.Width - 11, Panel_fake_rectangle.Height - 11, 8);
		}

		private void ScanPCLabel_MouseLeave(object sender, EventArgs e)
		{
			ScanPCLabel.ForeColor = Color.FromArgb(36, 173, 117);
			bordercolor = Color.FromArgb(36, 173, 117);
			buttoncolor = Color.White;
		}

		private void ScanPCLabel_MouseMove(object sender, MouseEventArgs e)
		{
			ScanPCLabel.ForeColor = Color.FromArgb(37, 111, 180);
			bordercolor = Color.FromArgb(37, 111, 180);
			//buttoncolor = Color.Gray;
			//Invalidate(Panel_fake_rectangle.ClientRectangle);
		}

		private void ScanPCLabel_Click(object sender, EventArgs e)
		{
			if(agreement.ShowDialog() == DialogResult.OK)
			{
				Close();
			}
		}
		private void ScanPCLabel_MouseDown(object sender, MouseEventArgs e)
		{
			ScanPCLabel.ForeColor = Color.FromArgb(37, 111, 179);
			buttoncolor = Color.LightGray;
		}

		private void GetStartedForm_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}
		
		private void GetStartedForm_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}
	}
}
