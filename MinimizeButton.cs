using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker
{
    class MinimizeButton : Control
    {
        private Color oldbuttoncolor;
        public Color Buttoncolor { get; set; }
        public Color ButtonHoverColor { get; set; }
        public Image icon { get; set; }
        public MinimizeButton()
        {
            Size = new Size(40, 30);
            Buttoncolor = Color.Transparent;
            oldbuttoncolor = Buttoncolor;
            ButtonHoverColor = Color.Silver;
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
            Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            Buttoncolor = oldbuttoncolor;
            Invalidate();
        }
    }
}
