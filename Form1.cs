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

        private void Form1_Load(object sender, EventArgs e)
        {
            //circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            var result = Registry.GetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0", "~MHz", 0);
            label1.Text = "Processor count : " + Environment.ProcessorCount.ToString() + "\nProcessor frequency: " + ((int)result).ToString() + " MHz\n";
            ManagementClass myManagementClass = new ManagementClass("Win32_Processor");
            ManagementObjectCollection myManagementCollection = myManagementClass.GetInstances();
            PropertyDataCollection myProperties = myManagementClass.Properties;
            //Dictionary myPropertyResults = new Dictionary();

            foreach (var obj in myManagementCollection)
            {
                foreach (var myProperty in myManagementClass.Properties)
                {
                    //myPropertyResults.Add(myProperty.Name,obj.Properties[myProperty.Name].Value);
                    richTextBox1.Text += myProperty.Name + " : " + obj.Properties[myProperty.Name].Value + "\n";
                }
            }

            //foreach (var myPropertyResult in myPropertyResults)
            //{
            //    Console.WriteLine("{0}: {1}", myPropertyResult.Key, myPropertyResult.Value);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = "Lorem ipsum dolor sit amet.";
            circularProgressBar1.Value = 0;
            for (int i = 0; i <= 100; i++){
                circularProgressBar1.Value = i;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}