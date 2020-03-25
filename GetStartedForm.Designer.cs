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
            this.CloseImage = new System.Windows.Forms.PictureBox();
            this.GetStartedLabel = new System.Windows.Forms.Label();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CloseImage)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseImage
            // 
            this.CloseImage.BackColor = System.Drawing.Color.Transparent;
            this.CloseImage.BackgroundImage = global::PcGameChecker.Properties.Resources.closeg;
            this.CloseImage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CloseImage.InitialImage = null;
            this.CloseImage.Location = new System.Drawing.Point(1283, 12);
            this.CloseImage.Name = "CloseImage";
            this.CloseImage.Size = new System.Drawing.Size(25, 25);
            this.CloseImage.TabIndex = 0;
            this.CloseImage.TabStop = false;
            this.CloseImage.Click += new System.EventHandler(this.pictureBox1_Click);
            this.CloseImage.MouseLeave += new System.EventHandler(this.CloseImage_MouseLeave);
            this.CloseImage.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // GetStartedLabel
            // 
            this.GetStartedLabel.BackColor = System.Drawing.Color.Transparent;
            this.GetStartedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 61.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GetStartedLabel.Location = new System.Drawing.Point(74, 12);
            this.GetStartedLabel.Name = "GetStartedLabel";
            this.GetStartedLabel.Size = new System.Drawing.Size(1172, 151);
            this.GetStartedLabel.TabIndex = 1;
            this.GetStartedLabel.Text = "Get Started";
            this.GetStartedLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.BackColor = System.Drawing.Color.Transparent;
            this.CopyrightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CopyrightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.CopyrightLabel.Location = new System.Drawing.Point(12, 682);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(1296, 39);
            this.CopyrightLabel.TabIndex = 2;
            this.CopyrightLabel.Text = "© CoreX 2020. No rights reserved.";
            this.CopyrightLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GetStartedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1320, 730);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.GetStartedLabel);
            this.Controls.Add(this.CloseImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetStartedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetStartedForm";
            this.Load += new System.EventHandler(this.GetStartedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CloseImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CloseImage;
        private System.Windows.Forms.Label GetStartedLabel;
        private System.Windows.Forms.Label CopyrightLabel;
    }
}