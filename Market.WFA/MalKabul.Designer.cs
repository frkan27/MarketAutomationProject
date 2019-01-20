namespace Market.WFA
{
    partial class MalKabul
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
            this.txtAra = new System.Windows.Forms.TextBox();
            this.tvUrunler = new System.Windows.Forms.TreeView();
            this.btnBarkodoku = new System.Windows.Forms.Button();
            this.lblBilgler = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.nudKDV = new System.Windows.Forms.NumericUpDown();
            this.nudKar = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.cmsÜrünİşlemleri = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudKDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKar)).BeginInit();
            this.cmsÜrünİşlemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(41, 50);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(145, 20);
            this.txtAra.TabIndex = 0;
            this.txtAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAra_KeyUp);
            // 
            // tvUrunler
            // 
            this.tvUrunler.Location = new System.Drawing.Point(41, 76);
            this.tvUrunler.Name = "tvUrunler";
            this.tvUrunler.Size = new System.Drawing.Size(145, 259);
            this.tvUrunler.TabIndex = 1;
            this.tvUrunler.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvUrunler_AfterSelect);
            // 
            // btnBarkodoku
            // 
            this.btnBarkodoku.Location = new System.Drawing.Point(211, 50);
            this.btnBarkodoku.Name = "btnBarkodoku";
            this.btnBarkodoku.Size = new System.Drawing.Size(142, 47);
            this.btnBarkodoku.TabIndex = 2;
            this.btnBarkodoku.Text = "Barkod Oku";
            this.btnBarkodoku.UseVisualStyleBackColor = true;
            this.btnBarkodoku.Click += new System.EventHandler(this.btnBarkodoku_Click);
            // 
            // lblBilgler
            // 
            this.lblBilgler.AutoSize = true;
            this.lblBilgler.Location = new System.Drawing.Point(208, 119);
            this.lblBilgler.Name = "lblBilgler";
            this.lblBilgler.Size = new System.Drawing.Size(37, 13);
            this.lblBilgler.TabIndex = 3;
            this.lblBilgler.Text = "Bilgiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategori Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "KDV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kar";
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(614, 43);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(120, 20);
            this.txtKategoriAdi.TabIndex = 7;
            // 
            // nudKDV
            // 
            this.nudKDV.DecimalPlaces = 2;
            this.nudKDV.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudKDV.Location = new System.Drawing.Point(614, 92);
            this.nudKDV.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKDV.Name = "nudKDV";
            this.nudKDV.Size = new System.Drawing.Size(120, 20);
            this.nudKDV.TabIndex = 8;
            // 
            // nudKar
            // 
            this.nudKar.DecimalPlaces = 2;
            this.nudKar.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudKar.Location = new System.Drawing.Point(614, 136);
            this.nudKar.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKar.Name = "nudKar";
            this.nudKar.Size = new System.Drawing.Size(120, 20);
            this.nudKar.TabIndex = 9;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(485, 203);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(576, 203);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGüncelle.TabIndex = 11;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(670, 203);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cmsÜrünİşlemleri
            // 
            this.cmsÜrünİşlemleri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.cmsÜrünİşlemleri.Name = "cmsÜrünİşlemleri";
            this.cmsÜrünİşlemleri.Size = new System.Drawing.Size(121, 48);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // MalKabul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nudKar);
            this.Controls.Add(this.nudKDV);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBilgler);
            this.Controls.Add(this.btnBarkodoku);
            this.Controls.Add(this.tvUrunler);
            this.Controls.Add(this.txtAra);
            this.Name = "MalKabul";
            this.Text = "MalKabul";
            this.Load += new System.EventHandler(this.MalKabul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKar)).EndInit();
            this.cmsÜrünİşlemleri.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.TreeView tvUrunler;
        private System.Windows.Forms.Button btnBarkodoku;
        private System.Windows.Forms.Label lblBilgler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.NumericUpDown nudKDV;
        private System.Windows.Forms.NumericUpDown nudKar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ContextMenuStrip cmsÜrünİşlemleri;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
    }
}