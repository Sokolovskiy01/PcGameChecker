using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker
{
	public class RoundedButton : Control
	{
		public Color FontColor { get; set; }
		public Color HoverFontColor { get; set; }
		public Color BorderColor { get; set; }
		public Color HoverBorderColor { get; set; }
		public Color ButtonColor { get; set; }
		public Color HoverButtonColor { get; set; }
		private int borderWidth = 1;
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
		private StringFormat SF = new StringFormat();
		private bool MouseEntered = false;
		private bool MousePressed = false;
		public RoundedButton()
		{
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
			DoubleBuffered = true;
			Size = new Size(120, 30);

			BorderColor = Color.Empty;
			ButtonColor = Color.Green;
			FontColor = Color.Empty;

			HoverBorderColor = Color.Gray;
			HoverButtonColor = this.BackColor;
			HoverFontColor = Color.Gray;

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

			graph.Clear(Parent.BackColor);

			Rectangle testrect = new Rectangle(0, 0, Width - 1, Height - 1);
			graph.DrawRectangle(new Pen(BackColor), testrect);
			graph.FillRectangle(new SolidBrush(BackColor), testrect);

			Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
			Rectangle textrect = new Rectangle(Padding.Left, Padding.Top, Width - Padding.Bottom - 1, Height - Padding.Right - 1);
			GraphicsPath rectPath = RoundedRectangle(rect, rounding);

			if (BorderColor != Color.Empty)
			{
				Rectangle borderRect = new Rectangle(borderWidth, borderWidth, Width - (borderWidth * 2) - 1, Height - (borderWidth * 2) - 1);
				GraphicsPath borderPath = RoundedRectangle(borderRect, (rounding - borderWidth) * 0.9F);
				if (MouseEntered)
				{
					graph.DrawPath(new Pen(HoverBorderColor), rectPath);
					graph.FillPath(new SolidBrush(HoverBorderColor), rectPath);
					graph.DrawPath(new Pen(HoverButtonColor), borderPath);
					graph.FillPath(new SolidBrush(HoverButtonColor), borderPath);
					graph.DrawString(Text, Font, new SolidBrush(HoverFontColor), textrect, SF);
				}
				else
				{
					graph.DrawPath(new Pen(BorderColor), rectPath);
					graph.FillPath(new SolidBrush(BorderColor), rectPath);
					graph.DrawPath(new Pen(ButtonColor), borderPath);
					graph.FillPath(new SolidBrush(ButtonColor), borderPath);
					graph.DrawString(Text, Font, new SolidBrush(FontColor), textrect, SF);
				}

			}
			else
			{
				graph.DrawPath(new Pen(ButtonColor), rectPath);
				graph.FillPath(new SolidBrush(ButtonColor), rectPath);
				graph.DrawString(Text, Font, new SolidBrush(FontColor), textrect, SF);
			}
			graph.SetClip(rectPath);
			if (MousePressed)
			{
				graph.DrawRectangle(new Pen(Color.FromArgb(70, Color.Black)), rect);
				graph.FillRectangle(new SolidBrush(Color.FromArgb(70, Color.Black)), rect);
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
			MousePressed = true;
			Invalidate();
		}
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			MousePressed = false;
			Invalidate();
		}
	}

}