namespace PcGameChecker
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leftPanelButton1 = new PcGameChecker.GraphExtensions.LeftPanelButton();
            this.leftPanelButton2 = new PcGameChecker.GraphExtensions.LeftPanelButton();
            this.leftPanelButton3 = new PcGameChecker.GraphExtensions.LeftPanelButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.richTextBox1.Location = new System.Drawing.Point(522, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(526, 539);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.leftPanelButton3);
            this.panel1.Controls.Add(this.leftPanelButton2);
            this.panel1.Controls.Add(this.leftPanelButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 539);
            this.panel1.TabIndex = 1;
            // 
            // leftPanelButton1
            // 
            this.leftPanelButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftPanelButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.leftPanelButton1.Font = new System.Drawing.Font("Comfortaa", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.leftPanelButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(117)))));
            this.leftPanelButton1.HoverIcon = ((System.Drawing.Image)(resources.GetObject("leftPanelButton1.HoverIcon")));
            this.leftPanelButton1.Icon = ((System.Drawing.Image)(resources.GetObject("leftPanelButton1.Icon")));
            this.leftPanelButton1.Location = new System.Drawing.Point(0, 0);
            this.leftPanelButton1.MaximumSize = new System.Drawing.Size(17895697, 120);
            this.leftPanelButton1.MinimumSize = new System.Drawing.Size(90, 90);
            this.leftPanelButton1.Name = "leftPanelButton1";
            this.leftPanelButton1.Padding = new System.Windows.Forms.Padding(10);
            this.leftPanelButton1.Size = new System.Drawing.Size(353, 120);
            this.leftPanelButton1.TabIndex = 0;
            this.leftPanelButton1.Text = "Main";
            this.leftPanelButton1.TextHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(180)))));
            this.leftPanelButton1.TextRectangleTopPadding = 20;
            this.leftPanelButton1.Click += new System.EventHandler(this.leftPanelButton1_Click);
            // 
            // leftPanelButton2
            // 
            this.leftPanelButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.leftPanelButton2.Font = new System.Drawing.Font("Comfortaa", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.leftPanelButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(117)))));
            this.leftPanelButton2.HoverIcon = ((System.Drawing.Image)(resources.GetObject("leftPanelButton2.HoverIcon")));
            this.leftPanelButton2.Icon = ((System.Drawing.Image)(resources.GetObject("leftPanelButton2.Icon")));
            this.leftPanelButton2.Location = new System.Drawing.Point(0, 120);
            this.leftPanelButton2.MaximumSize = new System.Drawing.Size(17895697, 120);
            this.leftPanelButton2.MinimumSize = new System.Drawing.Size(90, 90);
            this.leftPanelButton2.Name = "leftPanelButton2";
            this.leftPanelButton2.Padding = new System.Windows.Forms.Padding(10);
            this.leftPanelButton2.Size = new System.Drawing.Size(353, 120);
            this.leftPanelButton2.TabIndex = 1;
            this.leftPanelButton2.Text = "Games";
            this.leftPanelButton2.TextHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(180)))));
            this.leftPanelButton2.TextRectangleTopPadding = 10;
            this.leftPanelButton2.Click += new System.EventHandler(this.leftPanelButton2_Click);
            // 
            // leftPanelButton3
            // 
            this.leftPanelButton3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.leftPanelButton3.Font = new System.Drawing.Font("Comfortaa", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.leftPanelButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(173)))), ((int)(((byte)(117)))));
            this.leftPanelButton3.HoverIcon = ((System.Drawing.Image)(resources.GetObject("leftPanelButton3.HoverIcon")));
            this.leftPanelButton3.Icon = ((System.Drawing.Image)(resources.GetObject("leftPanelButton3.Icon")));
            this.leftPanelButton3.Location = new System.Drawing.Point(0, 419);
            this.leftPanelButton3.MaximumSize = new System.Drawing.Size(17895697, 120);
            this.leftPanelButton3.MinimumSize = new System.Drawing.Size(90, 90);
            this.leftPanelButton3.Name = "leftPanelButton3";
            this.leftPanelButton3.Padding = new System.Windows.Forms.Padding(10);
            this.leftPanelButton3.Size = new System.Drawing.Size(353, 120);
            this.leftPanelButton3.TabIndex = 2;
            this.leftPanelButton3.Text = "Settings";
            this.leftPanelButton3.TextHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(111)))), ((int)(((byte)(180)))));
            this.leftPanelButton3.TextRectangleTopPadding = 10;
            this.leftPanelButton3.Click += new System.EventHandler(this.leftPanelButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(650, 420);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private GraphExtensions.LeftPanelButton leftPanelButton1;
        private GraphExtensions.LeftPanelButton leftPanelButton3;
        private GraphExtensions.LeftPanelButton leftPanelButton2;
    }
}

