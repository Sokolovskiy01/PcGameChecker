namespace PcGameChecker
{
    partial class GpuChooseForm
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
            this.WarningLabel = new System.Windows.Forms.Label();
            this.ComboBoxGPUNames = new System.Windows.Forms.ComboBox();
            this.ConfirmButton = new PcGameChecker.RoundedButton();
            this.SuspendLayout();
            // 
            // WarningLabel
            // 
            this.WarningLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WarningLabel.Location = new System.Drawing.Point(0, 0);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(440, 70);
            this.WarningLabel.TabIndex = 0;
            this.WarningLabel.Text = "More than one graphics card detected. Please, choose one to compare.";
            this.WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBoxGPUNames
            // 
            this.ComboBoxGPUNames.BackColor = System.Drawing.Color.White;
            this.ComboBoxGPUNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxGPUNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxGPUNames.FormattingEnabled = true;
            this.ComboBoxGPUNames.Location = new System.Drawing.Point(117, 92);
            this.ComboBoxGPUNames.Name = "ComboBoxGPUNames";
            this.ComboBoxGPUNames.Size = new System.Drawing.Size(224, 24);
            this.ComboBoxGPUNames.TabIndex = 1;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(117)))));
            this.ConfirmButton.BorderWidth = 3;
            this.ConfirmButton.ButtonColor = System.Drawing.Color.White;
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfirmButton.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(117)))));
            this.ConfirmButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(180)))));
            this.ConfirmButton.HoverButtonColor = System.Drawing.Color.White;
            this.ConfirmButton.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(180)))));
            this.ConfirmButton.Location = new System.Drawing.Point(139, 178);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ConfirmButton.Rounding = 32F;
            this.ConfirmButton.Size = new System.Drawing.Size(162, 60);
            this.ConfirmButton.TabIndex = 2;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // GpuChooseForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 250);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ComboBoxGPUNames);
            this.Controls.Add(this.WarningLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GpuChooseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GpuChooseForm";
            this.Load += new System.EventHandler(this.GpuChooseForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.ComboBox ComboBoxGPUNames;
        private RoundedButton ConfirmButton;
    }
}