using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PcGameChecker
{
	[Serializable]
	class Processor
	{
		public enum CPUVendor { Intel, AMD, Unknown };
		CPUVendor Vendor; //
		string Name; //
		uint generation;
		uint MaxClockSpeed; //
		uint CoreCount; //
		uint ThreadCount; // Logical processors count
		public Processor()
		{
			ManagementClass myManagementClass = new ManagementClass("Win32_Processor");
			ManagementObjectCollection myManagementCollection = myManagementClass.GetInstances();
			foreach (var obj in myManagementCollection)
			{
				Name = obj.Properties["Name"].Value.ToString();
				CoreCount = Convert.ToUInt32(obj.Properties["NumberOfCores"].Value);
				ThreadCount = Convert.ToUInt32(obj.Properties["ThreadCount"].Value);
				if (ThreadCount == 0) ThreadCount = Convert.ToUInt32(obj.Properties["NumberOfLogicalProcessors"].Value);
				MaxClockSpeed = Convert.ToUInt32(obj.Properties["MaxClockSpeed"].Value);
			}
			if (Name.ToLower().Contains("intel")) Vendor = CPUVendor.Intel;
			else if (Name.ToLower().Contains("amd")) Vendor = CPUVendor.AMD;
			else Vendor = CPUVendor.Unknown;
			switch (Vendor)
			{
				case CPUVendor.Intel:
					if (Name.ToLower().Contains("core"))
					{
						string pattern = @"i[0-9]+-[A-Z]*"; // should be found : i7-8550U
						if (Regex.IsMatch(Name, pattern, RegexOptions.IgnoreCase))
						{
							string result = Regex.Match(Name, pattern).Value;
							string subpattern = @"-[0-9]+"; // should be found : -8550
							result = Regex.Match(Name, subpattern).Value;
							result = Regex.Replace(result, "-", ""); // now it's 8550
							if (result.Length == 3) generation = 1;
							if (result.Length == 4) generation = (uint)char.GetNumericValue(result[0]);
							if (result.Length == 5) generation = (uint)char.GetNumericValue(result[0]) * 10 + (uint)char.GetNumericValue(result[1]);
						}
					}
					else if (Name.ToLower().Contains("pentium"))
					{
						//TODO
					}
					else if (Name.ToLower().Contains("celeron"))
					{
						//TODO
					}
					else if (Name.ToLower().Contains("xeon"))
					{
						//TODO
					}
					break;
				case CPUVendor.AMD:
					// Big TODO
					break;
				default:
					generation = 0;
					break;
			}
		}
		public override string ToString()
		{
			return "Name : " + Name +
				"\nVendor: " + Vendor +
				"\nGeneration : " + ((generation == 0) ? "Unknown" : generation.ToString()) +
				"\nCores : " + CoreCount.ToString() +
				"\nThreads : " + ThreadCount.ToString() +
				"\nClock Speed : " + MaxClockSpeed.ToString() + " MHz";
		}
	}
}
