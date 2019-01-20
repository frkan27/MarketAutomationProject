namespace Market.WFA
{
    partial class ÜrünSatis
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
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.lstSatıs = new System.Windows.Forms.ListBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.nudPoset = new System.Windows.Forms.NumericUpDown();
            this.cbPoset = new System.Windows.Forms.CheckBox();
            this.gbOdemeTipi = new System.Windows.Forms.GroupBox();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.rbKredi = new System.Windows.Forms.RadioButton();
            this.pnlNakit = new System.Windows.Forms.Panel();
            this.nudAlinanPara = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblParaUstu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnİslem = new System.Windows.Forms.Button();
            this.cmsSatis = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoset)).BeginInit();
            this.gbOdemeTipi.SuspendLayout();
            this.pnlNakit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlinanPara)).BeginInit();
            this.cmsSatis.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(15, 12);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(380, 186);
            this.lstUrunler.TabIndex = 0;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // lstSatıs
            // 
            this.lstSatıs.ContextMenuStrip = this.cmsSatis;
            this.lstSatıs.FormattingEnabled = true;
            this.lstSatıs.Location = new System.Drawing.Point(470, 12);
            this.lstSatıs.Name = "lstSatıs";
            this.lstSatıs.Size = new System.Drawing.Size(268, 290);
            this.lstSatıs.TabIndex = 1;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(78, 218);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(133, 20);
            this.txtBarkod.TabIndex = 2;
            this.txtBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyDown);
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(226, 219);
            this.nudAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(57, 20);
            this.nudAdet.TabIndex = 3;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.ValueChanged += new System.EventHandler(this.nudAdet_ValueChanged);
            // 
            // nudPoset
            // 
            this.nudPoset.Enabled = false;
            this.nudPoset.Location = new System.Drawing.Point(226, 263);
            this.nudPoset.Name = "nudPoset";
            this.nudPoset.Size = new System.Drawing.Size(57, 20);
            this.nudPoset.TabIndex = 4;
            this.nudPoset.ValueChanged += new System.EventHandler(this.nudPoset_ValueChanged);
            // 
            // cbPoset
            // 
            this.cbPoset.AutoSize = true;
            this.cbPoset.Location = new System.Drawing.Point(303, 266);
            this.cbPoset.Name = "cbPoset";
            this.cbPoset.Size = new System.Drawing.Size(53, 17);
            this.cbPoset.TabIndex = 5;
            this.cbPoset.Text = "Poset";
            this.cbPoset.UseVisualStyleBackColor = true;
            this.cbPoset.CheckedChanged += new System.EventHandler(this.cbPoset_CheckedChanged);
            // 
            // gbOdemeTipi
            // 
            this.gbOdemeTipi.Controls.Add(this.rbKredi);
            this.gbOdemeTipi.Controls.Add(this.rbNakit);
            this.gbOdemeTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbOdemeTipi.Location = new System.Drawing.Point(15, 299);
            this.gbOdemeTipi.Name = "gbOdemeTipi";
            this.gbOdemeTipi.Size = new System.Drawing.Size(380, 60);
            this.gbOdemeTipi.TabIndex = 6;
            this.gbOdemeTipi.TabStop = false;
            this.gbOdemeTipi.Text = "Ödeme Tipi";
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbNakit.Location = new System.Drawing.Point(103, 27);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(116, 20);
            this.rbNakit.TabIndex = 7;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit Ödeme";
            this.rbNakit.UseVisualStyleBackColor = true;
            this.rbNakit.CheckedChanged += new System.EventHandler(this.rbNakit_CheckedChanged);
            // 
            // rbKredi
            // 
            this.rbKredi.AutoSize = true;
            this.rbKredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKredi.Location = new System.Drawing.Point(254, 27);
            this.rbKredi.Name = "rbKredi";
            this.rbKredi.Size = new System.Drawing.Size(97, 20);
            this.rbKredi.TabIndex = 8;
            this.rbKredi.TabStop = true;
            this.rbKredi.Text = "Kredi Kartı";
            this.rbKredi.UseVisualStyleBackColor = true;
            // 
            // pnlNakit
            // 
            this.pnlNakit.Controls.Add(this.label2);
            this.pnlNakit.Controls.Add(this.label3);
            this.pnlNakit.Controls.Add(this.lblParaUstu);
            this.pnlNakit.Controls.Add(this.nudAlinanPara);
            this.pnlNakit.Location = new System.Drawing.Point(15, 374);
            this.pnlNakit.Name = "pnlNakit";
            this.pnlNakit.Size = new System.Drawing.Size(380, 64);
            this.pnlNakit.TabIndex = 7;
            this.pnlNakit.Visible = false;
            // 
            // nudAlinanPara
            // 
            this.nudAlinanPara.DecimalPlaces = 2;
            this.nudAlinanPara.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudAlinanPara.Location = new System.Drawing.Point(114, 18);
            this.nudAlinanPara.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudAlinanPara.Name = "nudAlinanPara";
            this.nudAlinanPara.Size = new System.Drawing.Size(57, 20);
            this.nudAlinanPara.TabIndex = 4;
            this.nudAlinanPara.ValueChanged += new System.EventHandler(this.nudAlinanPara_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Barkod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Alınan Para";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(192, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Para Üstü";
            // 
            // lblParaUstu
            // 
            this.lblParaUstu.AutoSize = true;
            this.lblParaUstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParaUstu.Location = new System.Drawing.Point(297, 22);
            this.lblParaUstu.Name = "lblParaUstu";
            this.lblParaUstu.Size = new System.Drawing.Size(54, 16);
            this.lblParaUstu.TabIndex = 11;
            this.lblParaUstu.Text = "0,00TL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(537, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Toplam :";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(612, 330);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(0, 16);
            this.lblToplam.TabIndex = 10;
            // 
            // btnİslem
            // 
            this.btnİslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİslem.Location = new System.Drawing.Point(479, 371);
            this.btnİslem.Name = "btnİslem";
            this.btnİslem.Size = new System.Drawing.Size(207, 62);
            this.btnİslem.TabIndex = 11;
            this.btnİslem.Text = "İşlemTamam";
            this.btnİslem.UseVisualStyleBackColor = true;
            this.btnİslem.Click += new System.EventHandler(this.btnİslem_Click);
            // 
            // cmsSatis
            // 
            this.cmsSatis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.cmsSatis.Name = "cmsSatis";
            this.cmsSatis.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // ÜrünSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnİslem);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlNakit);
            this.Controls.Add(this.gbOdemeTipi);
            this.Controls.Add(this.cbPoset);
            this.Controls.Add(this.nudPoset);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.lstSatıs);
            this.Controls.Add(this.lstUrunler);
            this.Name = "ÜrünSatis";
            this.Text = "ÜrünSatis";
            this.Load += new System.EventHandler(this.ÜrünSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoset)).EndInit();
            this.gbOdemeTipi.ResumeLayout(false);
            this.gbOdemeTipi.PerformLayout();
            this.pnlNakit.ResumeLayout(false);
            this.pnlNakit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlinanPara)).EndInit();
            this.cmsSatis.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.ListBox lstSatıs;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.NumericUpDown nudPoset;
        private System.Windows.Forms.CheckBox cbPoset;
        private System.Windows.Forms.GroupBox gbOdemeTipi;
        private System.Windows.Forms.RadioButton rbKredi;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.Panel pnlNakit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblParaUstu;
        private System.Windows.Forms.NumericUpDown nudAlinanPara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnİslem;
        private System.Windows.Forms.ContextMenuStrip cmsSatis;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}