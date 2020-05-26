namespace PcGameChecker
{
    partial class GetStartedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetStartedForm));
            this.GetStartedLabel = new System.Windows.Forms.Label();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.minimizeButton1 = new PcGameChecker.MinimizeButton();
            this.closeButton1 = new PcGameChecker.CloseButton();
            this.ScanButton = new PcGameChecker.RoundedButton();
            this.AuthorsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetStartedLabel
            // 
            this.GetStartedLabel.BackColor = System.Drawing.Color.Transparent;
            this.GetStartedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 66F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GetStartedLabel.Location = new System.Drawing.Point(0, 40);
            this.GetStartedLabel.Margin = new System.Windows.Forms.Padding(0);
            this.GetStartedLabel.Name = "GetStartedLabel";
            this.GetStartedLabel.Size = new System.Drawing.Size(1320, 148);
            this.GetStartedLabel.TabIndex = 1;
            this.GetStartedLabel.Text = "Get Started";
            this.GetStartedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.BackColor = System.Drawing.Color.Transparent;
            this.CopyrightLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CopyrightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CopyrightLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.CopyrightLabel.Location = new System.Drawing.Point(0, 685);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(1320, 45);
            this.CopyrightLabel.TabIndex = 2;
            this.CopyrightLabel.Text = "Copyright © VDV 2020. No rights Reserved";
            this.CopyrightLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // minimizeButton1
            // 
            this.minimizeButton1.Buttoncolor = System.Drawing.Color.Transparent;
            this.minimizeButton1.ButtonHoverColor = System.Drawing.Color.Silver;
            this.minimizeButton1.icon = global::PcGameChecker.Properties.Resources.minimize;
            this.minimizeButton1.Location = new System.Drawing.Point(1240, 0);
            this.minimizeButton1.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeButton1.Name = "minimizeButton1";
            this.minimizeButton1.Size = new System.Drawing.Size(40, 30);
            this.minimizeButton1.TabIndex = 4;
            this.minimizeButton1.Text = "minimizeButton1";
            this.minimizeButton1.Click += new System.EventHandler(this.minimizeButton1_Click);
            // 
            // closeButton1
            // 
            this.closeButton1.Buttoncolor = System.Drawing.Color.Transparent;
            this.closeButton1.ButtonHoverColor = System.Drawing.Color.Red;
            this.closeButton1.icon = global::PcGameChecker.Properties.Resources.close;
            this.closeButton1.icon2 = global::PcGameChecker.Properties.Resources.close2;
            this.closeButton1.Location = new System.Drawing.Point(1280, 0);
            this.closeButton1.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(40, 30);
            this.closeButton1.TabIndex = 3;
            this.closeButton1.Text = "closeButton1";
            this.closeButton1.Click += new System.EventHandler(this.closeButton1_Click);
            // 
            // ScanButton
            // 
            this.ScanButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(117)))));
            this.ScanButton.BorderWidth = 5;
            this.ScanButton.ButtonColor = System.Drawing.Color.White;
            this.ScanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScanButton.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(117)))));
            this.ScanButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(180)))));
            this.ScanButton.HoverButtonColor = System.Drawing.SystemColors.Control;
            this.ScanButton.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(180)))));
            this.ScanButton.Location = new System.Drawing.Point(480, 497);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ScanButton.Rounding = 35F;
            this.ScanButton.Size = new System.Drawing.Size(360, 145);
            this.ScanButton.TabIndex = 0;
            this.ScanButton.Text = "Scan my PC";
            this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // AuthorsLabel
            // 
            this.AuthorsLabel.BackColor = System.Drawing.Color.Transparent;
            this.AuthorsLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.AuthorsLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.AuthorsLabel.Location = new System.Drawing.Point(1029, 0);
            this.AuthorsLabel.Name = "AuthorsLabel";
            this.AuthorsLabel.Size = new System.Drawing.Size(291, 685);
            this.AuthorsLabel.TabIndex = 5;
            this.AuthorsLabel.Text = "Dmytro Sokolovskyi\r\nVladyslav Zagurskiy\r\nVladyslav Kvoka";
            this.AuthorsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GetStartedForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PcGameChecker.Properties.Resources.GetStartedBackground;
            this.ClientSize = new System.Drawing.Size(1320, 730);
            this.Controls.Add(this.AuthorsLabel);
            this.Controls.Add(this.minimizeButton1);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.GetStartedLabel);
            this.Controls.Add(this.ScanButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GetStartedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetStartedForm";
            this.Load += new System.EventHandler(this.GetStartedForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedButton ScanButton;
        private System.Windows.Forms.Label GetStartedLabel;
        private System.Windows.Forms.Label CopyrightLabel;
        private CloseButton closeButton1;
        private MinimizeButton minimizeButton1;
        private System.Windows.Forms.Label AuthorsLabel;
    }
}