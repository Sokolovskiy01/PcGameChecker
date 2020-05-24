namespace PcGameChecker
{
    partial class AgreementForm
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
            this.AgeementLabel = new System.Windows.Forms.Label();
            this.ProceedButton = new PcGameChecker.RoundedButton();
            this.CancelButton = new PcGameChecker.RoundedButton();
            this.SuspendLayout();
            // 
            // AgeementLabel
            // 
            this.AgeementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AgeementLabel.Location = new System.Drawing.Point(93, 63);
            this.AgeementLabel.Name = "AgeementLabel";
            this.AgeementLabel.Size = new System.Drawing.Size(521, 232);
            this.AgeementLabel.TabIndex = 0;
            this.AgeementLabel.Text = "This program does NOT collects any of your private data and don\'t even establish " +
    "an internet connection. Whole games database is local and this program has it\'s " +
    "own perfomance computing algoritm.";
            this.AgeementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProceedButton
            // 
            this.ProceedButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(117)))));
            this.ProceedButton.BorderWidth = 3;
            this.ProceedButton.ButtonColor = System.Drawing.Color.White;
            this.ProceedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProceedButton.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(117)))));
            this.ProceedButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(180)))));
            this.ProceedButton.HoverButtonColor = System.Drawing.Color.White;
            this.ProceedButton.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(180)))));
            this.ProceedButton.Location = new System.Drawing.Point(428, 335);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ProceedButton.Rounding = 20F;
            this.ProceedButton.Size = new System.Drawing.Size(182, 79);
            this.ProceedButton.TabIndex = 2;
            this.ProceedButton.Text = "Proceed";
            this.ProceedButton.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(117)))));
            this.CancelButton.BorderWidth = 3;
            this.CancelButton.ButtonColor = System.Drawing.Color.White;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancelButton.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(117)))));
            this.CancelButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.CancelButton.HoverButtonColor = System.Drawing.Color.White;
            this.CancelButton.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.CancelButton.Location = new System.Drawing.Point(120, 335);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.CancelButton.Rounding = 20F;
            this.CancelButton.Size = new System.Drawing.Size(182, 79);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AgreementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 480);
            this.Controls.Add(this.ProceedButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AgeementLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgreementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgreementForm";
            this.Load += new System.EventHandler(this.AgreementForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AgreementForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AgeementLabel;
        private RoundedButton CancelButton;
        private RoundedButton ProceedButton;
    }
}