using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker
{
    static class Program
    {
        //public static CurrentMachine CM = new CurrentMachine();
        public static PrivateFontCollection Comfortaa = new PrivateFontCollection();
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();
            Comfortaa.AddFontFile("Resources\\Comfortaa-VariableFont_wght.ttf");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitForm initialization = new InitForm();
            GetStartedForm start = new GetStartedForm();
            FormMain main = new FormMain();
            //Application.Run(new GameADD());
            Application.Run(initialization);
            Application.Run(start);
            Application.Run(main);
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
