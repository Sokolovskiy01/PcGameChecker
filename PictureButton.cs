using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker
{
	class PictureButton : Control
	{
		private Image pictureold;
		public bool IsActive;
		public Image Picture1 { get; set; }
		public Image Picture2 { get; set; }
		public PictureButton()
		{
			IsActive = false;
			Size = new Size(100, 100);
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics graph = e.Graphics;
			Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
			if (Picture1 != null)
			{
				if (IsActive && Picture2 != null)
				{
					graph.DrawImage(Picture2, rect);
				}
				else graph.DrawImage(Picture1, rect);
			}
		}
		protected override void OnMouseEnter(EventArgs e)
		{
			if (Picture2 != null)
			{
				pictureold = Picture1;
				Picture1 = Picture2;
			}
			Invalidate();
		}
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			if (Picture2 != null)
			{
				Picture1 = pictureold;
			}
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
	}
}
