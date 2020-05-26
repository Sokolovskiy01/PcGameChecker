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
	class GameBlockVertical : Control
	{
		public Color Bodycolor { get; set; }
		public Color BorderColor { get; set; }
		private int borderWidth = 5;
		public int BorderWidth
		{
			get => borderWidth;
			set
			{
				if (value <= Height / 2 && value <= Width / 2)
				{
					borderWidth = value;
					Refresh();
				}
			}
		}
		private float rounding = 20;
		public float Rounding
		{
			get => rounding;
			set
			{
				if (value >= 0 && value > borderWidth)
				{
					rounding = value;
					Refresh();
				}
			}
		}

		private bool MouseEntered = false;

		private Image GamePoster;
		private string GameName;
		private StringFormat SF = new StringFormat();
		private int gameid;
		public GameBlockVertical()
		{
			//for test purposes
			Size = new Size(280, 436);
			BorderColor = Color.Gray;
			Bodycolor = Color.White;
			GameName = "Call of Duty: Modern Warfare";
			SF.Alignment = StringAlignment.Center;
			SF.LineAlignment = StringAlignment.Center;
		}
		public GameBlockVertical(Game g, Color bordercolor, Color bodycolor,int id)
		{
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
			DoubleBuffered = true;
			Cursor = Cursors.Hand;
			Size = new Size(280, 436);
			BorderColor = bordercolor;
			Bodycolor = bodycolor;
			BackColor = bodycolor;
			GamePoster = g.Poster;
			GameName = g.Name;
			gameid = id;
			SF.Alignment = StringAlignment.Center;
			SF.LineAlignment = StringAlignment.Center;
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
			base.OnPaint(e);
			Graphics graph = e.Graphics;
			graph.SmoothingMode = SmoothingMode.HighQuality;
			graph.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

			Rectangle borderrect = new Rectangle(0, 0, Width - 1, Height - 1);
			Rectangle bodyrect = new Rectangle(borderWidth, borderWidth, Width - borderWidth * 2 - 1, Height - borderWidth * 2 - 1);
			GraphicsPath borderpath = RoundedRectangle(borderrect, rounding);
			GraphicsPath bodyPath = RoundedRectangle(bodyrect, (rounding - borderWidth) * 0.9F);

			Rectangle GamePosterRect = new Rectangle(borderWidth, borderWidth + 10, 270, 360);
			Rectangle GameNamerect = new Rectangle(Padding.Left, 376 + Padding.Top, 270 - Padding.Right, 60 - Padding.Bottom);

			graph.DrawRectangle(new Pen(Parent.BackColor), borderrect);
			graph.FillRectangle(new SolidBrush(Parent.BackColor), borderrect);

			graph.DrawPath(new Pen(BorderColor), borderpath);
			graph.FillPath(new SolidBrush(BorderColor), borderpath);
			graph.DrawPath(new Pen(Bodycolor), bodyPath);
			graph.FillPath(new SolidBrush(Bodycolor), bodyPath);
			if (GamePoster != null) graph.DrawImage(GamePoster, GamePosterRect);
			else {
				graph.DrawRectangle(new Pen(Color.DarkGray), GamePosterRect);
				graph.FillRectangle(new SolidBrush(Color.DarkGray), GamePosterRect);
			}
			if (ForeColor != Color.FromArgb(225, 225, 225))	graph.DrawString(GameName, Font, new SolidBrush(ForeColor), GameNamerect, SF);
			else graph.DrawString(GameName, Font, new SolidBrush(Color.Black), GameNamerect, SF);

			Rectangle test = new Rectangle(0, 0, Width, Height);
			if (MouseEntered)
			{
				GraphicsPath testpath = RoundedRectangle(test, rounding);
				graph.SetClip(testpath);
				graph.DrawRectangle(new Pen(Color.FromArgb(50, Color.Black)), test);
				graph.FillRectangle(new SolidBrush(Color.FromArgb(50, Color.Black)), test);
				graph.DrawString("Click here for more info", Font, new SolidBrush(Color.FromArgb(225, 225, 225)), test, SF);
			}
		}
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			MouseEntered = true;
			Invalidate();
		}
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			MouseEntered = false;
			Invalidate();
		}
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			Location = new Point(Location.X + 1, Location.Y + 1);
		}
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			Location = new Point(Location.X - 1, Location.Y - 1);
		}
		protected override void OnClick(EventArgs e)
		{
			base.OnClick(e);
			GameInfoForm g = new GameInfoForm(Program.GamesList[gameid], BorderColor);
			g.BackColor = Parent.Parent.Parent.BackColor;
			g.Show();
		}
	}
}
