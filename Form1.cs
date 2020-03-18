using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Data.Entity.Core.Objects;

namespace PcGameChecker
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public void getcpu()
		{ 
			ManagementClass myManagementClass = new ManagementClass("Win32_Processor");
			ManagementObjectCollection myManagementCollection = myManagementClass.GetInstances();
			//PropertyDataCollection myProperties = myManagementClass.Properties;

			foreach (var obj in myManagementCollection)
			{
				cpu_usage.Text = "CPU Usage : " + myManagementClass.GetPropertyValue("LoadPercentage") + "%";
				circularProgressBar1.Value = Convert.ToInt32(myManagementClass.GetPropertyValue("LoadPercentage"));

				foreach (var myProperty in myManagementClass.Properties)
				{
					//myPropertyResults.Add(myProperty.Name,obj.Properties[myProperty.Name].Value);
					richTextBox1.Text += myProperty.Name + " : " + obj.Properties[myProperty.Name].Value + "\n";
					if (myProperty.Name == "LoadPercentage")
					{
						cpu_usage.Text = "CPU Usage : " + obj.Properties[myProperty.Name].Value + "%";
						circularProgressBar1.Value = Convert.ToInt32(obj.Properties[myProperty.Name].Value);
					}
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			circularProgressBar1.Minimum = 0;
			circularProgressBar1.Maximum = 100;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			getcpu();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}