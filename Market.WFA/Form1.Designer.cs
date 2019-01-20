namespace Market.WFA
{
    partial class AnaSayfa
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.İşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SatışlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MalKabulToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rAPORLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ÇıkıştoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.İşlemlerToolStripMenuItem,
            this.ÇıkıştoolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // İşlemlerToolStripMenuItem
            // 
            this.İşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SatışlarToolStripMenuItem,
            this.MalKabulToolStripMenuItem1,
            this.rAPORLARToolStripMenuItem});
            this.İşlemlerToolStripMenuItem.Name = "İşlemlerToolStripMenuItem";
            this.İşlemlerToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.İşlemlerToolStripMenuItem.Text = "İŞLEMLER";
            // 
            // SatışlarToolStripMenuItem
            // 
            this.SatışlarToolStripMenuItem.Name = "SatışlarToolStripMenuItem";
            this.SatışlarToolStripMenuItem.Size = new System.Drawing.Size(191, 30);
            this.SatışlarToolStripMenuItem.Text = "SATIŞLAR";
            this.SatışlarToolStripMenuItem.Click += new System.EventHandler(this.SatışlarToolStripMenuItem_Click);
            // 
            // MalKabulToolStripMenuItem1
            // 
            this.MalKabulToolStripMenuItem1.Name = "MalKabulToolStripMenuItem1";
            this.MalKabulToolStripMenuItem1.Size = new System.Drawing.Size(191, 30);
            this.MalKabulToolStripMenuItem1.Text = "MAL KABUL";
            this.MalKabulToolStripMenuItem1.Click += new System.EventHandler(this.MalKabulToolStripMenuItem1_Click);
            // 
            // rAPORLARToolStripMenuItem
            // 
            this.rAPORLARToolStripMenuItem.Name = "rAPORLARToolStripMenuItem";
            this.rAPORLARToolStripMenuItem.Size = new System.Drawing.Size(191, 30);
            this.rAPORLARToolStripMenuItem.Text = "RAPORLAR";
            // 
            // ÇıkıştoolStripMenuItem1
            // 
            this.ÇıkıştoolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ÇıkıştoolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.ÇıkıştoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ÇıkıştoolStripMenuItem1.ForeColor = System.Drawing.Color.Red;
            this.ÇıkıştoolStripMenuItem1.Name = "ÇıkıştoolStripMenuItem1";
            this.ÇıkıştoolStripMenuItem1.Size = new System.Drawing.Size(71, 29);
            this.ÇıkıştoolStripMenuItem1.Text = "ÇIKIŞ";
            this.ÇıkıştoolStripMenuItem1.Click += new System.EventHandler(this.ÇıkıştoolStripMenuItem1_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Market.WFA.Properties.Resources.market;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaSayfa";
            this.Text = "Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem İşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SatışlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MalKabulToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rAPORLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ÇıkıştoolStripMenuItem1;
    }
}

