using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcGameChecker.Animation;

namespace PcGameChecker.GraphExtensions
{
	class LeftPanelButton : Control
	{
		private StringFormat SF = new StringFormat();
		private bool MouseEntered;
		private bool MousePressed;
		private bool Widemode;
		private bool _IsSelected;
		public bool IsSelected
		{
			get
			{
				return _IsSelected;
			}
			set
			{
				if (_IsSelected != value) _IsSelected = value;
				Deselect();
			}
		}
		public int TextRectangleTopPadding { get; set; } // this is for unique top padding for text for each LeftPanelButton (in case if some text will be higher than it should be)
		private Color _TextHoverColor;
		public Color TextHoverColor
		{
			get
			{
				return _TextHoverColor;
			}
			set
			{
				if (_TextHoverColor != value) _TextHoverColor = value;
			}
		}
		private Color _TextColor;
		public Color TextColor
		{
			get
			{
				return _TextColor;
			}
			set
			{
				if (_TextColor != value) _TextColor = value;
			}
		}

		private Image _Icon;
		public Image Icon
		{
			get
			{
				return _Icon;
			}
			set
			{
				if (_Icon != value) _Icon = value;
			}
		}
		private Image _HoverIcon;
		public Image HoverIcon
		{
			get
			{
				return _HoverIcon;
			}
			set
			{
				if (_HoverIcon != value) _HoverIcon = value;
			}
		}

		public int MinimalIconTextwidth = 0;

		//public ColorChangeAnimation TextColorAnimation;
		//private int _AnimationDuration;
		//public int AnimationDuration
		//{
		//	get
		//	{
		//		return this._AnimationDuration;
		//	}
		//	set
		//	{
		//		if (_AnimationDuration != value && value >= 100) _AnimationDuration = value;
		//	}
		//}

		////public static LengthChangeAnimation BackRectangleAnimation;
		//ImageChangeAnimation IconAnimation;

		public LeftPanelButton()
		{
			DoubleBuffered = true;
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
			Padding = new Padding(10);
			MinimumSize = new Size(90, 90);
			MaximumSize = new Size(int.MaxValue / 120, 120);
			TextColor = Color.Black;
			TextHoverColor = Color.Gray;
			Cursor = Cursors.Hand;
			MouseEntered = false;
			MousePressed = false;
			Widemode = false;
			TextRectangleTopPadding = Padding.Top;
			SF.Alignment = StringAlignment.Center;
			SF.LineAlignment = StringAlignment.Center;
		}

		public LeftPanelButton(Image icon, string text)
		{
			DoubleBuffered = true;
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
			Padding = new Padding(10);
			MinimumSize = new Size(90, 90);
			MaximumSize = new Size(int.MaxValue / 120, 120);
			Cursor = Cursors.Hand;
			MouseEntered = false;
			MousePressed = false;
			Widemode = false;
			Icon = icon;
			TextColor = ForeColor;
			TextHoverColor = ForeColor;
			Text = text;
			TextRectangleTopPadding = Padding.Top;
			Font = new Font(Parent.Font.FontFamily, 65, GraphicsUnit.Pixel);
			SF.Alignment = StringAlignment.Center;
			SF.LineAlignment = StringAlignment.Center;

		}

