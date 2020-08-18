using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker
{
    class SystemInfo
    {
        public string MachineName;
		public string DisplayedOperationSystmName;
        public string OperationSystemName;
        public string OperationSystemArchitecture;
        public long SystemRAM;
		public uint SystemRAMSpeed;
        public GraphicsCard SelectedGPU { get; set; }
        public SystemInfo()
        {
            GetPhysicallyInstalledSystemMemory(out SystemRAM);
            SystemRAM /= 1024;
			ManagementClass myManagementClass = new ManagementClass("Win32_OperatingSystem");
			ManagementObjectCollection myManagementCollection = myManagementClass.GetInstances();
			foreach (var obj in myManagementCollection)
			{
				DisplayedOperationSystmName = obj.Properties["Caption"].Value.ToString();
				string[] Osses = new string[10] { "Windows 10", "Windows 8.1", "Windows 8", "Windows 7", "Windows Vista", "Windows XP", "Windows ME", "Windows 2000", "Windows 98", "Windows 95" };
				for (int i = 0; i < 10; i++)
				{
					if (obj.Properties["Caption"].Value.ToString().Contains(Osses[i]))
					{
						OperationSystemName = Osses[i];
						break;
					}
					if (i == 9) MessageBox.Show("No OS detected");
				}
				MachineName = obj.Properties["CSName"].Value.ToString();
				if (obj.Properties["OSArchitecture"].Value.ToString().Contains("64")) OperationSystemArchitecture = "64";
				if (obj.Properties["OSArchitecture"].Value.ToString().Contains("32")) OperationSystemArchitecture = "32";
			}
			myManagementClass = new ManagementClass("Win32_PhysicalMemory");
			myManagementCollection = myManagementClass.GetInstances();
			foreach (var obj in myManagementCollection)
			{
				SystemRAMSpeed = Convert.ToUInt32(obj.Properties["Speed"].Value);
			}
		}
        public override string ToString()
        {
			return "PC Name : " + MachineName +
				"\nOperation system : " + DisplayedOperationSystmName +
				"\nArchitecture : " + OperationSystemArchitecture + " bit" +
				"\nInstalled RAM : " + SystemRAM.ToString() + " MB" +
				"\nRAM speed : " + SystemRAMSpeed.ToString() + " MHz";
        }
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetPhysicallyInstalledSystemMemory(out long TotalMemoryInKilobytes);
    }
}
