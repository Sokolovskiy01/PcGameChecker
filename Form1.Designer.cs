namespace PcGameChecker
{
	partial class Main_Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.CpuBar = new CircularProgressBar.CircularProgressBar();
            this.cpu_usage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RamBar = new CircularProgressBar.CircularProgressBar();
            this.GpuBar = new CircularProgressBar.CircularProgressBar();
            this.ram_usage = new System.Windows.Forms.Label();
            this.gpu_usage = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Comp_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 128);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CpuBar
            // 
            this.CpuBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CpuBar.AnimationSpeed = 500;
            this.CpuBar.BackColor = System.Drawing.Color.Transparent;
            this.CpuBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CpuBar.ForeColor = System.Drawing.Color.Transparent;
            this.CpuBar.InnerColor = System.Drawing.Color.Transparent;
            this.CpuBar.InnerMargin = 2;
            this.CpuBar.InnerWidth = 1;
            this.CpuBar.Location = new System.Drawing.Point(337, 202);
            this.CpuBar.MarqueeAnimationSpeed = 2000;
            this.CpuBar.Name = "CpuBar";
            this.CpuBar.OuterColor = System.Drawing.Color.Tomato;
            this.CpuBar.OuterMargin = -25;
            this.CpuBar.OuterWidth = 25;
            this.CpuBar.ProgressColor = System.Drawing.Color.Goldenrod;
            this.CpuBar.ProgressWidth = 25;
            this.CpuBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CpuBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.CpuBar.Size = new System.Drawing.Size(260, 260);
            this.CpuBar.StartAngle = 130;
            this.CpuBar.SubscriptColor = System.Drawing.Color.Transparent;
            this.CpuBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CpuBar.SubscriptText = "";
            this.CpuBar.SuperscriptColor = System.Drawing.Color.Transparent;
            this.CpuBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CpuBar.SuperscriptText = "";
            this.CpuBar.TabIndex = 2;
            this.CpuBar.Text = "CPU Usage";
            this.CpuBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.CpuBar.Value = 68;
            // 
            // cpu_usage
            // 
            this.cpu_usage.AutoSize = true;
            this.cpu_usage.BackColor = System.Drawing.Color.Transparent;
            this.cpu_usage.Font = new System.Drawing.Font("Comfortaa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cpu_usage.Location = new System.Drawing.Point(380, 465);
            this.cpu_usage.Name = "cpu_usage";
            this.cpu_usage.Size = new System.Drawing.Size(136, 29);
            this.cpu_usage.TabIndex = 4;
            this.cpu_usage.Text = "CPU Usage :";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RamBar
            // 
            this.RamBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.RamBar.AnimationSpeed = 500;
            this.RamBar.BackColor = System.Drawing.Color.Transparent;
            this.RamBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RamBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.RamBar.ForeColor = System.Drawing.Color.Transparent;
            this.RamBar.InnerColor = System.Drawing.Color.Transparent;
            this.RamBar.InnerMargin = 2;
            this.RamBar.InnerWidth = 1;
            this.RamBar.Location = new System.Drawing.Point(663, 202);
            this.RamBar.MarqueeAnimationSpeed = 2000;
            this.RamBar.Name = "RamBar";
            this.RamBar.OuterColor = System.Drawing.Color.Tomato;
            this.RamBar.OuterMargin = -25;
            this.RamBar.OuterWidth = 25;
            this.RamBar.ProgressColor = System.Drawing.Color.Goldenrod;
            this.RamBar.ProgressWidth = 25;
            this.RamBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RamBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.RamBar.Size = new System.Drawing.Size(260, 260);
            this.RamBar.StartAngle = 130;
            this.RamBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RamBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.RamBar.SubscriptText = ".2";
            this.RamBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RamBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.RamBar.SuperscriptText = "°C";
            this.RamBar.TabIndex = 5;
            this.RamBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.RamBar.Value = 68;
            // 
            // GpuBar
            // 
            this.GpuBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.GpuBar.AnimationSpeed = 500;
            this.GpuBar.BackColor = System.Drawing.Color.Transparent;
            this.GpuBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.GpuBar.ForeColor = System.Drawing.Color.Transparent;
            this.GpuBar.InnerColor = System.Drawing.Color.Transparent;
            this.GpuBar.InnerMargin = 2;
            this.GpuBar.InnerWidth = 1;
            this.GpuBar.Location = new System.Drawing.Point(989, 202);
            this.GpuBar.MarqueeAnimationSpeed = 500;
            this.GpuBar.Name = "GpuBar";
            this.GpuBar.OuterColor = System.Drawing.Color.Tomato;
            this.GpuBar.OuterMargin = -25;
            this.GpuBar.OuterWidth = 25;
            this.GpuBar.ProgressColor = System.Drawing.Color.Goldenrod;
            this.GpuBar.ProgressWidth = 25;
            this.GpuBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GpuBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.GpuBar.Size = new System.Drawing.Size(260, 260);
            this.GpuBar.StartAngle = 130;
            this.GpuBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GpuBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.GpuBar.SubscriptText = ".2";
            this.GpuBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GpuBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.GpuBar.SuperscriptText = "°C";
            this.GpuBar.TabIndex = 6;
            this.GpuBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.GpuBar.Value = 68;
            // 
            // ram_usage
            // 
            this.ram_usage.AutoSize = true;
            this.ram_usage.BackColor = System.Drawing.Color.Transparent;
            this.ram_usage.Font = new System.Drawing.Font("Comfortaa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ram_usage.Location = new System.Drawing.Point(690, 465);
            this.ram_usage.Name = "ram_usage";
            this.ram_usage.Size = new System.Drawing.Size(137, 29);
            this.ram_usage.TabIndex = 7;
            this.ram_usage.Text = "RAM Usage :";
            // 
            // gpu_usage
            // 
            this.gpu_usage.AutoSize = true;
            this.gpu_usage.BackColor = System.Drawing.Color.Transparent;
            this.gpu_usage.Font = new System.Drawing.Font("Comfortaa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gpu_usage.Location = new System.Drawing.Point(1018, 465);
            this.gpu_usage.Name = "gpu_usage";
            this.gpu_usage.Size = new System.Drawing.Size(136, 29);
            this.gpu_usage.TabIndex = 8;
            this.gpu_usage.Text = "GPU Usage :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Snow;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(312, 543);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Comp_name
            // 
            this.Comp_name.AutoSize = true;
            this.Comp_name.Font = new System.Drawing.Font("Comfortaa", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Comp_name.Location = new System.Drawing.Point(376, 24);
            this.Comp_name.Name = "Comp_name";
            this.Comp_name.Size = new System.Drawing.Size(234, 51);
            this.Comp_name.TabIndex = 11;
            this.Comp_name.Text = "Comp_name";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1262, 664);
            this.Controls.Add(this.Comp_name);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.gpu_usage);
            this.Controls.Add(this.ram_usage);
            this.Controls.Add(this.GpuBar);
            this.Controls.Add(this.RamBar);
            this.Controls.Add(this.cpu_usage);
            this.Controls.Add(this.CpuBar);
            this.Controls.Add(this.button1);
            this.Name = "Main_Form";
            this.Text = "PcGameChecker";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.LightPink;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private CircularProgressBar.CircularProgressBar CpuBar;
		private System.Windows.Forms.Label cpu_usage;
		private System.Windows.Forms.Timer timer1;
		private CircularProgressBar.CircularProgressBar RamBar;
		private CircularProgressBar.CircularProgressBar GpuBar;
		private System.Windows.Forms.Label ram_usage;
		private System.Windows.Forms.Label gpu_usage;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label Comp_name;
        //private Syncfusion.XForms.ProgressBar.SfCircularProgressBar sirc1;
    }
}

