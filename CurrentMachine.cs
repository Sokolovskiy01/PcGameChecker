using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGameChecker
{
	[Serializable]
	class CurrentMachine
	{
		public bool IsDarkModeEnabled { get; set; } 
		public bool CYRIYesDisplay { get; set; } // should the program display games, which this PC can run ?
		public bool CYRIMaybeDisplay { get; set; } 
		public bool CYRINoDisplay { get; set; } 
		public Color Forecolor { get; set; } // stores current user selected font
		public string SystemName { get; set; }
		public uint RamCapacity { get; set; } 
		public string SystemOS { get; set; } 
		public uint SystemArchitecture { get; set; } 
		public Processor Processor = new Processor();
		public GraphicsCard GraphicsCard = new GraphicsCard();
		public CurrentMachine() { }
	}
	[Serializable]
	class GraphicsCard
	{
		public string Name { get; set; }
		public ulong Vram { get; set; } 
		public uint MaxClockFrequency { get; set; } // OpenCL.net
		public uint CurrentRefreshRate { get; set; } 
		public uint CurrentHorizontalResolution { get; set; } 
		public uint CurrentVerticalResolution { get; set; } 
		public GraphicsCard() { }
	}
	[Serializable]
	class Processor
	{
		public string Name { get; set; } 
		public uint NumberOfCores { get; set; } 
		public uint ThreadCount { get; set; } 
		public uint MaxClockSpeed { get; set; } 
		public Processor() { }
	}
}