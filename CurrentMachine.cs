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
		public bool IsDarkModeEnabled { get; set; } //set
		public bool CYRIYesDisplay { get; set; } // set //should the program display games, which this PC can run
		public bool CYRIMaybeDisplay { get; set; } //set
		public bool CYRINoDisplay { get; set; } //set
		public Color Forecolor { get; set; } // set  //stores current user selected font
		public string SystemName { get; set; }// set
		public uint RamCapacity { get; set; } // set
		public string SystemOS { get; set; } // set
		public uint SystemArchitecture { get; set; } // set
		public Processor Processor = new Processor();
		public GraphicsCard GraphicsCard = new GraphicsCard();
		public CurrentMachine() { }
	}
	[Serializable]
	class GraphicsCard
	{
		public string Name { get; set; }// set
		public ulong Vram { get; set; } // set
		public uint MaxClockFrequency { get; set; } //set // OpenCL.net
		public uint CurrentRefreshRate { get; set; } // set
		public uint CurrentHorizontalResolution { get; set; } // set
		public uint CurrentVerticalResolution { get; set; } // set
		public GraphicsCard() { }
	}
	[Serializable]
	class Processor
	{
		public string Name { get; set; } // set
		public uint NumberOfCores { get; set; } // set
		public uint ThreadCount { get; set; } // set
		public uint MaxClockSpeed { get; set; } // set
		public Processor() { }
	}
}