using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcGameChecker
{
	public partial class InitForm : Form
	{
		public InitForm()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (progressBar1.Value != 100) progressBar1.Value += 10;
			else Close();
		}

		private void InitForm_Load(object sender, EventArgs e)
		{
			InitLabel.Font = new Font(Program.Comfortaa.Families[0], InitLabel.Font.Size);
			MainLabel.Font = new Font(Program.Comfortaa.Families[0], MainLabel.Font.Size);
		}

		private void InitForm_Shown(object sender, EventArgs e)
		{
			timer1.Enabled = true;
			if (!File.Exists("gamelist.dat"))
			{
				MessageBox.Show("Error : Games database file can't be found");
				Application.Exit();
			}
			else {
				BinaryFormatter GamesDeserializer = new BinaryFormatter();
				FileStream fs1 = new FileStream("gamelist.dat", FileMode.Open);
				Program.GamesList = (List<Game>)GamesDeserializer.Deserialize(fs1);
				fs1.Close();
			}
			if (!File.Exists("Resources//Comfortaa-VariableFont_wght.ttf"))
			{
				MessageBox.Show("Error : Comfortaa font file does not exists");
				Application.Exit();
			}
			if (File.Exists("currentmachine.dat"))
			{
				Program.IsFirstRun = false;
				BinaryFormatter formatter = new BinaryFormatter();
				FileStream fs = new FileStream("currentmachine.dat", FileMode.Open);
				Program.ThisPC = (CurrentMachine)formatter.Deserialize(fs);
				fs.Close();
			}
		}
	}
}
