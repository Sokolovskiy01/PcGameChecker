using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker.GraphExtensions
{
	class MainPanelHardwareInfo : Control
	{
		public enum PanelMode { List, SmallColumns, BigColumns};
		public PanelMode Mode { get; set; }

		private Font _HardwareFont;
		private Font _OldHardwareFont;
		public Font HardwareFont
		{
			get
			{
				return _HardwareFont;
			}
			set
			{
				if (value != null && HardwareFont != value)
				{
					_OldHardwareFont = value;
					_HardwareFont = value;
				}
			}
		}
		public string MachineName { get; set; }
		public Image CPUIcon { get; set; }
		public string CpuName { get; set; }
		public Image GpuIcon { get; set; }
		public string GpuName { get; set; }
		public Image RamIcon { get; set; }
		public string RamName { get; set; }

		private StringFormat MachineSF = new StringFormat();
		private StringFormat HardwareSF = new StringFormat();

		public MainPanelHardwareInfo()
		{
			DoubleBuffered = true;
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);

			Padding = new Padding(10, 20, 10, 20);
			MinimumSize = new Size(400, 200);

			CpuName = "Unknown";
			GpuName = "Unknown";
			RamName = "Unknown";
			MachineName = "DIMON-PC";

			MachineSF.Alignment = StringAlignment.Center;
			MachineSF.LineAlignment = StringAlignment.Center;

			HardwareSF.Alignment = StringAlignment.Center;
			HardwareSF.LineAlignment = StringAlignment.Center;

			Mode = PanelMode.SmallColumns;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics graph = e.Graphics;
			graph.SmoothingMode = SmoothingMode.HighQuality;
			graph.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

			graph.Clear(BackColor);

			Rectangle Bodyrectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
			Rectangle MacnineNameRectangle = new Rectangle(Padding.Left, Padding.Top, Width - (Padding.Left + Padding.Right), (int)graph.MeasureString(MachineName, Font).Height);
			Rectangle HadrwarListRectangle = new Rectangle(Padding.Left,Padding.Top + MacnineNameRectangle.Height, MacnineNameRectangle.Width,Height - Padding.Top - MacnineNameRectangle.Height  - Padding.Bottom);

			graph.DrawString(MachineName, Font, new SolidBrush(Color.FromArgb(37, 111, 180)), MacnineNameRectangle, MachineSF);

			Rectangle column1; // For CPU info
			Rectangle column2; //For GPU info
			Rectangle column3; // For RAM info

			Rectangle CPUIconRectangle;
			Rectangle GPUIconRectangle;
			Rectangle RAMIconRectangle;

			Rectangle CPUTextRectangle;
			Rectangle GPUTextRectangle;
			Rectangle RAMTextRectangle;


			if (Mode == PanelMode.List)
			{
				int columnheight = HadrwarListRectangle.Height / 3;

				column1 = new Rectangle(HadrwarListRectangle.X, HadrwarListRectangle.Y, HadrwarListRectangle.Width, columnheight);
				column2 = new Rectangle(HadrwarListRectangle.X, HadrwarListRectangle.Y + column1.Height, HadrwarListRectangle.Width, columnheight);
				column3 = new Rectangle(HadrwarListRectangle.X, HadrwarListRectangle.Y + column1.Height + column2.Height, HadrwarListRectangle.Width, columnheight);

				CPUIconRectangle = new Rectangle(column1.X, column1.Y, column1.Height, column1.Height);
				GPUIconRectangle = new Rectangle(column2.X, column2.Y, column2.Height, column2.Height);
				RAMIconRectangle = new Rectangle(column3.X, column3.Y, column3.Height, column3.Height);

				CPUTextRectangle = new Rectangle(column1.X + CPUIconRectangle.Width, column1.Y + 3, column1.Width - CPUIconRectangle.Width, column1.Height);
				GPUTextRectangle = new Rectangle(column2.X + CPUIconRectangle.Width, column2.Y + 3, column2.Width - GPUIconRectangle.Width, column2.Height);
				RAMTextRectangle = new Rectangle(column3.X + CPUIconRectangle.Width, column3.Y + 3, column3.Width - RAMIconRectangle.Width, column3.Height);

				HardwareSF.Alignment = StringAlignment.Near;
				HardwareSF.LineAlignment = StringAlignment.Center;
				_HardwareFont = _OldHardwareFont;

				if (HardwareFont != null)
				{
					while(graph.MeasureString(CpuName,_HardwareFont).Width > CPUTextRectangle.Width
						|| graph.MeasureString(GpuName, _HardwareFont).Width > GPUTextRectangle.Width
						|| graph.MeasureString(RamName, _HardwareFont).Width > RAMTextRectangle.Width)
					{
						_HardwareFont = new Font(Program.Comfortaa.Families[0], _HardwareFont.Size - 1, GraphicsUnit.Pixel);
					}
					graph.DrawString(CpuName, _HardwareFont, new SolidBrush(Color.FromArgb(37, 111, 180)), CPUTextRectangle, HardwareSF);
					graph.DrawString(GpuName, _HardwareFont, new SolidBrush(Color.FromArgb(37, 111, 180)), GPUTextRectangle, HardwareSF);
					graph.DrawString(RamName, _HardwareFont, new SolidBrush(Color.FromArgb(37, 111, 180)), RAMTextRectangle, HardwareSF);
				}
				else
				{
					graph.DrawString(CpuName, Font, new SolidBrush(Color.FromArgb(37, 111, 180)), CPUTextRectangle, HardwareSF);
					graph.DrawString(GpuName, Font, new SolidBrush(Color.FromArgb(37, 111, 180)), GPUTextRectangle, HardwareSF);
					graph.DrawString(RamName, Font, new SolidBrush(Color.FromArgb(37, 111, 180)), RAMTextRectangle, HardwareSF);
				}
			}
			else
			{
				int columnwidth = HadrwarListRectangle.Width / 3;

				column1 = new Rectangle(HadrwarListRectangle.X, HadrwarListRectangle.Y, columnwidth, HadrwarListRectangle.Height);
				column2 = new Rectangle(HadrwarListRectangle.X + column1.Width, HadrwarListRectangle.Y, columnwidth, HadrwarListRectangle.Height);
				column3 = new Rectangle(HadrwarListRectangle.X + column1.Width + column2.Width, HadrwarListRectangle.Y, columnwidth, HadrwarListRectangle.Height);

				HardwareSF.Alignment = StringAlignment.Center;
				HardwareSF.LineAlignment = StringAlignment.Center;
				_HardwareFont = _OldHardwareFont;

				int fontheight = (int)(graph.MeasureString("Tp", _HardwareFont).Height * 2);

				CPUTextRectangle = new Rectangle(column1.X + Padding.Left, column1.Y + column1.Height - fontheight, column1.Width - (Padding.Left + Padding.Right), fontheight);
				GPUTextRectangle = new Rectangle(column2.X + Padding.Left, column2.Y + column2.Height - fontheight, column2.Width - (Padding.Left + Padding.Right), fontheight);
				RAMTextRectangle = new Rectangle(column3.X + Padding.Left, column3.Y + column3.Height - fontheight, column3.Width - (Padding.Left + Padding.Right), fontheight);

				if (HardwareFont != null)
				{
					while (graph.MeasureString(CpuName, _HardwareFont).Width / 1.6 > CPUTextRectangle.Width
						|| graph.MeasureString(GpuName, _HardwareFont).Width / 1.6 > GPUTextRectangle.Width
						|| graph.MeasureString(RamName, _HardwareFont).Width / 1.6 > RAMTextRectangle.Width)
					{
						_HardwareFont = new Font(Program.Comfortaa.Families[0], _HardwareFont.Size - 1, GraphicsUnit.Pixel);
					}
					graph.DrawString(CpuName, _HardwareFont, new SolidBrush(Color.FromArgb(37, 111, 180)), CPUTextRectangle, HardwareSF);
					graph.DrawString(GpuName, _HardwareFont, new SolidBrush(Color.FromArgb(37, 111, 180)), GPUTextRectangle, HardwareSF);
					graph.DrawString(RamName, _HardwareFont, new SolidBrush(Color.FromArgb(37, 111, 180)), RAMTextRectangle, HardwareSF);
				}
				else
				{
					graph.DrawString(CpuName, Font, new SolidBrush(Color.FromArgb(37, 111, 180)), CPUTextRectangle, HardwareSF);
					graph.DrawString(GpuName, Font, new SolidBrush(Color.FromArgb(37, 111, 180)), GPUTextRectangle, HardwareSF);
					graph.DrawString(RamName, Font, new SolidBrush(Color.FromArgb(37, 111, 180)), RAMTextRectangle, HardwareSF);
				}

				int h1 = column1.Height - CPUTextRectangle.Height;
				int x1 = (column1.X + (column1.Width - h1) / 2);

				int h2 = column2.Height - GPUTextRectangle.Height;
				int x2 = (column2.X + (column2.Width - h2) / 2);

				int h3 = column3.Height - RAMTextRectangle.Height;
				int x3 = (column3.X + (column3.Width - h3) / 2);

				CPUIconRectangle = new Rectangle(x1, column1.Y, h1, h1);
				GPUIconRectangle = new Rectangle(x2, column2.Y, h2, h2);
				RAMIconRectangle = new Rectangle(x3, column3.Y, h3, h3);
            }

			if (CPUIcon != null)
			{
				graph.DrawImage(CPUIcon, CPUIconRectangle);
			}
			if (GpuIcon != null)
			{
				graph.DrawImage(GpuIcon, GPUIconRectangle);
			}
			if (RamIcon != null)
			{
				graph.DrawImage(RamIcon, RAMIconRectangle);
			}
        }//end of OnPaint

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			if (this.Size.Width < 800)
			{
				Mode = PanelMode.List;
				Height = (int)(40.0 * Math.Log(Width, 2.4));
			}
			else
			{
				Mode = PanelMode.SmallColumns;
				Height = (int)(40.0 * Math.Log(Width, 2.6));
			}
		}
	}//end of class
}//end of namespace
