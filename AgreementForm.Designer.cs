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
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonAgree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AgeementLabel
            // 
            this.AgeementLabel.AutoSize = true;
            this.AgeementLabel.Location = new System.Drawing.Point(280, 232);
            this.AgeementLabel.Name = "AgeementLabel";
            this.AgeementLabel.Size = new System.Drawing.Size(171, 17);
            this.AgeementLabel.TabIndex = 0;
            this.AgeementLabel.Text = "Согласие на взлом жопы";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(180)))));
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonCancel.Location = new System.Drawing.Point(97, 364);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(182, 69);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonAgree
            // 
            this.ButtonAgree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(180)))));
            this.ButtonAgree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAgree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAgree.Location = new System.Drawing.Point(451, 364);
            this.ButtonAgree.Name = "ButtonAgree";
            this.ButtonAgree.Size = new System.Drawing.Size(182, 69);
            this.ButtonAgree.TabIndex = 2;
            this.ButtonAgree.Text = "Proceed";
            this.ButtonAgree.UseVisualStyleBackColor = false;
            this.ButtonAgree.Click += new System.EventHandler(this.ButtonAgree_Click);
            // 
            // AgreementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 480);
            this.Controls.Add(this.ButtonAgree);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.AgeementLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgreementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgreementForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AgeementLabel;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonAgree;
    }
}