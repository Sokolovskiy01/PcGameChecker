using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker.GraphExtensions
{
    class MainPanelHardwareInfo : Control
    {

        Image CPUIcon;
        public string CpuName { get; set; }
        Image GpuIcon;
        public string GpuName { get; set; }
        Image RamIcon;
        public string RamName { get; set; }

        public string MachineName { get; set; }

        MainPanelHardwareInfo()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);

            Padding = new Padding(10, 20, 10, 20);
            MinimumSize = new Size(400, 200);

            CpuName = "Unknown";
            GpuName = "Unknown";
            RamName = "Unknown";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            Rectangle Bodyrectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            Rectangle MacnineNameRectangle = new Rectangle(Padding.Left, Padding.Top, 100, Height - (Padding.Left + Padding.Right));

        }
    }
}
