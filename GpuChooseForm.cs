using OpenCL.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker
{
    public partial class GpuChooseForm : Form
    {
        public string ChoosenGPU;
        public uint ChoosenGPUClock;
        public GpuChooseForm()
        {
            InitializeComponent();
        }
        public GpuChooseForm(List<Device> devices)
        {
            InitializeComponent();
            ErrorCode error;
            foreach (var vdev in devices) {
                ComboBoxGPUNames.Items.Add(Cl.GetDeviceInfo(vdev, DeviceInfo.Name, out error).ToString());
                ComboBoxGPUNames.SelectedItem = Cl.GetDeviceInfo(vdev, DeviceInfo.Name, out error).ToString();
            }
        }
        private void GpuChooseForm_Load(object sender, EventArgs e)
        {
            WarningLabel.Font = new Font(Program.Comfortaa.Families[0], WarningLabel.Font.Size);
            ConfirmButton.Font = new Font(Program.Comfortaa.Families[0], ConfirmButton.Font.Size);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ChoosenGPU = ComboBoxGPUNames.Text;
        }
    }
}
