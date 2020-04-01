using OpenCL.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker
{
	public partial class ScanForm : Form
	{
		private CurrentMachine cm = new CurrentMachine();
		public ScanForm()
		{
			InitializeComponent();
		}
		private void getOS()
		{
			ScanTextLabel.Text = "Scanning OS Specs...";
			ManagementClass myManagementClass = new ManagementClass("Win32_OperatingSystem");
			ManagementObjectCollection myManagementCollection = myManagementClass.GetInstances();

			foreach (var obj in myManagementCollection)
			{
				foreach (var myProperty in myManagementClass.Properties)
				{
					if (myProperty.Name == "Caption") cm.SystemOS = obj.Properties[myProperty.Name].Value.ToString();
					if (myProperty.Name == "Description") cm.SystemName = obj.Properties[myProperty.Name].Value.ToString();
					if (myProperty.Name == "OSArchitecture") cm.SystemArchitecture = obj.Properties[myProperty.Name].Value.ToString();
				}
			}
			Progressbar.Value += 30;
		}
		private uint TotalRam()
		{
			ScanTextLabel.Text = "Scanning RAM...";
			ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT MaxCapacity FROM Win32_PhysicalMemoryArray");
			uint Ramsize = 0;
			foreach (ManagementObject WniPART in searcher.Get())
			{
				Ramsize = Convert.ToUInt32(WniPART.Properties["MaxCapacity"].Value) / 1024; //Display in MB
			}
			Progressbar.Value += 5;
			return Ramsize / 4;
		}
		private void getcpu()
		{
			ScanTextLabel.Text = "Scanning CPU...";
			ManagementClass myManagementClass = new ManagementClass("Win32_Processor");
			ManagementObjectCollection myManagementCollection = myManagementClass.GetInstances();

			foreach (var obj in myManagementCollection)
			{
				foreach (var myProperty in myManagementClass.Properties)
				{
					if (myProperty.Name == "Name") cm.Processor.Name = obj.Properties[myProperty.Name].Value.ToString();
					if (myProperty.Name == "NumberOfCores") cm.Processor.NumberOfCores = Convert.ToUInt32(obj.Properties[myProperty.Name].Value);
					if (myProperty.Name == "ThreadCount") cm.Processor.ThreadCount = Convert.ToUInt32(obj.Properties[myProperty.Name].Value);
					if (myProperty.Name == "MaxClockSpeed") cm.Processor.ThreadCount = Convert.ToUInt32(obj.Properties[myProperty.Name].Value);
				}
			}
			Progressbar.Value += 30;
		}
		private void getgpu()
		{
			ScanTextLabel.Text = "Scanning GPU specs...";
			ManagementClass mc = new ManagementClass("Win32_VideoController");
			ManagementObjectCollection moc = mc.GetInstances();
			foreach (var obj in moc)
			{
				//richTextBox1.Text += "..............................................\n";
				foreach (var myProperty in mc.Properties)
				{
					if (myProperty.Name == "Caption") cm.GraphicsCard.Name = obj.Properties[myProperty.Name].Value.ToString();
					if (myProperty.Name == "AdapterRAM") cm.GraphicsCard.Vram = Convert.ToUInt64(obj.Properties[myProperty.Name].Value) / 1048576;
					if (myProperty.Name == "CurrentRefreshRate") cm.GraphicsCard.CurrentRefreshRate = Convert.ToUInt32(obj.Properties[myProperty.Name].Value);
					if (myProperty.Name == "CurrentHorizontalResolution") cm.GraphicsCard.CurrentHorizontalResolution = Convert.ToUInt32(obj.Properties[myProperty.Name].Value);
					if (myProperty.Name == "CurrentVerticalResolution") cm.GraphicsCard.CurrentVerticalResolution = Convert.ToUInt32(obj.Properties[myProperty.Name].Value);
				}
			}
			Progressbar.Value += 20;
			ErrorCode error;
			Platform[] platforms = Cl.GetPlatformIDs(out error);
			List<Device> devicesList = new List<Device>();
			foreach (Platform platform in platforms)
			{
				string platformName = Cl.GetPlatformInfo(platform, PlatformInfo.Name, out error).ToString();
				Console.WriteLine("Platform: " + platformName);

				foreach (Device device in Cl.GetDeviceIDs(platform, DeviceType.Gpu, out error))
				{
					devicesList.Add(device);
				}
			}

			foreach (var vdev in devicesList)
			{
				cm.GraphicsCard.MaxClockFrequency = Cl.GetDeviceInfo(vdev, DeviceInfo.MaxClockFrequency, out error).CastTo<uint>();
			}
			Progressbar.Value += 5;
			
		}
		private void ScanForm_Load(object sender, EventArgs e)
		{
			Program_title.Font = new Font(Program.Comfortaa.Families[0], Program_title.Font.Size);
			ScanTextLabel.Font = new Font(Program.Comfortaa.Families[0], ScanTextLabel.Font.Size);
		}

		private void timerload_Tick(object sender, EventArgs e)
		{
			getOS(); // 40
			Progressbar.Update();
			cm.RamCapacity = TotalRam(); // 45
			Progressbar.Update();
			getcpu(); // 75
			Progressbar.Update();
			getgpu(); // 100
			Progressbar.Update();
			ScanTextLabel.Text = "Done";
			ButtonContinue.Visible = true;
			Progressbar.Visible = false;
			timerload.Enabled = false;
		}

		private void ScanForm_Shown(object sender, EventArgs e)
		{
			this.Opacity = 100;
			timerload.Enabled = true;
		}

		private void ButtonContinue_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
