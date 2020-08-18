using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PcGameChecker
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			DoubleBuffered = true;
			SetStyle(ControlStyles.ResizeRedraw, true);
			SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			InitializeComponent();
			Program.screenMode = ScreenMode.Normal;
		}
		private void ScanSystemGPU()
		{
			Process gpuz = new Process();
			gpuz.StartInfo.FileName = "GPU-Z.2.33.0.exe";
			gpuz.StartInfo.Arguments = "-dump gpuinfo.xml";
			gpuz.StartInfo.Verb = "runas";
			if (!File.Exists("gpuinfo.xml")) {
				gpuz.Start();
				gpuz.WaitForExit();
			}
			XElement file = XElement.Load("gpuinfo.xml");
			foreach (XElement gpu in file.Elements("card"))
			{
				GraphicsCard tmp = new GraphicsCard();
				tmp.Name = gpu.Element("cardname").Value;
				if (gpu.Element("vendor").Value.ToLower().Contains("intel")) tmp.Vendor = GraphicsCard.GPUVendor.Intel;
				if (gpu.Element("vendor").Value.ToLower().Contains("radeon")) tmp.Vendor = GraphicsCard.GPUVendor.Radeon;
				if (gpu.Element("vendor").Value.ToLower().Contains("nvidia")) tmp.Vendor = GraphicsCard.GPUVendor.Nvidia;
				tmp.Vram = Convert.ToUInt32(gpu.Element("memsize").Value);
				if (tmp.Vram == 0)
				{
					bool currgpu = false; // if system has more than one graphics card this loop will go through every GPU to find matching vram
					ManagementClass mc = new ManagementClass("Win32_VideoController");
					ManagementObjectCollection moc = mc.GetInstances();
					foreach (var obj in moc)
					{
						if (obj.Properties["Name"].Value.ToString().Contains(tmp.Name) || Regex.IsMatch(tmp.Name, obj.Properties["Name"].Value.ToString())) currgpu = true;
						tmp.Vram = Convert.ToUInt32(Convert.ToUInt64(obj.Properties["AdapterRAM"].Value) / 1048576);
						if (currgpu) break;
					}
				}
				tmp.Clock = Convert.ToUInt32(gpu.Element("clockgpuboost").Value);
				if (tmp.Clock == 0) tmp.Clock = Convert.ToUInt32(gpu.Element("clockgpuboostdefault").Value);
				tmp.MemoryClock = Convert.ToUInt32(gpu.Element("clockmem").Value);
				tmp.BusWidth = Convert.ToUInt32(gpu.Element("membuswidth").Value);
				tmp.Shaders = Convert.ToUInt32(gpu.Element("numshadersunified").Value);
				tmp.ROPs = Convert.ToUInt32(gpu.Element("numtmus").Value);
				tmp.TMUs = Convert.ToUInt32(gpu.Element("numrops").Value);
				if (tmp.MemoryClock == 0) tmp.MemoryClock = Convert.ToUInt32(gpu.Element("clockmemdefault").Value);
				tmp.MemoryType = gpu.Element("memtype").Value;
				tmp.DirectXSupport = gpu.Element("directxsupport").Value;
				Program.GraphicsCards.Add(tmp);
				tmp = null;
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			//Processor processor = new Processor();
			//SystemInfo system = new SystemInfo();
			//ScanSystemGPU();
			//richTextBox1.Text += processor.ToString();
			//richTextBox1.Text += "\n\n";
			//foreach (GraphicsCard gpu in Program.GraphicsCards)
			//{
			//	richTextBox1.Text += gpu.ToString() + "\n\n";
			//}
			//richTextBox1.Text += system.ToString();
		}

		private void Form1_Shown(object sender, EventArgs e)
		{

		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			panel1.Width = this.Width / 3;
			richTextBox1.Width = this.Width / 2;
		}

        private void leftPanelButton1_Click(object sender, EventArgs e)
        {
			leftPanelButton1.IsSelected = true;
			leftPanelButton2.IsSelected = false;
			leftPanelButton3.IsSelected = false;
			leftPanelButton2.Invalidate();
			leftPanelButton3.Invalidate();
		}

        private void leftPanelButton2_Click(object sender, EventArgs e)
        {
			leftPanelButton1.IsSelected = false;
			leftPanelButton2.IsSelected = true;
			leftPanelButton3.IsSelected = false;
			leftPanelButton1.Invalidate();
			leftPanelButton3.Invalidate();
		}

        private void leftPanelButton3_Click(object sender, EventArgs e)
        {
			leftPanelButton1.IsSelected = false;
			leftPanelButton2.IsSelected = false;
			leftPanelButton3.IsSelected = true;
			leftPanelButton1.Invalidate();
			leftPanelButton2.Invalidate();
		}
    }
}
