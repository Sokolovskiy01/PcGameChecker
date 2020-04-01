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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgreementForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PanelProceed = new System.Windows.Forms.Panel();
            this.ProceedLabel = new System.Windows.Forms.Label();
            this.PanelCancel = new System.Windows.Forms.Panel();
            this.CancelLabel = new System.Windows.Forms.Label();
            this.AgeementLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.PanelProceed.SuspendLayout();
            this.PanelCancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.PanelProceed);
            this.MainPanel.Controls.Add(this.PanelCancel);
            this.MainPanel.Controls.Add(this.AgeementLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(730, 480);
            this.MainPanel.TabIndex = 3;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintMiain_OnPaint);
            // 
            // PanelProceed
            // 
            this.PanelProceed.Controls.Add(this.ProceedLabel);
            this.PanelProceed.Location = new System.Drawing.Point(421, 354);
            this.PanelProceed.Name = "PanelProceed";
            this.PanelProceed.Size = new System.Drawing.Size(182, 69);
            this.PanelProceed.TabIndex = 4;
            this.PanelProceed.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelProceed_Paint);
            // 
            // ProceedLabel
            // 
            this.ProceedLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProceedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProceedLabel.Location = new System.Drawing.Point(0, -7);
            this.ProceedLabel.Name = "ProceedLabel";
            this.ProceedLabel.Size = new System.Drawing.Size(182, 76);
            this.ProceedLabel.TabIndex = 1;
            this.ProceedLabel.Text = "Proceed";
            this.ProceedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProceedLabel.Click += new System.EventHandler(this.ButtonAgree_Click);
            this.ProceedLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelProceed_MouseDown);
            this.ProceedLabel.MouseLeave += new System.EventHandler(this.PanelProceed_MouseLeave);
            this.ProceedLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelProceed_MouseMove);
            // 
            // PanelCancel
            // 
            this.PanelCancel.Controls.Add(this.CancelLabel);
            this.PanelCancel.Location = new System.Drawing.Point(127, 354);
            this.PanelCancel.Name = "PanelCancel";
            this.PanelCancel.Size = new System.Drawing.Size(182, 69);
            this.PanelCancel.TabIndex = 3;
            this.PanelCancel.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCancel_Paint);
            // 
            // CancelLabel
            // 
            this.CancelLabel.BackColor = System.Drawing.Color.Transparent;
            this.CancelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancelLabel.Location = new System.Drawing.Point(0, -7);
            this.CancelLabel.Name = "CancelLabel";
            this.CancelLabel.Size = new System.Drawing.Size(182, 76);
            this.CancelLabel.TabIndex = 0;
            this.CancelLabel.Text = "Cancel";
            this.CancelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelLabel.Click += new System.EventHandler(this.ButtonCancel_Click);
            this.CancelLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CancelLabel_MouseDown);
            this.CancelLabel.MouseLeave += new System.EventHandler(this.CancelLabel_MouseLeave);
            this.CancelLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CancelLabel_MouseMove);
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
            // AgreementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 480);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgreementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgreementForm";
            this.Load += new System.EventHandler(this.AgreementForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.PanelProceed.ResumeLayout(false);
            this.PanelCancel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PanelProceed;
        private System.Windows.Forms.Panel PanelCancel;
        private System.Windows.Forms.Label AgeementLabel;
        private System.Windows.Forms.Label ProceedLabel;
        private System.Windows.Forms.Label CancelLabel;
    }
}