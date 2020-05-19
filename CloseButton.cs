using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker
{
    class CloseButton : Control
    {
        private Color oldbuttoncolor;
        public Color Buttoncolor { get; set; }
        public Color ButtonHoverColor { get; set; }
        private Image iconold;
        public Image icon { get; set; }
        public Image icon2 { get; set; }
        public CloseButton()
        {
            Size = new Size(40, 30);
            Buttoncolor = Color.Transparent;
            oldbuttoncolor = Buttoncolor;
            ButtonHoverColor = Color.Red;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

            graph.DrawRectangle(new Pen(Buttoncolor), rect);
            graph.FillRectangle(new SolidBrush(Buttoncolor), rect);
            if (icon != null) graph.DrawImage(icon, rect);
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Buttoncolor = ButtonHoverColor;
            iconold = icon;
            if (icon2 != null) icon = icon2;
            Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            Buttoncolor = oldbuttoncolor;
            icon = iconold;
            Invalidate();
        }
    }
}
