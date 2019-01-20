using Market.BLL.HazirData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        public MalKabul malKabul;
        public ÜrünSatis urunSatis;

        private void MalKabulToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (malKabul == null || malKabul.IsDisposed)
            {
                malKabul = new MalKabul()
                {
                    MdiParent = this
                };
            malKabul.Show();
            }
            else malKabul.Activate();
        
        }

        private void ÇıkıştoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            new HazirData().VeriÜret();
        }

        private void SatışlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (urunSatis == null || urunSatis.IsDisposed)
            {
                urunSatis = new ÜrünSatis()
                {
                    MdiParent = this,
                };
                urunSatis.Show();
            }
            else urunSatis.Activate();

        }
    }
}
