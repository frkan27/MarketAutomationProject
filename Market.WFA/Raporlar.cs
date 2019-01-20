using Market.BLL.Repository;
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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        private void Raporlar_Activated(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = -1;
            cmbAylar.SelectedIndex = -1;
            cmbYillar.SelectedIndex = -1;
            cmbYillarAylik.SelectedIndex = -1;
            dtpTarih.Value = DateTime.Now;
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.ControlBox = false;
            tabControl1.SelectedIndex = -1;
        }

        private void Stok()
        {
            var urunler = new UrunRepo().GetAll();
            var kategoriler = new KategoriRepo().GetAll();

            var urunliste = from u in urunler
                            join k in kategoriler on u.KategoriId equals k.KategoriId
                            orderby k.KategoriId
                            select new
                            {
                                u.UrunBarkod,
                                k.KategoriAdi,
                                u.UrunAdi,
                                u.Indirim,
                                u.Adet,
                                u.BirimFiyat,
                                u.Stok
                            };
            dgvStok.DataSource = urunliste.ToList();

            foreach (DataGridViewRow satir in dgvStok.Rows)
            {
                if (Convert.ToInt32(satir.Cells[6].Value) < 100)
                {//stok miktarı 100 un altına düşerse rengi deüğişssin.
                    satir.DefaultCellStyle.BackColor = Color.DarkSalmon;
                }
            }
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            var tarih = dtpTarih.Value;
            GunlukSatislar(tarih);
        }

        private void GunlukSatislar(DateTime tarih)
        {
            var kategoriler = new KategoriRepo().GetAll();
            var satis = new SatisRepo().GetAll();
            var satisDetay = new SatisDetayRepo().GetAll();
            var urunler = new UrunRepo().GetAll();

            if (cbGunluk.Checked)
            {
                var gunlukSatisListele = from u in urunler
                                         join k in kategoriler on u.KategoriId equals k.KategoriId
                                         join sd in satisDetay on u.UrunId equals sd.UrunId
                                         join s in satis on sd.SatisId equals s.SatisId
                                         where s.SatisZamani.ToShortDateString() == tarih.ToShortDateString()
                                         group new
                                         {
                                             u,
                                             k,
                                             sd,
                                             s
                                         } by new
                                         {
                                             k.KategoriAdi,
                                             k.KarPayi,
                                             k.KategoriId,
                                             u.BirimFiyat
                                         }
                                       into gp
                                         orderby gp.Key.KategoriAdi
                                         select new
                                         {
                                             gp.Key.KategoriId,
                                             gp.Key.KategoriAdi,
                                             Toplam = gp.Sum(x => x.sd.Adet),
                                             ToplamKar = Math.Round((gp.Sum(x => x.sd.Adet) * gp.Key.BirimFiyat * gp.Key.KarPayi), 2)

                                         };
                dgvGunluk.DataSource = gunlukSatisListele.ToList();


            }
            else
            {
                var gunlukSatisListesi = from u in urunler
                                         join k in kategoriler on u.KategoriId equals k.KategoriId
                                         join sd in satisDetay on u.UrunId equals sd.UrunId
                                         join s in satis on sd.SatisId equals s.SatisId
                                         where s.SatisZamani.ToShortDateString() == tarih.ToShortDateString()
                                         group new
                                         {
                                             k,
                                             u,
                                             sd,
                                             s
                                         } by new
                                         {
                                             u.UrunBarkod,
                                             k.KategoriAdi,//tabloda kullancaklarımızı burda seçiyoruz.
                                             u.UrunAdi,
                                             k.KarPayi,
                                             u.BirimFiyat,
                                             u.UrunId
                                         }
                                       into gp
                                         orderby gp.Key.KategoriAdi
                                         select new
                                         {
                                             gp.Key.UrunId,//tabloda bu baslıklarda sıralanıyor.
                                             gp.Key.UrunBarkod,
                                             gp.Key.UrunAdi,
                                             gp.Key.KategoriAdi,
                                             SatışAdedi = gp.Sum(x => x.sd.Adet),
                                             ToplamKar = Math.Round((gp.Sum(x => x.sd.Adet) * gp.Key.BirimFiyat * gp.Key.KarPayi), 2)
                                         };
                dgvGunluk.DataSource = gunlukSatisListesi.ToList();





            }
        }
    }
}
