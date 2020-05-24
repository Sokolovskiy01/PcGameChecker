using OpenCL.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker
{
	public partial class ScanForm : Form
	{
		public ScanForm()
		{
			InitializeComponent();
		}
		private void CurrentMachineDefaultSettings()
		{
			Program.ThisPC.IsDarkModeEnabled = false;
			Program.ThisPC.CYRIYesDisplay = true;
			Program.ThisPC.CYRIMaybeDisplay = true;
			Program.ThisPC.CYRINoDisplay = true;
			Program.ThisPC.Forecolor = Color.Black;
		}
		private void getOS()
		{
			InitLabel.Text = "Scanning OS Specs...";
			ManagementClass myManagementClass = new ManagementClass("Win32_OperatingSystem");
			ManagementObjectCollection myManagementCollection = myManagementClass.GetInstances();

			foreach (var obj in myManagementCollection)
			{
				foreach (var myProperty in myManagementClass.Properties)
				{
					if (myProperty.Name == "Caption")
					{
						string[] Osses = new string[10] { "Windows 10", "Windows 8.1", "Windows 8", "Windows 7", "Windows Vista", "Windows XP", "Windows ME", "Windows 2000", "Windows 98", "Windows 95" };
						for (int i = 0; i < 10; i++) {
							if (obj.Properties[myProperty.Name].Value.ToString().Contains(Osses[i])) {
								Program.ThisPC.SystemOS = Osses[i];
								break;
							}
							if (i == 9) MessageBox.Show("No OS detected");
						}
					}
					if (myProperty.Name == "CSName") Program.ThisPC.SystemName = obj.Properties[myProperty.Name].Value.ToString();
					if (myProperty.Name == "OSArchitecture")
					{
						if (obj.Properties[myProperty.Name].Value.ToString().Contains("64")) Program.ThisPC.SystemArchitecture = 64;
						if (obj.Properties[myProperty.Name].Value.ToString().Contains("32")) Program.ThisPC.SystemArchitecture = 32;
					}
				}
			}
			MainProgressBar.Value += 10;
		}
		private void getRam()
		{
			InitLabel.Text = "Getting RAM...";
			ObjectQuery wql = new ObjectQuery("SELECT TotalVisibleMemorySize FROM Win32_OperatingSystem");
			ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
			ManagementObjectCollection results = searcher.Get();
			int memorysize = 0;
			foreach (ManagementObject result in results) memorysize = Convert.ToInt32(result["TotalVisibleMemorySize"]);
			Program.ThisPC.RamCapacity = Convert.ToUInt32(memorysize / 1024);
			MainProgressBar.Value += 10;
		}
		private void getCPU()
		{
			InitLabel.Text = "Scanning CPU...";
			ManagementClass myManagementClass = new ManagementClass("Win32_Processor");
			ManagementObjectCollection myManagementCollection = myManagementClass.GetInstances();
			foreach (var obj in myManagementCollection)
			{
				foreach (var myProperty in myManagementClass.Properties)
				{
					if (myProperty.Name == "Name") Program.ThisPC.Processor.Name = obj.Properties[myProperty.Name].Value.ToString();
					if (myProperty.Name == "NumberOfCores") Program.ThisPC.Processor.NumberOfCores = Convert.ToUInt32(obj.Properties[myProperty.Name].Value);
					if (myProperty.Name == "ThreadCount") Program.ThisPC.Processor.ThreadCount = Convert.ToUInt32(obj.Properties[myProperty.Name].Value);
					if (myProperty.Name == "MaxClockSpeed") Program.ThisPC.Processor.MaxClockSpeed = Convert.ToUInt32(obj.Properties[myProperty.Name].Value);
				}
			}
			MainProgressBar.Value += 20;
		}
		private void getGPU() // the hardest fucking part
		{
			InitLabel.Text = "Scanning GPU...";
			ErrorCode error;
			Platform[] platforms = Cl.GetPlatformIDs(out error);
			List<Device> devicesList = new List<Device>();
			foreach (Platform platform in platforms) {
				foreach (Device device in Cl.GetDeviceIDs(platform, DeviceType.Gpu, out error))	{
					devicesList.Add(device);
				}
			}
			MainProgressBar.Value += 20;
			if (devicesList.Count > 1) { // if there is more videocards in PC than one
				GpuChooseForm gcf = new GpuChooseForm(devicesList); // Form which provides choice for GPU-s
				if (gcf.ShowDialog() == DialogResult.OK)
				{
					bool CurrGPU = false;
					ManagementClass mc = new ManagementClass("Win32_VideoController");
					ManagementObjectCollection moc = mc.GetInstances();
					foreach (var obj in moc)
					{
						foreach (var myProperty in mc.Properties) //assign every value untill it stumbles upon correct GPU
						{
							if (myProperty.Name == "Caption" || myProperty.Name == "Name") // in case if those parameters are different from gcf.ChoosenGPU
							{
								if (obj.Properties[myProperty.Name].Value.ToString().Contains(gcf.ChoosenGPU))
								Program.ThisPC.GraphicsCard.Name = obj.Properties[myProperty.Name].Value.ToString();
								CurrGPU = true;
							}
							if (myProperty.Name == "AdapterRAM") Program.ThisPC.GraphicsCard.Vram = Convert.ToUInt64(obj.Properties[myProperty.Name].Value) / 1048576;
							if (myProperty.Name == "CurrentRefreshRate") Program.ThisPC.GraphicsCard.CurrentRefreshRate = Convert.ToUInt32(obj.Properties[myProperty.Name].Value);
							if (myProperty.Name == "CurrentHorizontalResolution") Program.ThisPC.GraphicsCard.CurrentHorizontalResolution = Convert.ToUInt32(obj.Properties[myProperty.Name].Value);
							if (myProperty.Name == "CurrentVerticalResolution") Program.ThisPC.GraphicsCard.CurrentVerticalResolution = Convert.ToUInt32(obj.Properties[myProperty.Name].Value);
						}
						if (CurrGPU) {
							foreach (var vdev in devicesList){
								if (Cl.GetDeviceInfo(vdev, DeviceInfo.Name, out error).ToString() == gcf.ChoosenGPU) {
									Program.ThisPC.GraphicsCard.MaxClockFrequency = Cl.GetDeviceInfo(vdev, DeviceInfo.MaxClockFrequency, out error).CastTo<uint>();
								}
							}
							MainProgressBar.Value += 20;
							//MessageBox.Show("Videocard: \n" + Program.ThisPC.GraphicsCard.Name + '\n' + Program.ThisPC.GraphicsCard.Vram + " MB \n" + Program.ThisPC.GraphicsCard.MaxClockFrequency + " GHz \n" + Program.ThisPC.GraphicsCard.CurrentRefreshRate + '\n' + Program.ThisPC.GraphicsCard.CurrentHorizontalResolution + 'x' + Program.ThisPC.GraphicsCard.CurrentVerticalResolution);
							return;
						}
					}
				}
			}
			else
			{
				ManagementClass mc = new ManagementClass("Win32_VideoController");
				ManagementObjectCollection moc = mc.GetInstances();
				foreach (var obj in moc)
				{
					foreach (var myProperty in mc.Properties)
					{
						if (myProperty.Name == "Caption") Program.ThisPC.GraphicsCard.Name = obj.Properties[myProperty.Name].Value.ToString();
						if (myProperty.Name == "AdapterRAM") Program.ThisPC.GraphicsCard.Vram = Convert.ToUInt64(obj.Properties[myProperty.Name].Value) / 1048576;
						if (myProperty.Name == "CurrentRefreshRate") Program.ThisPC.GraphicsCard.CurrentRefreshRate = Convert.ToUInt32(obj.Properties[myProperty.Name].Value);
						if (myProperty.Name == "CurrentHorizontalResolution") Program.ThisPC.GraphicsCard.CurrentHorizontalResolution = Convert.ToUInt32(obj.Properties[myProperty.Name].Value);
						if (myProperty.Name == "CurrentVerticalResolution") Program.ThisPC.GraphicsCard.CurrentVerticalResolution = Convert.ToUInt32(obj.Properties[myProperty.Name].Value);
					}
				}
				foreach (var vdev in devicesList) {
					Program.ThisPC.GraphicsCard.MaxClockFrequency = Cl.GetDeviceInfo(vdev, DeviceInfo.MaxClockFrequency, out error).CastTo<uint>();
				}
				MainProgressBar.Value += 20;
				//MessageBox.Show("Videocard: \n" + Program.ThisPC.GraphicsCard.Name + '\n' + Program.ThisPC.GraphicsCard.Vram + " MB \n"+ Program.ThisPC.GraphicsCard.MaxClockFrequency + " GHz \n" + Program.ThisPC.GraphicsCard.CurrentRefreshRate + '\n' + Program.ThisPC.GraphicsCard.CurrentHorizontalResolution + 'x' + Program.ThisPC.GraphicsCard.CurrentVerticalResolution);
			}
		}
		private void ScanForm_Load(object sender, EventArgs e)
        {
            MainLabel.Font = new Font(Program.Comfortaa.Families[0], MainLabel.Font.Size);
            InitLabel.Font = new Font(Program.Comfortaa.Families[0], InitLabel.Font.Size);
        }

		private void ScanForm_Shown(object sender, EventArgs e)
		{
			if (File.Exists("currentmachine.dat")) MessageBox.Show("This computer was scanned");
			CurrentMachineDefaultSettings();
			getOS(); // +10
			getRam(); // +10
			getCPU(); // +20
			getGPU(); // +40
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream fs = new FileStream("currentmachine.dat", FileMode.OpenOrCreate);
			formatter.Serialize(fs, Program.ThisPC);
			fs.Close();
			Close();
		}
	}
}