		public LeftPanelButton(Image icon, Image hovericon, Color textcolor, Color texthovercolor, string text)
		{
			DoubleBuffered = true;
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
			Padding = new Padding(10);
			MinimumSize = new Size(90, 90);
			MaximumSize = new Size(int.MaxValue / 120, 120);
			Cursor = Cursors.Hand;
			MouseEntered = false;
			MousePressed = false;
			Widemode = false;
			Icon = icon;
			HoverIcon = hovericon;
			TextColor = textcolor;
			TextHoverColor = texthovercolor;
			Text = text;
			TextRectangleTopPadding = Padding.Top;
			Font = new Font(Parent.Font.FontFamily, 65, GraphicsUnit.Pixel);
			SF.Alignment = StringAlignment.Center;
			SF.LineAlignment = StringAlignment.Center;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//if (CurrentTexcolor == Color.Empty) CurrentTexcolor = ForeColor;
			base.OnPaint(e);
			Graphics graph = e.Graphics;
			graph.SmoothingMode = SmoothingMode.HighQuality;
			graph.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

			graph.Clear(BackColor);

			Rectangle controlrect = new Rectangle(0, 0, Width - 1, Height - 1);
			if (IsSelected)
			{
				graph.DrawRectangle(new Pen(Color.White), controlrect);
				graph.FillRectangle(new SolidBrush(Color.White), controlrect);
				MouseEntered = true;
			}
			else
			{
				graph.DrawRectangle(new Pen(Parent.BackColor), controlrect);
				graph.FillRectangle(new SolidBrush(Parent.BackColor), controlrect);
			}
			Rectangle bodyrect = new Rectangle((MousePressed ? 1 : 0) + Padding.Left, (MousePressed ? 1 : 0) + Padding.Top, controlrect.Width - (Padding.Right * 2), controlrect.Height - (Padding.Bottom * 2));
			Rectangle iconrect = new Rectangle(bodyrect.X + (bodyrect.Width - bodyrect.Height) / 2, bodyrect.Y, bodyrect.Height, bodyrect.Height);
			Rectangle textrect = new Rectangle();

			if (Widemode)
			{
				if (bodyrect.Width >= iconrect.Width + graph.MeasureString(Text, Font).Width)
				{
					iconrect = new Rectangle(bodyrect.X, bodyrect.Y, bodyrect.Height, bodyrect.Height);
					textrect = new Rectangle(bodyrect.X + iconrect.Width, (MousePressed ? 1 : 0) + TextRectangleTopPadding, bodyrect.Width - iconrect.Width, bodyrect.Height + Padding.Bottom);
				}
				else
				{
					iconrect = new Rectangle(bodyrect.X + (bodyrect.Width - bodyrect.Height) / 2, bodyrect.Y, bodyrect.Height, bodyrect.Height);
				}
			}
			else
			{
				textrect = new Rectangle();
			}

			if (Icon != null)
			{
				if (HoverIcon != null && MouseEntered)
				{
					graph.DrawImage(HoverIcon, iconrect);
				}
				else
				{
					graph.DrawImage(Icon, iconrect);
				}
			}
			else
			{
				graph.DrawRectangle(new Pen(Color.Red), iconrect);
				graph.FillRectangle(new SolidBrush(Color.Red), iconrect);
			}

			if (!textrect.IsEmpty)
			{
				if (TextHoverColor != Color.Empty && MouseEntered)
				{
					graph.DrawString(this.Text, this.Font, new SolidBrush(TextHoverColor), textrect, SF);
				}
				else graph.DrawString(this.Text, this.Font, new SolidBrush(TextColor), textrect, SF);
			}

			if (MinimalIconTextwidth == 0) MinimalIconTextwidth = Padding.Left + (MaximumSize.Height - Padding.Top - Padding.Bottom) + (int)graph.MeasureString(Text, Font).Width + Padding.Right + 1;
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			if (Program.screenMode == ScreenMode.Small)
			{
				Height = Width;
			}
			else if (Width <= MaximumSize.Height)
			{
				Widemode = false;
				Height = Width;
			}
			else
			{
				Height = MaximumSize.Height;
				Widemode = true;
			}
		}



		private	void Deselect()
		{
			MouseEntered = false;
			MousePressed = false;
			Invalidate();
		}

		/*private void DoChangeColor()
        {
			if (MouseEntered == true)
			{
				TextColorAnimation = new ColorChangeAnimation(Name, this.Invalidate, TextColor, TextHoverColor, 500);
			}
			else
			{
				TextColorAnimation = new ColorChangeAnimation(Name, this.Invalidate, TextColorAnimation.Value, TextColor, TextColorAnimation.ExecutionTime);
			}

			AnimationEngine.Request(TextColorAnimation);
		}*/
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			//BackColor = Color.Gainsboro;
			MouseEntered = true;

			//DoChangeColor();
			Invalidate();
		}
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			//BackColor = Parent.BackColor;
			MouseEntered = false;

			//DoChangeColor();
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

		protected override void OnInvalidated(InvalidateEventArgs e)
		{
			base.OnInvalidated(e);
			//MessageBox.Show("invalideted" + Name);
		}

	}
}