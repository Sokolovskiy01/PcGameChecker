using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Runtime.InteropServices;
using Topshelf.Runtime.Windows;
using System.Drawing.Text;

namespace PcGameChecker
{
	static class Program
	{
		public static CurrentMachine CM = new CurrentMachine();
		public static PrivateFontCollection Comfortaa = new PrivateFontCollection();
		public static int mode { get; set; }
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			mode = 1;
			Comfortaa.AddFontFile("Resources\\Comfortaa-VariableFont_wght.ttf");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Initialization_form());
			switch (mode)
			{
				case 2:
					Application.Run(new GameADD());
					break;
				default:
					Application.Run(new GetStartedForm());
					Application.Run(new ScanForm());
					Application.Run(new Main_Form());
					break;
			}
			//Application.Run(new GetStartedForm());
			//Application.Run(new Main_Form());
		}
	}
}