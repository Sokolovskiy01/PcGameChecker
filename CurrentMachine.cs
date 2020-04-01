using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGameChecker
{
	[Serializable]
	class CurrentMachine
	{
		public string SystemName { get; set; } //
		public uint RamCapacity { get; set; } //
		public string SystemOS { get; set; } //
		public string SystemArchitecture { get; set; } //
		public Processor Processor = new Processor();
		public GraphicsCard GraphicsCard = new GraphicsCard();
		public CurrentMachine() { }
	}
	class GraphicsCard
	{
		public string Name { get; set; } //
		public ulong Vram { get; set; } //
		public uint MaxClockFrequency { get; set; } //
		public uint CurrentRefreshRate { get; set; } //
		public uint CurrentHorizontalResolution { get; set; } //
		public uint CurrentVerticalResolution { get; set; } //
		public GraphicsCard() { }
	}
	class Processor
	{
		public string Name { get; set; } //
		public uint NumberOfCores { get; set; } //
		public uint ThreadCount { get; set; } //
		public uint MaxClockSpeed { get; set; } //
		public Processor() { }
	}
}