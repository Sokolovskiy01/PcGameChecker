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
            this.Button_getinfo = new System.Windows.Forms.Button();
            this.CpuBar = new CircularProgressBar.CircularProgressBar();
            this.cpu_usage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RamBar = new CircularProgressBar.CircularProgressBar();
            this.GpuBar = new CircularProgressBar.CircularProgressBar();
            this.ram_usage = new System.Windows.Forms.Label();
            this.gpu_usage = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Comp_name = new System.Windows.Forms.Label();
            this.CPU_perf = new System.Diagnostics.PerformanceCounter();
            this.RAM_perf = new System.Diagnostics.PerformanceCounter();
            this.Sys_total_ram = new System.Windows.Forms.Label();
            this.Sys_proc_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_perf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM_perf)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_getinfo
            // 
            this.Button_getinfo.AutoSize = true;
            this.Button_getinfo.BackColor = System.Drawing.Color.Tomato;
            this.Button_getinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_getinfo.Font = new System.Drawing.Font("Comfortaa", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_getinfo.ForeColor = System.Drawing.Color.Transparent;
            this.Button_getinfo.Location = new System.Drawing.Point(682, 542);
            this.Button_getinfo.Name = "Button_getinfo";
            this.Button_getinfo.Size = new System.Drawing.Size(260, 100);
            this.Button_getinfo.TabIndex = 0;
            this.Button_getinfo.Text = "Get info";
            this.Button_getinfo.UseVisualStyleBackColor = false;
            this.Button_getinfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // CpuBar
            // 
            this.CpuBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CpuBar.AnimationSpeed = 250;
            this.CpuBar.BackColor = System.Drawing.Color.Transparent;
            this.CpuBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CpuBar.ForeColor = System.Drawing.Color.Transparent;
            this.CpuBar.InnerColor = System.Drawing.Color.Transparent;
            this.CpuBar.InnerMargin = 2;
            this.CpuBar.InnerWidth = 1;
            this.CpuBar.Location = new System.Drawing.Point(356, 203);
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
            this.cpu_usage.BackColor = System.Drawing.Color.Transparent;
            this.cpu_usage.Font = new System.Drawing.Font("Comfortaa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cpu_usage.Location = new System.Drawing.Point(351, 466);
            this.cpu_usage.Name = "cpu_usage";
            this.cpu_usage.Size = new System.Drawing.Size(265, 29);
            this.cpu_usage.TabIndex = 4;
            this.cpu_usage.Text = "CPU Usage :";
            this.cpu_usage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RamBar
            // 
            this.RamBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.RamBar.AnimationSpeed = 250;
            this.RamBar.BackColor = System.Drawing.Color.Transparent;
            this.RamBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RamBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.RamBar.ForeColor = System.Drawing.Color.Transparent;
            this.RamBar.InnerColor = System.Drawing.Color.Transparent;
            this.RamBar.InnerMargin = 2;
            this.RamBar.InnerWidth = 1;
            this.RamBar.Location = new System.Drawing.Point(682, 203);
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
            this.RamBar.MouseHover += new System.EventHandler(this.RamBar_MouseHover);
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
            this.GpuBar.Location = new System.Drawing.Point(1008, 203);
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
            this.ram_usage.BackColor = System.Drawing.Color.Transparent;
            this.ram_usage.Font = new System.Drawing.Font("Comfortaa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ram_usage.Location = new System.Drawing.Point(682, 466);
            this.ram_usage.Name = "ram_usage";
            this.ram_usage.Size = new System.Drawing.Size(260, 29);
            this.ram_usage.TabIndex = 7;
            this.ram_usage.Text = "RAM Usage :";
            this.ram_usage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gpu_usage
            // 
            this.gpu_usage.BackColor = System.Drawing.Color.Transparent;
            this.gpu_usage.Font = new System.Drawing.Font("Comfortaa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gpu_usage.Location = new System.Drawing.Point(1003, 171);
            this.gpu_usage.Name = "gpu_usage";
            this.gpu_usage.Size = new System.Drawing.Size(265, 29);
            this.gpu_usage.TabIndex = 8;
            this.gpu_usage.Text = "VRAM";
            this.gpu_usage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Snow;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(312, 654);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Comp_name
            // 
            this.Comp_name.AutoSize = true;
            this.Comp_name.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Comp_name.Location = new System.Drawing.Point(376, 24);
            this.Comp_name.Name = "Comp_name";
            this.Comp_name.Size = new System.Drawing.Size(179, 38);
            this.Comp_name.TabIndex = 11;
            this.Comp_name.Text = "Comp_name";
            // 
            // CPU_perf
            // 
            this.CPU_perf.CategoryName = "Processor";
            this.CPU_perf.CounterName = "% Processor time";
            this.CPU_perf.InstanceName = "_Total";
            // 
            // RAM_perf
            // 
            this.RAM_perf.CategoryName = "Memory";
            this.RAM_perf.CounterName = "Available MBytes";
            // 
            // Sys_total_ram
            // 
            this.Sys_total_ram.BackColor = System.Drawing.Color.Transparent;
            this.Sys_total_ram.Font = new System.Drawing.Font("Comfortaa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Sys_total_ram.Location = new System.Drawing.Point(682, 171);
            this.Sys_total_ram.Name = "Sys_total_ram";
            this.Sys_total_ram.Size = new System.Drawing.Size(260, 29);
            this.Sys_total_ram.TabIndex = 12;
            this.Sys_total_ram.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Sys_proc_name
            // 
            this.Sys_proc_name.BackColor = System.Drawing.Color.Transparent;
            this.Sys_proc_name.Font = new System.Drawing.Font("Comfortaa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Sys_proc_name.Location = new System.Drawing.Point(351, 171);
            this.Sys_proc_name.Name = "Sys_proc_name";
            this.Sys_proc_name.Size = new System.Drawing.Size(265, 29);
            this.Sys_proc_name.TabIndex = 13;
            this.Sys_proc_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1307, 654);
            this.Controls.Add(this.Sys_proc_name);
            this.Controls.Add(this.Sys_total_ram);
            this.Controls.Add(this.Comp_name);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.gpu_usage);
            this.Controls.Add(this.ram_usage);
            this.Controls.Add(this.GpuBar);
            this.Controls.Add(this.RamBar);
            this.Controls.Add(this.cpu_usage);
            this.Controls.Add(this.CpuBar);
            this.Controls.Add(this.Button_getinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main_Form";
            this.Text = "PcGameChecker";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.LightPink;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CPU_perf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM_perf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Button_getinfo;
		private CircularProgressBar.CircularProgressBar CpuBar;
		private System.Windows.Forms.Label cpu_usage;
		private System.Windows.Forms.Timer timer1;
		private CircularProgressBar.CircularProgressBar RamBar;
		private CircularProgressBar.CircularProgressBar GpuBar;
		private System.Windows.Forms.Label ram_usage;
		private System.Windows.Forms.Label gpu_usage;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label Comp_name;
        private System.Diagnostics.PerformanceCounter CPU_perf;
        private System.Diagnostics.PerformanceCounter RAM_perf;
        private System.Windows.Forms.Label Sys_total_ram;
        private System.Windows.Forms.Label Sys_proc_name;
    }
}

