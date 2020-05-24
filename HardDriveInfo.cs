using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker
{
	class HardDriveInfo : Control
	{
		private string DiskName;
		private string DiskSpace;
		private StringFormat SF = new StringFormat();
		private Color BodyColor;
		private bool IsDarkMode;
		public HardDriveInfo()
		{
			Size = new Size(160, 64);
			Padding = new Padding(2, 2, 0, 0);
			DiskName = "C:\\";
			DiskSpace = "1212 GB";
		}
		public HardDriveInfo(string name, string space)
		{
			Size = new Size(160, 64);
			Padding = new Padding(2, 2, 0, 0);
			DiskName = name;
			DiskSpace = space;
			BodyColor = Color.White;
		}
		public HardDriveInfo(string name,string space, bool isdarkmode)
		{
			Size = new Size(160, 64);
			Padding = new Padding(2, 2, 0, 0);
			DiskName = name;
			DiskSpace = space;
			IsDarkMode = isdarkmode;
			if (isdarkmode)
			{
				BodyColor = Color.FromArgb(225, 225, 225);
			}
			else BodyColor = Color.White;
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
		protected override void OnPaint(PaintEventArgs e)
		{
			SF.Alignment = StringAlignment.Center;
			SF.LineAlignment = StringAlignment.Center;
			base.OnPaint(e);
			Graphics graph = e.Graphics;
			graph.SmoothingMode = SmoothingMode.HighQuality;
			graph.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

			if (IsDarkMode) {
				Rectangle test = new Rectangle(0, 0, Width, Height);
				graph.DrawRectangle(new Pen(Color.FromArgb(40,40,40)), test);
				graph.FillRectangle(new SolidBrush(Color.FromArgb(40, 40, 40)), test);
			}

			Rectangle borderrect = new Rectangle(0, 0, Width - 1, Height - 1);
			Rectangle rect = new Rectangle(2, 2, Width - 5, Height - 5);
			GraphicsPath borderrectPath = RoundedRectangle(borderrect, 18);
			GraphicsPath rectPath = RoundedRectangle(rect, 15);

			Rectangle diskpicture = new Rectangle(5, 0, 64, 64);
			Rectangle diskname = new Rectangle(Padding.Left + 5, Padding.Top, 64 - Padding.Right + 5, 64 - Padding.Bottom);
			Rectangle diskspace = new Rectangle(64 + Padding.Left + 2, Padding.Top, 96 - Padding.Right, 64 - Padding.Bottom);

			graph.DrawPath(new Pen(Color.Black), borderrectPath);
			graph.FillPath(new SolidBrush(Color.Black), borderrectPath);
			graph.DrawPath(new Pen(BodyColor), rectPath);
			graph.FillPath(new SolidBrush(BodyColor), rectPath);
			graph.DrawImage(Properties.Resources.Drive, diskpicture);
			graph.DrawString(DiskName, Font, new SolidBrush(Color.Black), diskname, SF);
			graph.DrawString(DiskSpace, Font, new SolidBrush(Color.Black), diskspace, SF);
		}
	}
}
