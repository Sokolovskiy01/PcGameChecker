using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker
{
    public partial class AgreementForm : Form
    {
        public AgreementForm()
        {
            InitializeComponent();
        }
		static void SetRoundedShape(Control control, int radius)
		{
			GraphicsPath path = new GraphicsPath();
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
		private static GraphicsPath RoundedRectangle(Rectangle rect, float RoundSize)
		{
			GraphicsPath gp = new GraphicsPath();

			gp.AddArc(rect.X, rect.Y, RoundSize, RoundSize, 180, 90);
			gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y, RoundSize, RoundSize, 270, 90);
			gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 0, 90);
			gp.AddArc(rect.X, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 90, 90);

			gp.CloseFigure();

			return gp;
		}
		private void AgreementForm_Load(object sender, EventArgs e)
        {
			ProceedButton.Font = new Font(Program.Comfortaa.Families[0], ProceedButton.Font.Size);
			CancelButton.Font = new Font(Program.Comfortaa.Families[0], CancelButton.Font.Size);
			AgeementLabel.Font = new Font(Program.Comfortaa.Families[0], AgeementLabel.Font.Size);
			SetRoundedShape(this, 34);
		}

		private void AgreementForm_Paint(object sender, PaintEventArgs e)
		{
			Graphics graph = e.Graphics;
			graph.SmoothingMode = SmoothingMode.AntiAlias;
			Rectangle borderrect = new Rectangle(0, 0, Width - 1, Height - 1);
			Rectangle bodyrect = new Rectangle(6, 6, Width - 13, Height - 13);
			GraphicsPath rectPath = RoundedRectangle(bodyrect, 24);

			graph.FillRectangle(new SolidBrush(Color.Black), borderrect);
			graph.DrawPath(new Pen(Color.White), rectPath);
			graph.FillPath(new SolidBrush(Color.White), rectPath);
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void roundedButton2_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}
	}
}
