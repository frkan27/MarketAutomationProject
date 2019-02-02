namespace Market.WFA
{
    partial class Raporlar
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStok = new System.Windows.Forms.TabPage();
            this.btnStok = new System.Windows.Forms.Button();
            this.dgvStok = new System.Windows.Forms.DataGridView();
            this.tabGunlukSatislar = new System.Windows.Forms.TabPage();
            this.cbGunluk = new System.Windows.Forms.CheckBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnGunluk = new System.Windows.Forms.Button();
            this.dgvGunluk = new System.Windows.Forms.DataGridView();
            this.tabAylikSatislar = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAylar = new System.Windows.Forms.ComboBox();
            this.cmbYillarAylik = new System.Windows.Forms.ComboBox();
            this.cbAylar = new System.Windows.Forms.CheckBox();
            this.btnAylikExcel = new System.Windows.Forms.Button();
            this.dgvAylik = new System.Windows.Forms.DataGridView();
            this.tabYillikSatislar = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbYillar = new System.Windows.Forms.ComboBox();
            this.cbYillar = new System.Windows.Forms.CheckBox();
            this.btnYillikExcel = new System.Windows.Forms.Button();
            this.dgvYillikSatislar = new System.Windows.Forms.DataGridView();
            this.tabOdemeDetaylari = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbKredi = new System.Windows.Forms.RadioButton();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOdemeYonExcel = new System.Windows.Forms.Button();
            this.dgvOdemeYontemi = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).BeginInit();
            this.tabGunlukSatislar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGunluk)).BeginInit();
            this.tabAylikSatislar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAylik)).BeginInit();
            this.tabYillikSatislar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYillikSatislar)).BeginInit();
            this.tabOdemeDetaylari.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeYontemi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabStok);
            this.tabControl1.Controls.Add(this.tabGunlukSatislar);
            this.tabControl1.Controls.Add(this.tabAylikSatislar);
            this.tabControl1.Controls.Add(this.tabYillikSatislar);
            this.tabControl1.Controls.Add(this.tabOdemeDetaylari);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1232, 749);
            this.tabControl1.TabIndex = 0;
            // 
            // tabStok
            // 
            this.tabStok.Controls.Add(this.btnStok);
            this.tabStok.Controls.Add(this.dgvStok);
            this.tabStok.Location = new System.Drawing.Point(4, 4);
            this.tabStok.Name = "tabStok";
            this.tabStok.Padding = new System.Windows.Forms.Padding(3);
            this.tabStok.Size = new System.Drawing.Size(1224, 723);
            this.tabStok.TabIndex = 0;
            this.tabStok.Text = "Stok";
            this.tabStok.UseVisualStyleBackColor = true;
            // 
            // btnStok
            // 
            this.btnStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStok.Location = new System.Drawing.Point(8, 8);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(102, 40);
            this.btnStok.TabIndex = 1;
            this.btnStok.Text = "Excel";
            this.btnStok.UseVisualStyleBackColor = true;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // dgvStok
            // 
            this.dgvStok.AllowUserToAddRows = false;
            this.dgvStok.AllowUserToDeleteRows = false;
            this.dgvStok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStok.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStok.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStok.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStok.Location = new System.Drawing.Point(3, 54);
            this.dgvStok.Name = "dgvStok";
            this.dgvStok.ReadOnly = true;
            this.dgvStok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStok.Size = new System.Drawing.Size(1218, 666);
            this.dgvStok.TabIndex = 0;
            // 
            // tabGunlukSatislar
            // 
            this.tabGunlukSatislar.Controls.Add(this.cbGunluk);
            this.tabGunlukSatislar.Controls.Add(this.dtpTarih);
            this.tabGunlukSatislar.Controls.Add(this.btnGunluk);
            this.tabGunlukSatislar.Controls.Add(this.dgvGunluk);
            this.tabGunlukSatislar.Location = new System.Drawing.Point(4, 4);
            this.tabGunlukSatislar.Name = "tabGunlukSatislar";
            this.tabGunlukSatislar.Padding = new System.Windows.Forms.Padding(3);
            this.tabGunlukSatislar.Size = new System.Drawing.Size(1224, 723);
            this.tabGunlukSatislar.TabIndex = 1;
            this.tabGunlukSatislar.Text = "Günlük Satışlar";
            this.tabGunlukSatislar.UseVisualStyleBackColor = true;
            // 
            // cbGunluk
            // 
            this.cbGunluk.AutoSize = true;
            this.cbGunluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbGunluk.Location = new System.Drawing.Point(832, 16);
            this.cbGunluk.Name = "cbGunluk";
            this.cbGunluk.Size = new System.Drawing.Size(150, 20);
            this.cbGunluk.TabIndex = 5;
            this.cbGunluk.Text = "Kategorilere Göre";
            this.cbGunluk.UseVisualStyleBackColor = true;
            this.cbGunluk.CheckedChanged += new System.EventHandler(this.cbGunluk_CheckedChanged);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(150, 16);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(148, 20);
            this.dtpTarih.TabIndex = 4;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // btnGunluk
            // 
            this.btnGunluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGunluk.Location = new System.Drawing.Point(8, 4);
            this.btnGunluk.Name = "btnGunluk";
            this.btnGunluk.Size = new System.Drawing.Size(102, 40);
            this.btnGunluk.TabIndex = 3;
            this.btnGunluk.Text = "Excel";
            this.btnGunluk.UseVisualStyleBackColor = true;
            this.btnGunluk.Click += new System.EventHandler(this.btnGunluk_Click);
            // 
            // dgvGunluk
            // 
            this.dgvGunluk.AllowUserToAddRows = false;
            this.dgvGunluk.AllowUserToDeleteRows = false;
            this.dgvGunluk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGunluk.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGunluk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGunluk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGunluk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGunluk.Location = new System.Drawing.Point(3, 50);
            this.dgvGunluk.MultiSelect = false;
            this.dgvGunluk.Name = "dgvGunluk";
            this.dgvGunluk.ReadOnly = true;
            this.dgvGunluk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGunluk.Size = new System.Drawing.Size(1218, 670);
            this.dgvGunluk.TabIndex = 2;
            // 
            // tabAylikSatislar
            // 
            this.tabAylikSatislar.Controls.Add(this.label2);
            this.tabAylikSatislar.Controls.Add(this.label1);
            this.tabAylikSatislar.Controls.Add(this.cmbAylar);
            this.tabAylikSatislar.Controls.Add(this.cmbYillarAylik);
            this.tabAylikSatislar.Controls.Add(this.cbAylar);
            this.tabAylikSatislar.Controls.Add(this.btnAylikExcel);
            this.tabAylikSatislar.Controls.Add(this.dgvAylik);
            this.tabAylikSatislar.Location = new System.Drawing.Point(4, 4);
            this.tabAylikSatislar.Name = "tabAylikSatislar";
            this.tabAylikSatislar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAylikSatislar.Size = new System.Drawing.Size(1224, 723);
            this.tabAylikSatislar.TabIndex = 2;
            this.tabAylikSatislar.Text = "Aylik Satışlar";
            this.tabAylikSatislar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(392, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ay Seçiniz :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(157, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Yıl Seçiniz :";
            // 
            // cmbAylar
            // 
            this.cmbAylar.FormattingEnabled = true;
            this.cmbAylar.Location = new System.Drawing.Point(500, 16);
            this.cmbAylar.Name = "cmbAylar";
            this.cmbAylar.Size = new System.Drawing.Size(121, 21);
            this.cmbAylar.TabIndex = 8;
            this.cmbAylar.SelectedIndexChanged += new System.EventHandler(this.cmbAylar_SelectedIndexChanged);
            // 
            // cmbYillarAylik
            // 
            this.cmbYillarAylik.FormattingEnabled = true;
            this.cmbYillarAylik.Location = new System.Drawing.Point(265, 18);
            this.cmbYillarAylik.Name = "cmbYillarAylik";
            this.cmbYillarAylik.Size = new System.Drawing.Size(121, 21);
            this.cmbYillarAylik.TabIndex = 7;
            this.cmbYillarAylik.SelectedIndexChanged += new System.EventHandler(this.cmbYillarAylik_SelectedIndexChanged);
            // 
            // cbAylar
            // 
            this.cbAylar.AutoSize = true;
            this.cbAylar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbAylar.Location = new System.Drawing.Point(822, 16);
            this.cbAylar.Name = "cbAylar";
            this.cbAylar.Size = new System.Drawing.Size(150, 20);
            this.cbAylar.TabIndex = 6;
            this.cbAylar.Text = "Kategorilere Göre";
            this.cbAylar.UseVisualStyleBackColor = true;
            this.cbAylar.CheckedChanged += new System.EventHandler(this.cbAylar_CheckedChanged);
            // 
            // btnAylikExcel
            // 
            this.btnAylikExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAylikExcel.Location = new System.Drawing.Point(8, 4);
            this.btnAylikExcel.Name = "btnAylikExcel";
            this.btnAylikExcel.Size = new System.Drawing.Size(102, 40);
            this.btnAylikExcel.TabIndex = 3;
            this.btnAylikExcel.Text = "Excel";
            this.btnAylikExcel.UseVisualStyleBackColor = true;
            this.btnAylikExcel.Click += new System.EventHandler(this.btnAylikExcel_Click);
            // 
            // dgvAylik
            // 
            this.dgvAylik.AllowUserToAddRows = false;
            this.dgvAylik.AllowUserToDeleteRows = false;
            this.dgvAylik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAylik.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAylik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAylik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAylik.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAylik.Location = new System.Drawing.Point(3, 50);
            this.dgvAylik.MultiSelect = false;
            this.dgvAylik.Name = "dgvAylik";
            this.dgvAylik.ReadOnly = true;
            this.dgvAylik.Size = new System.Drawing.Size(1218, 670);
            this.dgvAylik.TabIndex = 2;
            // 
            // tabYillikSatislar
            // 
            this.tabYillikSatislar.Controls.Add(this.label3);
            this.tabYillikSatislar.Controls.Add(this.cmbYillar);
            this.tabYillikSatislar.Controls.Add(this.cbYillar);
            this.tabYillikSatislar.Controls.Add(this.btnYillikExcel);
            this.tabYillikSatislar.Controls.Add(this.dgvYillikSatislar);
            this.tabYillikSatislar.Location = new System.Drawing.Point(4, 4);
            this.tabYillikSatislar.Name = "tabYillikSatislar";
            this.tabYillikSatislar.Padding = new System.Windows.Forms.Padding(3);
            this.tabYillikSatislar.Size = new System.Drawing.Size(1224, 723);
            this.tabYillikSatislar.TabIndex = 3;
            this.tabYillikSatislar.Text = "Yıllık Satışlar";
            this.tabYillikSatislar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(143, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Yıl Seçiniz :";
            // 
            // cmbYillar
            // 
            this.cmbYillar.FormattingEnabled = true;
            this.cmbYillar.Location = new System.Drawing.Point(251, 15);
            this.cmbYillar.Name = "cmbYillar";
            this.cmbYillar.Size = new System.Drawing.Size(121, 21);
            this.cmbYillar.TabIndex = 10;
            this.cmbYillar.SelectedIndexChanged += new System.EventHandler(this.cmbYillar_SelectedIndexChanged);
            // 
            // cbYillar
            // 
            this.cbYillar.AutoSize = true;
            this.cbYillar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbYillar.Location = new System.Drawing.Point(1040, 18);
            this.cbYillar.Name = "cbYillar";
            this.cbYillar.Size = new System.Drawing.Size(150, 20);
            this.cbYillar.TabIndex = 9;
            this.cbYillar.Text = "Kategorilere Göre";
            this.cbYillar.UseVisualStyleBackColor = true;
            this.cbYillar.CheckedChanged += new System.EventHandler(this.cbYillar_CheckedChanged);
            // 
            // btnYillikExcel
            // 
            this.btnYillikExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYillikExcel.Location = new System.Drawing.Point(8, 4);
            this.btnYillikExcel.Name = "btnYillikExcel";
            this.btnYillikExcel.Size = new System.Drawing.Size(102, 40);
            this.btnYillikExcel.TabIndex = 7;
            this.btnYillikExcel.Text = "Excel";
            this.btnYillikExcel.UseVisualStyleBackColor = true;
            this.btnYillikExcel.Click += new System.EventHandler(this.btnYillikExcel_Click);
            // 
            // dgvYillikSatislar
            // 
            this.dgvYillikSatislar.AllowUserToAddRows = false;
            this.dgvYillikSatislar.AllowUserToDeleteRows = false;
            this.dgvYillikSatislar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYillikSatislar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvYillikSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYillikSatislar.Location = new System.Drawing.Point(3, 74);
            this.dgvYillikSatislar.MultiSelect = false;
            this.dgvYillikSatislar.Name = "dgvYillikSatislar";
            this.dgvYillikSatislar.ReadOnly = true;
            this.dgvYillikSatislar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYillikSatislar.Size = new System.Drawing.Size(1218, 646);
            this.dgvYillikSatislar.TabIndex = 6;
            // 
            // tabOdemeDetaylari
            // 
            this.tabOdemeDetaylari.Controls.Add(this.panel1);
            this.tabOdemeDetaylari.Controls.Add(this.label4);
            this.tabOdemeDetaylari.Controls.Add(this.btnOdemeYonExcel);
            this.tabOdemeDetaylari.Controls.Add(this.dgvOdemeYontemi);
            this.tabOdemeDetaylari.Location = new System.Drawing.Point(4, 4);
            this.tabOdemeDetaylari.Name = "tabOdemeDetaylari";
            this.tabOdemeDetaylari.Size = new System.Drawing.Size(1224, 723);
            this.tabOdemeDetaylari.TabIndex = 4;
            this.tabOdemeDetaylari.Text = "Odeme Detayları";
            this.tabOdemeDetaylari.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbKredi);
            this.panel1.Controls.Add(this.rbNakit);
            this.panel1.Location = new System.Drawing.Point(284, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 46);
            this.panel1.TabIndex = 15;
            // 
            // rbKredi
            // 
            this.rbKredi.AutoSize = true;
            this.rbKredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKredi.Location = new System.Drawing.Point(106, 8);
            this.rbKredi.Name = "rbKredi";
            this.rbKredi.Size = new System.Drawing.Size(110, 24);
            this.rbKredi.TabIndex = 1;
            this.rbKredi.TabStop = true;
            this.rbKredi.Text = "Kredi Kartı";
            this.rbKredi.UseVisualStyleBackColor = true;
            this.rbKredi.CheckedChanged += new System.EventHandler(this.rbKredi_CheckedChanged);
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbNakit.Location = new System.Drawing.Point(3, 8);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(68, 24);
            this.rbNakit.TabIndex = 0;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            this.rbNakit.CheckedChanged += new System.EventHandler(this.rbNakit_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(129, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ödeme Yöntemi";
            // 
            // btnOdemeYonExcel
            // 
            this.btnOdemeYonExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeYonExcel.Location = new System.Drawing.Point(8, 2);
            this.btnOdemeYonExcel.Name = "btnOdemeYonExcel";
            this.btnOdemeYonExcel.Size = new System.Drawing.Size(102, 40);
            this.btnOdemeYonExcel.TabIndex = 13;
            this.btnOdemeYonExcel.Text = "Excel";
            this.btnOdemeYonExcel.UseVisualStyleBackColor = true;
            this.btnOdemeYonExcel.Click += new System.EventHandler(this.btnOdemeYonExcel_Click);
            // 
            // dgvOdemeYontemi
            // 
            this.dgvOdemeYontemi.AllowUserToAddRows = false;
            this.dgvOdemeYontemi.AllowUserToDeleteRows = false;
            this.dgvOdemeYontemi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOdemeYontemi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOdemeYontemi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOdemeYontemi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdemeYontemi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOdemeYontemi.Location = new System.Drawing.Point(0, 70);
            this.dgvOdemeYontemi.MultiSelect = false;
            this.dgvOdemeYontemi.Name = "dgvOdemeYontemi";
            this.dgvOdemeYontemi.ReadOnly = true;
            this.dgvOdemeYontemi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOdemeYontemi.Size = new System.Drawing.Size(1224, 653);
            this.dgvOdemeYontemi.TabIndex = 12;
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 749);
            this.Controls.Add(this.tabControl1);
            this.Name = "Raporlar";
            this.Text = "Raporlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Raporlar_Activated);
            this.Load += new System.EventHandler(this.Raporlar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabStok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).EndInit();
            this.tabGunlukSatislar.ResumeLayout(false);
            this.tabGunlukSatislar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGunluk)).EndInit();
            this.tabAylikSatislar.ResumeLayout(false);
            this.tabAylikSatislar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAylik)).EndInit();
            this.tabYillikSatislar.ResumeLayout(false);
            this.tabYillikSatislar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYillikSatislar)).EndInit();
            this.tabOdemeDetaylari.ResumeLayout(false);
            this.tabOdemeDetaylari.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeYontemi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStok;
        private System.Windows.Forms.TabPage tabGunlukSatislar;
        private System.Windows.Forms.TabPage tabAylikSatislar;
        private System.Windows.Forms.TabPage tabYillikSatislar;
        private System.Windows.Forms.TabPage tabOdemeDetaylari;
        private System.Windows.Forms.DataGridView dgvStok;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.CheckBox cbGunluk;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnGunluk;
        private System.Windows.Forms.DataGridView dgvGunluk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAylar;
        private System.Windows.Forms.ComboBox cmbYillarAylik;
        private System.Windows.Forms.CheckBox cbAylar;
        private System.Windows.Forms.Button btnAylikExcel;
        private System.Windows.Forms.DataGridView dgvAylik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbYillar;
        private System.Windows.Forms.CheckBox cbYillar;
        private System.Windows.Forms.Button btnYillikExcel;
        private System.Windows.Forms.DataGridView dgvYillikSatislar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbKredi;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOdemeYonExcel;
        private System.Windows.Forms.DataGridView dgvOdemeYontemi;
    }
}