using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker
{
    public class HardwareWarning
    {
        public enum WarningType { GPU, CPU, RAM, System, Disk, Software, Unknown }
        public enum WarningLevel { High, Critical, Unknown }

        WarningType Type;
        WarningLevel Level;
        string Description;
        public HardwareWarning()
        {
            Type = WarningType.Unknown;
            Level = WarningLevel.Unknown;
            Description = "Unknown";
        }
        public HardwareWarning(WarningLevel level, WarningType type, string desc)
        {
            Type = type;
            Level = level;
            Description = desc;
        }
        public override string ToString()
        {
            return Description;
        }
    }
}
