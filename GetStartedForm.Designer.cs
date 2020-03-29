﻿namespace PcGameChecker
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
            this.CloseImage = new System.Windows.Forms.PictureBox();
            this.GetStartedLabel = new System.Windows.Forms.Label();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.Panel_fake_rectangle = new System.Windows.Forms.Panel();
            this.ScanPCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CloseImage)).BeginInit();
            this.Panel_fake_rectangle.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseImage
            // 
            this.CloseImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseImage.BackColor = System.Drawing.Color.Transparent;
            this.CloseImage.BackgroundImage = global::PcGameChecker.Properties.Resources.closeg;
            this.CloseImage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CloseImage.InitialImage = null;
            this.CloseImage.Location = new System.Drawing.Point(1283, 12);
            this.CloseImage.Name = "CloseImage";
            this.CloseImage.Size = new System.Drawing.Size(25, 25);
            this.CloseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CloseImage.TabIndex = 0;
            this.CloseImage.TabStop = false;
            this.CloseImage.Click += new System.EventHandler(this.pictureBox1_Click);
            this.CloseImage.MouseLeave += new System.EventHandler(this.CloseImage_MouseLeave);
            this.CloseImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseImage_MouseMove);
            // 
            // GetStartedLabel
            // 
            this.GetStartedLabel.BackColor = System.Drawing.Color.Transparent;
            this.GetStartedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 66F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GetStartedLabel.Location = new System.Drawing.Point(74, 29);
            this.GetStartedLabel.Name = "GetStartedLabel";
            this.GetStartedLabel.Size = new System.Drawing.Size(1172, 151);
            this.GetStartedLabel.TabIndex = 1;
            this.GetStartedLabel.Text = "Get Started";
            this.GetStartedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.BackColor = System.Drawing.Color.Transparent;
            this.CopyrightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CopyrightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.CopyrightLabel.Location = new System.Drawing.Point(12, 669);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(1296, 52);
            this.CopyrightLabel.TabIndex = 2;
            this.CopyrightLabel.Text = "© CoreX 2020. No rights reserved.";
            this.CopyrightLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Panel_fake_rectangle
            // 
            this.Panel_fake_rectangle.BackColor = System.Drawing.Color.Transparent;
            this.Panel_fake_rectangle.Controls.Add(this.ScanPCLabel);
            this.Panel_fake_rectangle.Location = new System.Drawing.Point(459, 526);
            this.Panel_fake_rectangle.Name = "Panel_fake_rectangle";
            this.Panel_fake_rectangle.Size = new System.Drawing.Size(403, 140);
            this.Panel_fake_rectangle.TabIndex = 3;
            this.Panel_fake_rectangle.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_fake_rectangle_Paint);
            // 
            // ScanPCLabel
            // 
            this.ScanPCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScanPCLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(117)))));
            this.ScanPCLabel.Location = new System.Drawing.Point(0, -14);
            this.ScanPCLabel.Name = "ScanPCLabel";
            this.ScanPCLabel.Size = new System.Drawing.Size(403, 154);
            this.ScanPCLabel.TabIndex = 4;
            this.ScanPCLabel.Text = "Scan my PC";
            this.ScanPCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ScanPCLabel.Click += new System.EventHandler(this.ScanPCLabel_Click);
            this.ScanPCLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScanPCLabel_MouseDown);
            this.ScanPCLabel.MouseLeave += new System.EventHandler(this.ScanPCLabel_MouseLeave);
            this.ScanPCLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScanPCLabel_MouseMove);
            // 
            // GetStartedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PcGameChecker.Properties.Resources.appbackground1;
            this.ClientSize = new System.Drawing.Size(1320, 730);
            this.Controls.Add(this.Panel_fake_rectangle);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.GetStartedLabel);
            this.Controls.Add(this.CloseImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetStartedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetStartedForm";
            this.Load += new System.EventHandler(this.GetStartedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CloseImage)).EndInit();
            this.Panel_fake_rectangle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CloseImage;
        private System.Windows.Forms.Label GetStartedLabel;
        private System.Windows.Forms.Label CopyrightLabel;
        private System.Windows.Forms.Panel Panel_fake_rectangle;
        private System.Windows.Forms.Label ScanPCLabel;
    }
}