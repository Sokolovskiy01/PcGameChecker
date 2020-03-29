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
		public static PrivateFontCollection Comfortaa = new PrivateFontCollection();
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Comfortaa.AddFontFile("Resources\\Comfortaa-VariableFont_wght.ttf");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Initialization_form());
			Application.Run(new GetStartedForm());
			Application.Run(new Main_Form());
		}
	}
}