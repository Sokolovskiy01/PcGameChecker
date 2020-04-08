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

	public partial class GameADD : Form
	{
		List<Game> GameList = new List<Game>();
		public GameADD()
		{
			InitializeComponent();
		}
		private void GameADD_Load(object sender, EventArgs e)
		{
			BinaryFormatter formatter1 = new BinaryFormatter();
			try	{
				FileStream fs1 = new FileStream("gamelist.dat", FileMode.Open);
				GameList = (List<Game>)formatter1.Deserialize(fs1);
				fs1.Close();
				int count = 1;
				foreach(var game in GameList)
				{
					ExistingGamesRichTextBox.Text += count.ToString() + ") " + game.Name + "\n";
					count++;
				}
			}
			catch {
				MessageBox.Show("gamelist.dat does not exist");
			}
		}
		private void clearfields()
		{
			gameName.Clear();
			GenreName.Clear();
			YearGame.Clear();
			comboBox1.Text = "";
			comboBox2.Text = "";
			Req_Disk_Space.Clear();
			Min_Processor_Cores.Clear();
			Min_Processor_Threads.Clear();
			Min_Processor_Clock.Clear();
			Min_Graphics_VRAM.Clear();
			Min_Graphics_Gpu_Clock.Clear();
			Description.Clear();
			Metacritics.Clear();
			User_rate.Clear();
			Req_Processor_Cores.Clear();
			Req_Processor_Threads.Clear();
			Req_Processor_Clock.Clear();
			Req_Graphics_VRAM.Clear();
			Req_Graphics_Gpu_Clock.Clear();
		}
		private void ConfirmGame_Click(object sender, EventArgs e)
		{
			//newGame g1 = new newGame(gameName.Text, Description.Text, Convert.ToUInt32(YearGame.Text), GenreName.Text, pictureBox1.Image, Req_OS.Text, Req_OS_Ar.Text, Req_Disk_Space.Text, Convert.ToUInt32(Min_Processor_Cores.Text), Convert.ToUInt32(Min_Processor_Threads.Text), Convert.ToUInt32(Min_Processor_Clock.Text), Convert.ToUInt32(Min_Graphics_VRAM.Text), Convert.ToUInt32(Min_Graphics_Gpu_Clock.Text));
			if (gameName.Text.Length == 0) {
				MessageBox.Show("Game name empty");
				return;
			}
			string g_n = Convert.ToString(gameName.Text);
			if (GenreName.Text.Length == 0)	{
				MessageBox.Show("Genre is empty");
				return;
			}
			string g_g = Convert.ToString(GenreName.Text);
			if (YearGame.Text.Length == 0) {
				MessageBox.Show("Year is empty");
				return;
			}
			else {
				try	{ Convert.ToUInt32(YearGame.Text); }
				catch {	MessageBox.Show("Year is not a digit");
					return;
				}
				if (Convert.ToUInt32(YearGame.Text) > System.DateTime.Now.Year || Convert.ToUInt32(YearGame.Text) < 1960) {
					MessageBox.Show("Year is not valid");
					return;
				}
			}
			uint year = Convert.ToUInt32(YearGame.Text);
			if (comboBox1.Text.Length == 0)	{
				MessageBox.Show("Required OS is empty");
				return;
			}
			string r_o = Convert.ToString(comboBox1.Text);
			if (comboBox2.Text.Length == 0)	{
				MessageBox.Show("Os architecture is empty");
				return;
			}
			string r_o_a = Convert.ToString(comboBox2.Text);
			if (Req_Disk_Space.Text.Length == 0) {
				MessageBox.Show("Required disk space is empty");
			}
			string r_d_s = Convert.ToString(Req_Disk_Space.Text);
			if (Min_Processor_Cores.Text.Length == 0) {
				MessageBox.Show("Minimal processor cores field is empty");
				return;
			}
			else {
				try	{ Convert.ToUInt32(Min_Processor_Cores.Text); }
				catch {
					MessageBox.Show("Minimal processor cores are not digits");
					return;
				}
			}
			uint m_p_co = Convert.ToUInt32(Min_Processor_Cores.Text);
			if (Min_Processor_Cores.Text.Length == 0) {
				MessageBox.Show("Minimal processor threads field is empty");
				return;
			}
			else {
				try	{ Convert.ToUInt32(Min_Processor_Threads.Text);	}
				catch {
					MessageBox.Show("Minimal processor threads are not digits");
					return;
				}
			}
			uint m_p_t = Convert.ToUInt32(Min_Processor_Threads.Text);
			if (Min_Processor_Clock.Text.Length == 0) {
				MessageBox.Show("Minimal processor clock is empty");
				return;
			}
			else {
				try	{ Convert.ToUInt32(Min_Processor_Clock.Text); }
				catch {
					MessageBox.Show("Minimal processor clock is not a digits");
					return;
				}
			}
			uint m_p_cl = Convert.ToUInt32(Min_Processor_Clock.Text);
			if (Min_Graphics_VRAM.Text.Length == 0) MessageBox.Show("Minimal VRAM is empty");
			else {
				try { Convert.ToUInt32(Min_Graphics_VRAM.Text);	}
				catch {
					MessageBox.Show("Minimal VRAM is not a digits");
					return;
				}
			}
			uint m_g_V = Convert.ToUInt32(Min_Graphics_VRAM.Text);
			if (Min_Graphics_Gpu_Clock.Text.Length == 0) {
				MessageBox.Show("Minimal GPU clock is empty");
				return;
			}
			else {
				try	{ Convert.ToUInt32(Min_Graphics_Gpu_Clock.Text); }
				catch {
					MessageBox.Show("Minimal GPU clock is not a digits");
					return;
				}
			}
			uint m_g_g_c = Convert.ToUInt32(Min_Graphics_Gpu_Clock.Text);
			if (Description.Text.Length == 0) {
				MessageBox.Show("Description is empty");
				return;
			}
			string desk = Convert.ToString(Description.Text);

			
			if (Metacritics.Text.Length == 0) {
				MessageBox.Show("Metacritics is empty");
				return;
			}
			else {
				try { Convert.ToUInt32(Metacritics.Text); }
				catch {
					MessageBox.Show("Metacritics field is not a digits");
					return;
				}
				if (Convert.ToUInt32(Metacritics.Text) > 100) {
					MessageBox.Show("Metacritics can't be below 100");
					return;
				}
			}
			uint mcrit = Convert.ToUInt32(Metacritics.Text);
			if (User_rate.Text.Length == 0) {
				MessageBox.Show("User rate is empty");
				return;
			}
			else {
				try { Convert.ToDouble(User_rate.Text); }
				catch {
					MessageBox.Show("User ratings field is not a digits");
					return;
				}
				if (Convert.ToDouble(User_rate.Text) >= 10 && Convert.ToDouble(User_rate.Text) <= 0) {
					MessageBox.Show("User rate is in bad range");
				}
			}
			double user_r = Convert.ToDouble(User_rate.Text);
			if (pictureBox1.BackgroundImage == null) {
				MessageBox.Show("Game poster is not incerted");
				return;
			}
			Image post_im = pictureBox1.BackgroundImage;
			if (pictureBox2.BackgroundImage == null)
			{
				MessageBox.Show("Game icon is not incerted");
				return;
			}
			Image icon_im = pictureBox2.BackgroundImage;

			Game newgame = new Game(g_n, desk, year, g_g, post_im, icon_im, r_o, mcrit, user_r, r_o_a, r_d_s, m_p_co, m_p_t, m_p_cl, m_g_V, m_g_g_c);

			if (Req_Processor_Cores.Text.Length != 0 || Req_Processor_Threads.Text.Length != 0 || Req_Processor_Clock.Text.Length !=0 || Req_Graphics_VRAM.Text.Length != 0 || Req_Graphics_Gpu_Clock.Text.Length != 0)	{
				if (Req_Processor_Cores.Text.Length == 0) {
					MessageBox.Show("Req processor cores is empty");
					return;
				}
				else {
					try { Convert.ToUInt32(Req_Processor_Cores.Text); }
					catch { 
						MessageBox.Show("Req processor cores is not a digits");
						return;
					}
				}
				uint r_p_co = Convert.ToUInt32(Req_Processor_Cores.Text);
				if (Req_Processor_Threads.Text.Length == 0) {
					MessageBox.Show("Req processor threads is empty");
					return;
				}
				else {
					try { Convert.ToUInt32(Req_Processor_Threads.Text); }
					catch { 
						MessageBox.Show("Req processor threads is not a digits");
						return;
					}
				}
				uint r_p_t = Convert.ToUInt32(Req_Processor_Threads.Text);
				if (Req_Processor_Clock.Text.Length == 0) {
					MessageBox.Show("Req processor clock is empty");
					return;
				}
				else {
					try { Convert.ToUInt32(Req_Processor_Clock.Text); }
					catch { 
						MessageBox.Show("Req processor clock is not a digits");
						return;
					}
				}
				uint r_p_cl = Convert.ToUInt32(Req_Processor_Clock.Text);
				if (Req_Graphics_VRAM.Text.Length == 0) {
					MessageBox.Show("Req VRAM is empty");
					return;
				}
				else {
					try { Convert.ToUInt32(Req_Graphics_VRAM.Text); }
					catch { 
						MessageBox.Show("Req VRAM is not a digits");
						return;
					}
				}
				uint r_g_v = Convert.ToUInt32(Req_Graphics_VRAM.Text);
				if (Req_Graphics_Gpu_Clock.Text.Length == 0) {
					MessageBox.Show("Req GPU clock is empty");
					return;
				}
				else {
					try { Convert.ToUInt32(Req_Graphics_Gpu_Clock.Text); }
					catch { 
						MessageBox.Show("Req Gpu Clock is not a digits");
						return;
					}
				}
				uint r_g_g_c = Convert.ToUInt32(Req_Graphics_Gpu_Clock.Text);
				newgame.AddRec(r_p_co, r_p_t, r_p_cl, r_g_v, r_g_g_c);
			}
			GameList.Add(newgame);
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream fs = new FileStream("gamelist.dat", FileMode.OpenOrCreate);
			formatter.Serialize(fs, GameList);
			fs.Close();
			MessageBox.Show("Game was succesfully added!");
			clearfields();
		}

		private void label13_Click_1(object sender, EventArgs e)
		{
			if(OpenGamePicture.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.BackgroundImage = Image.FromFile(OpenGamePicture.FileName);
				pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
			}
		}

		private void label21_Click(object sender, EventArgs e)
		{
			if(OpenGameIcon.ShowDialog() == DialogResult.OK)
			{
				pictureBox2.BackgroundImage = Image.FromFile(OpenGameIcon.FileName);
				pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
			}
		}
	}
}