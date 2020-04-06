namespace PcGameChecker
{
    partial class ScanForm
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
            this.gradientPanel1 = new PcGameChecker.GradientPanel();
            this.ScanTextLabel = new System.Windows.Forms.Label();
            this.Program_title = new System.Windows.Forms.Label();
            this.Progressbar = new System.Windows.Forms.ProgressBar();
            this.timerload = new System.Windows.Forms.Timer(this.components);
            this.ButtonContinue = new System.Windows.Forms.Button();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(180)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(117)))));
            this.gradientPanel1.Controls.Add(this.ButtonContinue);
            this.gradientPanel1.Controls.Add(this.ScanTextLabel);
            this.gradientPanel1.Controls.Add(this.Program_title);
            this.gradientPanel1.Controls.Add(this.Progressbar);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(650, 320);
            this.gradientPanel1.TabIndex = 2;
            // 
            // ScanTextLabel
            // 
            this.ScanTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScanTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanTextLabel.Location = new System.Drawing.Point(82, 184);
            this.ScanTextLabel.Name = "ScanTextLabel";
            this.ScanTextLabel.Size = new System.Drawing.Size(498, 33);
            this.ScanTextLabel.TabIndex = 6;
            this.ScanTextLabel.Text = "Initializing...";
            this.ScanTextLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Program_title
            // 
            this.Program_title.BackColor = System.Drawing.Color.Transparent;
            this.Program_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Program_title.Location = new System.Drawing.Point(0, 58);
            this.Program_title.Name = "Program_title";
            this.Program_title.Size = new System.Drawing.Size(650, 84);
            this.Program_title.TabIndex = 4;
            this.Program_title.Text = "PC Game Cheker";
            this.Program_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Progressbar
            // 
            this.Progressbar.ForeColor = System.Drawing.Color.Black;
            this.Progressbar.Location = new System.Drawing.Point(82, 228);
            this.Progressbar.Name = "Progressbar";
            this.Progressbar.Size = new System.Drawing.Size(498, 17);
            this.Progressbar.Step = 1;
            this.Progressbar.TabIndex = 5;
            this.Progressbar.Value = 10;
            // 
            // timerload
            // 
            this.timerload.Interval = 1000;
            this.timerload.Tick += new System.EventHandler(this.timerload_Tick);
            // 
            // ButtonContinue
            // 
            this.ButtonContinue.BackColor = System.Drawing.Color.Transparent;
            this.ButtonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonContinue.ForeColor = System.Drawing.Color.Black;
            this.ButtonContinue.Location = new System.Drawing.Point(257, 251);
            this.ButtonContinue.Name = "ButtonContinue";
            this.ButtonContinue.Size = new System.Drawing.Size(137, 57);
            this.ButtonContinue.TabIndex = 7;
            this.ButtonContinue.Text = "Continue";
            this.ButtonContinue.UseVisualStyleBackColor = false;
            this.ButtonContinue.Visible = false;
            this.ButtonContinue.Click += new System.EventHandler(this.ButtonContinue_Click);
            // 
            // ScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 320);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScanForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScanForm";
            this.Load += new System.EventHandler(this.ScanForm_Load);
            this.Shown += new System.EventHandler(this.ScanForm_Shown);
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label ScanTextLabel;
        private System.Windows.Forms.Label Program_title;
        private System.Windows.Forms.ProgressBar Progressbar;
        private System.Windows.Forms.Timer timerload;
        private System.Windows.Forms.Button ButtonContinue;
    }
}