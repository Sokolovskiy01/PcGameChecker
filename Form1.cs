using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Data.Entity.Core.Objects;
using OpenCL.Net;
using System.IO;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace PcGameChecker
{
	public partial class Main_Form : Form
	{
		public PrivateFontCollection pfc = new PrivateFontCollection();
		public Main_Form()
		{
			InitializeComponent();
		}
		public void getOS()
		{
			ManagementClass myManagementClass = new ManagementClass("Win32_OperatingSystem");
			ManagementObjectCollection myManagementCollection = myManagementClass.GetInstances();
			//PropertyDataCollection myProperties = myManagementClass.Properties;

			foreach (var obj in myManagementCollection)
			{
				foreach (var myProperty in myManagementClass.Properties)
				{
					//myPropertyResults.Add(myProperty.Name,obj.Properties[myProperty.Name].Value);
					richTextBox1.Text += myProperty.Name + " : " + obj.Properties[myProperty.Name].Value + "\n";
				}
			}
		}
		public void getcpu()
		{
			ManagementClass myManagementClass = new ManagementClass("Win32_Processor");
			ManagementObjectCollection myManagementCollection = myManagementClass.GetInstances();
			//PropertyDataCollection myProperties = myManagementClass.Properties;

			foreach (var obj in myManagementCollection)
			{
				foreach (var myProperty in myManagementClass.Properties)
				{
					//myPropertyResults.Add(myProperty.Name,obj.Properties[myProperty.Name].Value);
					if (myProperty.Name == "Name") Sys_proc_name.Text = obj.Properties[myProperty.Name].Value.ToString();
					if (myProperty.Name == "SystemName") Comp_name.Text = obj.Properties[myProperty.Name].Value.ToString();
					richTextBox1.Text += myProperty.Name + " : " + obj.Properties[myProperty.Name].Value + "\n";
				}
			}
		}
		public void getgpu()
		{
			ManagementClass mc = new ManagementClass("Win32_VideoController");
			ManagementObjectCollection moc = mc.GetInstances();
			foreach (var obj in moc)
			{
				richTextBox1.Text += "..............................................\n";
				foreach (var myProperty in mc.Properties)
				{
					if (myProperty.Name == "AdapterRAM") gpu_usage.Text = "Total VRAM : " + (Convert.ToInt64(obj.Properties[myProperty.Name].Value) / 1048576).ToString() + " MB";
					richTextBox1.Text += myProperty.Name + " : " + obj.Properties[myProperty.Name].Value + "\n";
				}
			}
		}
		private void getCM()
		{
			richTextBox1.Text += "System name : " + Program.CM.SystemName + "\n";
			richTextBox1.Text += "Ram : " + Program.CM.RamCapacity.ToString() +"\n";
			richTextBox1.Text += "Operation system : " + Program.CM.SystemOS + "\n";
			richTextBox1.Text += "System architecture : " + Program.CM.SystemArchitecture + "\n";
			richTextBox1.Text += "Processor --------- \n" + "Name : " + Program.CM.Processor.Name + "\n";
			richTextBox1.Text += "Number of cores : " + Program.CM.Processor.NumberOfCores.ToString() + "\n";
			richTextBox1.Text += "Number of threads : " + Program.CM.Processor.ThreadCount.ToString() + "\n";
			richTextBox1.Text += "Max clock speed : " + Program.CM.Processor.MaxClockSpeed.ToString() + "\n";
			richTextBox1.Text += "Graphics card ---------- \n" + "Name : " + Program.CM.GraphicsCard.Name + "\n";
			richTextBox1.Text += "Vram : " + Program.CM.GraphicsCard.Vram.ToString() + "\n";
			richTextBox1.Text += "Max clock frequency : " + Program.CM.GraphicsCard.MaxClockFrequency.ToString() + "\n";
		}
		public uint TotalRam()
		{
			ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT MaxCapacity FROM Win32_PhysicalMemoryArray");
			uint Ramsize = 0;
			foreach (ManagementObject WniPART in searcher.Get()) {
				Ramsize = Convert.ToUInt32(WniPART.Properties["MaxCapacity"].Value) / 1024; //Display in MB
			}
			return Ramsize / 4;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			getCM();
			Sys_total_ram.Text = "Total RAM : " + TotalRam().ToString() + "MB";
			BringToFront();
			SendToBack();
			CpuBar.Minimum = 0;
			CpuBar.Maximum = 100;
			RamBar.Minimum = 0;
			RamBar.Maximum = Convert.ToInt32(TotalRam());
			Comp_name.Font = new Font(Program.Comfortaa.Families[0], Comp_name.Font.Size);

			//ram_usage.Text = pccc.NextValue().ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//NvAPIWrapper.Native.GPU.Structures.PhysicalGPUHandle pghu_handler = new NvAPIWrapper.Native.GPU.Structures.PhysicalGPUHandle();
			//NvAPIWrapper.GPU.PhysicalGPU nvgpu = new NvAPIWrapper.GPU.PhysicalGPU(pghu_handler);
			//richTextBox1.Text += nvgpu.FullName.Length.ToString();
			richTextBox1.Text = "";
			getcpu();
			getgpu();
			getOS();
			double a = 0;
			DriveInfo[] allDrives = DriveInfo.GetDrives();
			foreach (DriveInfo MyDriveInfo in allDrives)
			{
				if (MyDriveInfo.IsReady == true)
				{
					a = (MyDriveInfo.AvailableFreeSpace / 1024) / 1024 / 1024;
					richTextBox1.Text += MyDriveInfo.Name + " : " + a.ToString("#.##") + " GB avilable\n";
				}
			}
			ErrorCode error;
			Platform[] platforms = Cl.GetPlatformIDs(out error);
			List<Device> devicesList = new List<Device>();
			foreach (Platform platform in platforms)
			{
				string platformName = Cl.GetPlatformInfo(platform, PlatformInfo.Name, out error).ToString();
				Console.WriteLine("Platform: " + platformName);
				//CheckErr(error, "Cl.GetPlatformInfo");

				//We will be looking only for GPU devices in Release mode

				//foreach (Device device in Cl.Cl.GetDeviceIDs(platform, DeviceType.Cpu, out error))

				foreach (Device device in Cl.GetDeviceIDs(platform, DeviceType.Gpu, out error))
				{
					//CheckErr(error, "Cl.GetDeviceIDs");
					//richTextBox1.Text += "Device: " + device.ToString();
					devicesList.Add(device);
				}
			}

			foreach (var vdev in devicesList)
			{
				richTextBox1.Text += "Max Clock Frequency: " + Cl.GetDeviceInfo(vdev, DeviceInfo.MaxClockFrequency, out error).CastTo<uint>() + "\n";
				//richTextBox1.Text += "Memory bus width : " + (Cl.GetDeviceInfo(vdev, DeviceInfo.GlobalMemCacheSize, out error).CastTo<long>()).ToString();
			}
			Device _device = devicesList[0];

			//richTextBox1.Text += "Max Clock Frequency: " + Cl.GetDeviceInfo(_device, DeviceInfo.MaxClockFrequency, out error).CastTo<uint>() + "\n";
			//richTextBox1.Text += "Memory bus width : " + (Cl.GetDeviceInfo(_device, DeviceInfo.GlobalMemCacheSize, out error).CastTo<long>()).ToString();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			uint ram_total = TotalRam();
			int cpu_usage_val = Convert.ToInt32(CPU_perf.NextValue());
			int ram_usage_val = Convert.ToInt32(ram_total - RAM_perf.NextValue());
			cpu_usage.Text = "CPU Usage : " + cpu_usage_val.ToString() + "%";
			CpuBar.Value = cpu_usage_val;
			ram_usage.Text = "RAM Usage : " + ram_usage_val.ToString() + "MB";
			RamBar.Value = ram_usage_val;
		}

		private void RamBar_MouseHover(object sender, EventArgs e)
		{
			
		}
	}
}