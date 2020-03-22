using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

namespace PcGameChecker
{
	public partial class Main_Form : Form
	{
		PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
		PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
		Process GpuZ = new Process();
		public bool gpuz_opened = false;
		public Main_Form()
		{
			InitializeComponent();
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
					//if (myProperty.Name == "AdapterRAM") gpu_usage.Text = (Convert.ToInt32(obj.Properties[myProperty.Name].Value) / 1048576).ToString();
					richTextBox1.Text += myProperty.Name + " : " + obj.Properties[myProperty.Name].Value + "\n";
				}
			}
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

		public int getCurrentCpuUsage() { return Convert.ToInt32(cpuCounter.NextValue()); }
		public int getAvailableRAM() { return Convert.ToInt32(ramCounter.NextValue()); }
		private void Form1_Load(object sender, EventArgs e)
		{
			CpuBar.Minimum = 0;
			CpuBar.Maximum = 100;
			RamBar.Minimum = 0;
			RamBar.Maximum = Convert.ToInt32(TotalRam());
			//ram_usage.Text = pccc.NextValue().ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//NvAPIWrapper.Native.GPU.Structures.PhysicalGPUHandle pghu_handler = new NvAPIWrapper.Native.GPU.Structures.PhysicalGPUHandle();
			//NvAPIWrapper.GPU.PhysicalGPU nvgpu = new NvAPIWrapper.GPU.PhysicalGPU(pghu_handler);
			//richTextBox1.Text += nvgpu.FullName.Length.ToString();
			getcpu();
			getgpu();
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

			Device _device = devicesList[0];

			richTextBox1.Text += "Max Clock Frequency: " + Cl.GetDeviceInfo(_device, DeviceInfo.MaxClockFrequency, out error).CastTo<uint>() + "\n";
			richTextBox1.Text += "Memory bus width : " + (Cl.GetDeviceInfo(_device, DeviceInfo.GlobalMemCacheSize, out error).CastTo<long>()).ToString();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			int cpu_usage_val = getCurrentCpuUsage();
			cpu_usage.Text = "CPU Usage : " + cpu_usage_val.ToString() + "%";
			CpuBar.Value = cpu_usage_val;
			int ram_usage_val = Convert.ToInt32(TotalRam()) - getAvailableRAM();
			ram_usage.Text = "RAM Usage : " + ram_usage_val.ToString() + "MB";
			RamBar.Value = ram_usage_val;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var currdir = Directory.GetCurrentDirectory();
			GpuZ.StartInfo = new ProcessStartInfo("GPU-Z.2.30.0.exe");
			GpuZ.StartInfo.WorkingDirectory = currdir;
			//GpuZ.StartInfo.Verb = "runas";
			//GpuZ.StartInfo.CreateNoWindow = true;
			//GpuZ.StartInfo.UseShellExecute = false;
			GpuZ.Start();
			gpuz_opened = true;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			gpuz_opened = false;
			GpuZ.Kill();
		}

		private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (gpuz_opened) GpuZ.Kill();
		}
	}
}