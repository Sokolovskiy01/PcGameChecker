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

namespace PcGameChecker
{
	public partial class Form1 : Form
	{
		public Form1()
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
			uint corecount = 0;
			foreach (var item in new System.Management.ManagementObjectSearcher("Select NumberOfCores from Win32_Processor").Get()){
				corecount += uint.Parse(item["NumberOfCores"].ToString());
			}
			return Ramsize / corecount;
		}

		PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
		PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
		public int getCurrentCpuUsage()
		{
			return Convert.ToInt32(cpuCounter.NextValue());
		}
		public int getAvailableRAM()
		{
			return Convert.ToInt32(ramCounter.NextValue());
		}
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
			getcpu();
		}

		private void label1_Click(object sender, EventArgs e)
		{

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
	}
}