using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Runtime.InteropServices;
using Topshelf.Runtime.Windows;

namespace PcGameChecker
{
	static class Program
	{
		public const int SW_HIDE = 0;
		public const int SW_SHOWNORMAL = 1;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		[DllImport("User32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
		public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Main_Form());
		}
	}
}