using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PcGameChecker
{
	class GraphicsCard
	{
		public enum GPUVendor { Nvidia, Radeon, Intel, ATI, Unknown };
		public string Name;
		public GPUVendor Vendor;
		public uint Vram; // MB
		public uint Clock; // MHz
		public uint MemoryClock; // MHz
		public uint BusWidth; // bit
		public uint Shaders; // Shader Unit
		public uint ROPs;    // Render Output Unit
		public uint TMUs;   // Texture Mapping Unit
		public string MemoryType;
		public string DirectXSupport;
		public Screen[] Screens; // Bounds for games, Working area for fomrs
		public GraphicsCard()
		{
			Name = "Unknown";
			Vendor = GPUVendor.Unknown;
			Vram = 0;
			Clock = 0;
			MemoryClock = 0;
			BusWidth = 0;
			Shaders = 0;
			ROPs = 0;
			TMUs = 0;
			MemoryType = "Unknown";
			DirectXSupport = "Unknown";
			Screens = Screen.AllScreens;
		}
		public override string ToString()
		{
			string screeninfo = "";
			foreach(Screen s in Screens)
            {
				if (screeninfo != "") screeninfo += " , ";
				screeninfo += s.Bounds.Width + "x" + s.Bounds.Height;
            }
			return "Name : " + Name +
				"\nVendor : " + Vendor.ToString() +
				"\nVRAM :" + Vram.ToString() + " MB" +
				"\nClock : " + Clock.ToString() + " MHz" +
				"\nMemory clock : " + MemoryClock.ToString() + " MHz" +
				"\nMemory bus width : " + BusWidth.ToString() + " bit" +
				"\nShaders : " + Shaders.ToString() +
				"\nROP\'s : " + ROPs.ToString() +
				"\nTMU\'s : " + TMUs.ToString() +
				"\nMemory type : " + MemoryType +
				"\nDirectX support : " + DirectXSupport +
				"\nDisplays : " + screeninfo;
        }
    }//end of class
}