namespace Market.WFA.Dialog
{
    partial class BarkodOkuma
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
            this.pbBarkod = new System.Windows.Forms.PictureBox();
            this.nudkutuadet = new System.Windows.Forms.NumericUpDown();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarkod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudkutuadet)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBarkod
            // 
            this.pbBarkod.Location = new System.Drawing.Point(231, 59);
            this.pbBarkod.Name = "pbBarkod";
            this.pbBarkod.Size = new System.Drawing.Size(297, 164);
            this.pbBarkod.TabIndex = 0;
            this.pbBarkod.TabStop = false;
            // 
            // nudkutuadet
            // 
            this.nudkutuadet.Location = new System.Drawing.Point(368, 282);
            this.nudkutuadet.Name = "nudkutuadet";
            this.nudkutuadet.Size = new System.Drawing.Size(45, 20);
            this.nudkutuadet.TabIndex = 1;
            this.nudkutuadet.ValueChanged += new System.EventHandler(this.nudkutuadet_ValueChanged);
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(241, 356);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(250, 20);
            this.txtBarkod.TabIndex = 2;
            this.txtBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyDown);
            this.txtBarkod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(284, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kutu";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.Location = new System.Drawing.Point(35, 275);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(86, 24);
            this.lblUrunAdi.TabIndex = 4;
            this.lblUrunAdi.Text = "UrunAdi";
            // 
            // BarkodOkuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.nudkutuadet);
            this.Controls.Add(this.pbBarkod);
            this.Name = "BarkodOkuma";
            this.Text = "BarkodOkuma";
            this.Load += new System.EventHandler(this.BarkodOkuma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBarkod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudkutuadet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBarkod;
        private System.Windows.Forms.NumericUpDown nudkutuadet;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUrunAdi;
    }
}