using PcGameChecker;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPcGameChecker
{
	class GameBlockHorizontal : Control
	{
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
		public int gameid;
		public string GameName { get; set; }
		private Image gicon;
		private uint metacritics = 0;
		private double userrate = 0.0;
		public string gamec = "null";

		private bool MouseEntered = false;

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
		public GameBlockHorizontal()
		{
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
			DoubleBuffered = true;
			Size = new Size(1100, 65);
		}
		public GameBlockHorizontal(Game g, Color color,int id)
		{
			Cursor = Cursors.Hand;
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
			DoubleBuffered = true;
			Size = new Size(1100, 65);
			gameid = id;
			gicon = g.Icon;
			GameName = g.Name;
			metacritics = g.metacritic;
			userrate = g.user_score;
			if (color == Color.FromArgb(36, 173, 117)) {
				gamec = "Yes";
			}
			if (color == Color.FromArgb(231, 178, 52)) {
				gamec = "Maybe";
			}
			if (color == Color.FromArgb(203, 51, 51)) {
				gamec = "No";
			}
			BorderColor = color;
		}
		private StringFormat SF = new StringFormat();
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

			Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
			GraphicsPath rectPath = RoundedRectangle(rect, rounding);
			Rectangle borderRect = new Rectangle(borderWidth, borderWidth, Width - (borderWidth * 2) - 1, Height - (borderWidth * 2) - 1);
			GraphicsPath borderPath = RoundedRectangle(borderRect, (rounding - borderWidth) / 1.1F);

			graph.DrawPath(new Pen(BorderColor), rectPath);
			graph.FillPath(new SolidBrush(BorderColor), rectPath);

			graph.DrawPath(new Pen(Parent.Parent.Parent.BackColor), borderPath);
			graph.FillPath(new SolidBrush(Parent.Parent.Parent.BackColor), borderPath);

			int margintop = 5;
			int marginbootom = margintop;
			margintop += borderWidth;
			int marginleft = 20;

			Rectangle gameIcon = new Rectangle(marginleft, marginbootom, 60, Height - marginbootom * 2 - 1);
			Rectangle gameName = new Rectangle(marginleft + 61, margintop, 200, Height - marginbootom * 2 - 1);

			Rectangle gameCYRI = new Rectangle(Width - 271 - marginleft, margintop, 270, Height - marginbootom * 2 - 1);
			Rectangle gameUserRate = new Rectangle(Width - marginleft - 512, margintop, 240, Height - marginbootom * 2 - 1);
			Rectangle gameMetacritics = new Rectangle(Width - marginleft - 753, margintop, 240, Height - marginbootom * 2 - 1);

			if (gicon != null) graph.DrawImage(gicon, gameIcon);

			graph.DrawString(GameName, Font, new SolidBrush(Parent.Parent.Parent.ForeColor), gameName, SF);
			graph.DrawString("Can you run it : " + gamec, Font, new SolidBrush(Parent.Parent.Parent.ForeColor), gameCYRI, SF);
			graph.DrawString("User rate : " + userrate.ToString(), Font, new SolidBrush(Parent.Parent.Parent.ForeColor), gameUserRate, SF);
			graph.DrawString("Metacritic : " + metacritics.ToString(), Font, new SolidBrush(Parent.Parent.Parent.ForeColor), gameMetacritics, SF);

			graph.SetClip(rectPath);
			if (MouseEntered)
			{
				graph.DrawRectangle(new Pen(Color.FromArgb(30, Color.Black)), rect);
				graph.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.Black)), rect);
			}
		}
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			Location = new Point(Location.X + 1, Location.Y + 1);
			MouseEntered = true;
		}
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			Location = new Point(Location.X - 1, Location.Y - 1);
			MouseEntered = false;
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