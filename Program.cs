using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcGameChecker;

namespace PcGameChecker
{
	public enum ScreenMode { Normal, Small, Large1, Large2, Ultrawide };
	static class Program
	{
		public static PrivateFontCollection Comfortaa = new PrivateFontCollection();
		public static Processor Processor;
		public static List<GraphicsCard> GraphicsCards = new List<GraphicsCard>();
		public static SystemInfo SystemInfo;
		public static ScreenMode screenMode;
		public static int AnimationInterval = 15;
		// TODO: animation Interval by screen refresh rate;

		/// <summary>
		/// Główny punkt wejścia dla aplikacji.
		/// </summary>
		[STAThread]
		static void Main()
		{
			if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new DBEditForm());
			LoadFont();
			Application.Run(new MainForm());
			//Application.Run(new Form1());
		}

		private static void LoadFont()
        {
			Comfortaa.AddFontFile("Comfortaa-VariableFont_wght.ttf");
		}

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();
	}
}
