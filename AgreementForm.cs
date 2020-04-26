using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker
{

	public partial class AgreementForm : Form
	{
		Color BorderMainColor = new Color();
		Color PanelMainColor = new Color();
		Color ButtonCancelBorderColor = new Color();
		Color ButtonCancelColor = new Color();
		Color ButtonProceedBorderColor = new Color();
		Color ButtonProceedColor = new Color();
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
			BorderMainColor = Color.Black;
			PanelMainColor = Color.White;
			ButtonCancelBorderColor = Color.FromArgb(37, 111, 180);
			ButtonCancelColor = Color.White;
			ButtonProceedBorderColor = Color.FromArgb(37, 111, 180);
			ButtonProceedColor = Color.White;

			CancelLabel.ForeColor = Color.FromArgb(37, 111, 180);
			ProceedLabel.ForeColor = Color.FromArgb(37, 111, 180);

			CancelLabel.Font = new Font(Program.Comfortaa.Families[0], CancelLabel.Font.Size);
			ProceedLabel.Font = new Font(Program.Comfortaa.Families[0], ProceedLabel.Font.Size);
			AgeementLabel.Font = new Font(Program.Comfortaa.Families[0], AgeementLabel.Font.Size);
			SetRoundedShape(this, 24);
		}
		static void SetRoundedShape(Control control, int radius)
		{
			System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
			path.AddLine(radius, 0, control.Width - radius, 0);
			path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
			path.AddLine(control.Width, radius, control.Width, control.Height - radius);
			path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
			path.AddLine(control.Width - radius, control.Height, radius, control.Height);
			path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
			path.AddLine(0, control.Height - radius, 0, radius);
			path.AddArc(0, 0, radius, radius, 180, 90);
			control.Region = new Region(path);
		}
		private void PaintMiain_OnPaint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.SmoothingMode = SmoothingMode.AntiAlias;
			//g.FillRoundedRectangle(new SolidBrush(BorderMainColor), 0, 0, MainPanel.Width - 1, MainPanel.Height - 1, 12);
			g.FillRoundedRectangle(new SolidBrush(PanelMainColor), 4, 4, MainPanel.Width - 9, MainPanel.Height - 9, 9);
		}
		private void PanelCancel_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.SmoothingMode = SmoothingMode.AntiAlias;
			g.FillRoundedRectangle(new SolidBrush(ButtonCancelBorderColor), 0, 0, PanelCancel.Width - 1, PanelCancel.Height - 1, 8);
			g.FillRoundedRectangle(new SolidBrush(ButtonCancelColor), 2, 2, PanelCancel.Width - 5, PanelCancel.Height - 5, 7);
		}
		private void CancelLabel_MouseMove(object sender, MouseEventArgs e)
		{
			CancelLabel.ForeColor = Color.FromArgb(204, 51, 51);
			ButtonCancelBorderColor = Color.FromArgb(204, 51, 51);
		}
		private void CancelLabel_MouseDown(object sender, MouseEventArgs e)
		{
			CancelLabel.ForeColor = Color.FromArgb(203, 51, 51);
			ButtonCancelColor = Color.LightGray;
		}
		private void CancelLabel_MouseLeave(object sender, EventArgs e)
		{
			CancelLabel.ForeColor = Color.FromArgb(37, 111, 180);
			ButtonCancelBorderColor = Color.FromArgb(37, 111, 180);
			ButtonCancelColor = Color.White;
		}

		private void PanelProceed_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.SmoothingMode = SmoothingMode.AntiAlias;
			g.FillRoundedRectangle(new SolidBrush(ButtonProceedBorderColor), 0, 0, PanelProceed.Width - 1, PanelProceed.Height - 1, 8);
			g.FillRoundedRectangle(new SolidBrush(ButtonProceedColor), 2, 2, PanelProceed.Width - 5, PanelProceed.Height - 5, 7);
		}
		private void PanelProceed_MouseMove(object sender, MouseEventArgs e)
		{
			ProceedLabel.ForeColor = Color.FromArgb(36, 173, 117);
			ButtonProceedBorderColor = Color.FromArgb(36, 173, 117);
		}
		private void PanelProceed_MouseDown(object sender, MouseEventArgs e)
		{
			ProceedLabel.ForeColor = Color.FromArgb(36, 172, 117);
			ButtonProceedColor = Color.LightGray;
		}
		private void PanelProceed_MouseLeave(object sender, EventArgs e)
		{
			ProceedLabel.ForeColor = Color.FromArgb(37, 111, 180);
			ButtonProceedBorderColor = Color.FromArgb(37, 111, 180);
			ButtonProceedColor = Color.White;
		}
	}
}
