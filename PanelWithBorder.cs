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
	class PanelWithBorder : Panel
	{
		public Color BorderColor { get; set; }
		public Color BackgroundColor { get; set; }
		public bool BorderTop { get; set; }
		public bool BorderBottom { get; set; }
		public bool BorderLeft { get; set; }
		public bool BorderRight { get; set; }
		private int borderwidth = 5;
		public int BorderWidth
		{
			get => borderwidth;
			set
			{
				if (value <= Width && value <= Height)
				{
					borderwidth = value;
				}
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics graph = e.Graphics;
			int marginleft = 0;
			if (BorderLeft) marginleft = borderwidth;
			int marginright = 0;
			if (BorderRight)
			{
				if (BorderLeft) marginright = borderwidth * 2;
				else marginright = borderwidth;
			}
			int margintop = 0;
			if (BorderTop) margintop = borderwidth;
			int marginbottom = 0;
			if (BorderBottom)
			{
				if (BorderTop) marginbottom = borderwidth * 2;
				else marginbottom = borderwidth;
			}
			Rectangle BorderRect = new Rectangle(0, 0, Width - 1, Height - 1);
			Rectangle BodyRect = new Rectangle(marginleft, margintop, Width - 1 - marginright, Height - 1 - marginbottom);

			graph.DrawRectangle(new Pen(BorderColor), BorderRect);
			graph.FillRectangle(new SolidBrush(BorderColor), BorderRect);

			graph.DrawRectangle(new Pen(BackgroundColor), BodyRect);
			graph.FillRectangle(new SolidBrush(BackgroundColor), BodyRect);
		}
	}
}
