using Market.BLL.Repository;
using Market.Models.Entities;
using Market.Models.Enums;
using Market.Models.ViewModels;
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
    public partial class ÜrünSatis : Form
    {
        public ÜrünSatis()
        {
            InitializeComponent();
        }
        private List<SatisDetayViewModel> satislar = new List<SatisDetayViewModel>();
        private void ÜrünSatis_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.ControlBox = false;
            UrunleriGetir();
            ListeyiTemizle();
            SatislariGetir();
        }

        private void SatislariGetir()
        {
            lstSatıs.Items.Clear();
            foreach (var satis in satislar)
            {
                lstSatıs.Items.Add(satis);
            }
        }

        private void ListeyiTemizle()
        {
            nudAdet.Value = 1;
            nudPoset.Value = 0;
            cbPoset.CheckState = CheckState.Unchecked;
            txtBarkod.Clear();
            nudAlinanPara.Value = 0;
            rbNakit.Checked = false;
            rbKredi.Checked = false;

        }

        private void UrunleriGetir()
        {
            var urunler = new UrunRepo().GetAll().ToList();
            lstUrunler.DataSource = urunler;
        }

        private void btnİslem_Click(object sender, EventArgs e)
        {
            try
            {
                var yenisatis = new SatisRepo().Insert(new Satis()
                {
                  //  OdemeTipi=(OdemeTipi)selectedi
                });

                foreach (var satis in satislar)
                {
                    if (satis.UrunId == 0) continue;
                    new SatisDetayRepo().Insert(new SatisDetay()
                    {
                        //tüm satisları getir ve sonuncusunun id sini satişıd ye eşitle.
                        SatisId = new SatisRepo().GetAll().Last().SatisId,
                        UrunId=satis.UrunId,
                        Adet=satis.Adet,
                        SatisFiyati=satis.SatisFiyati


                    });

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }

        private void rbNakit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNakit.Checked == true) pnlNakit.Visible = true;
            else pnlNakit.Visible = false;
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            var urun = lstUrunler.SelectedItem as Urun;//seçtiğimiz ürünü ıd sine göre barkod nosunu txtbarkoda yazdırıyoruz.
            txtBarkod.Text = new UrunRepo().GetById(urun.UrunId).UrunBarkod.ToString();
            txtBarkod.Focus();//????????
            txtBarkod.Select(0, 0);
            txtBarkod.SelectionStart = txtBarkod.MaxLength;
        }
    }
}
