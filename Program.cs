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
        public static PrivateFontCollection Comfortaa = new PrivateFontCollection();
        public static CurrentMachine ThisPC = new CurrentMachine();
        public static List<Game> GamesList;
        public static bool cpuPerf = true;
        public static bool IsFirstRun = true;
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();
            Comfortaa.AddFontFile("Resources\\Comfortaa-VariableFont_wght.ttf");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InitForm());
            if (IsFirstRun) {
                Application.Run(new GetStartedForm());
                Application.Run(new ScanForm());
            }
            Application.Run(new FormMain());
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
