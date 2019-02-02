using Market.BLL.Repository;
using Market.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void cmbAylar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seciliYil = Convert.ToInt32(cmbYillarAylik.SelectedItem);
            if (cmbYillarAylik.SelectedItem == null)
            {
                if (cmbAylar.SelectedIndex != -1) { cmbAylar.SelectedIndex = -1; return; }
                //MessageBox.Show("Lütfen önce yıl seçiniz");
                return;
            }
            var seciliAy = Convert.ToInt32(cmbAylar.SelectedItem);
            AylikSatislar(seciliAy, seciliYil);
        }

        private void cmbYillarAylik_SelectedIndexChanged(object sender, EventArgs e)
        {

            dgvAylik.Columns.Clear();
            cmbAylar.SelectedIndex = -1;
        }
        public void AylikSatislar(int ay, int yil)
        {
            var kategoriler = new KategoriRepo().GetAll();
            var satis = new SatisRepo().GetAll();
            var satisDetay = new SatisDetayRepo().GetAll();
            var urunler = new UrunRepo().GetAll();

            if (cbAylar.Checked)
            {
                var aylikSatisListesi = from u in urunler
                                        join k in kategoriler on u.KategoriId equals k.KategoriId
                                        join sd in satisDetay on u.UrunId equals sd.UrunId
                                        join s in satis on sd.SatisId equals s.SatisId
                                        where s.SatisZamani.Month == ay && s.SatisZamani.Year == yil
                                        group new
                                        {
                                            k,
                                            u,
                                            sd,
                                            s
                                        } by new
                                        {
                                            k.KategoriId,
                                            k.KategoriAdi,
                                            u.BirimFiyat,
                                            k.KarPayi
                                        }
                                     into gp
                                        orderby gp.Key.KategoriId
                                        select new
                                        {
                                            gp.Key.KategoriId,
                                            gp.Key.KategoriAdi,
                                            ToplamAdet = gp.Sum(x => x.sd.Adet),
                                            ToplamKar = Math.Round((gp.Sum(x => x.sd.Adet) * gp.Key.BirimFiyat * gp.Key.KarPayi), 2)
                                        };

                dgvAylik.DataSource = aylikSatisListesi.ToList();
            }
            else
            {
                var aylikSatisListesi = from u in urunler
                                        join k in kategoriler on u.KategoriId equals k.KategoriId
                                        join sd in satisDetay on u.UrunId equals sd.UrunId
                                        join s in satis on sd.SatisId equals s.SatisId
                                        where s.SatisZamani.Month == ay && s.SatisZamani.Year == yil
                                        group new
                                        {
                                            k,
                                            u,
                                            sd,
                                            s
                                        } by new
                                        {
                                            u.UrunBarkod,
                                            k.KategoriAdi,
                                            u.UrunAdi,
                                            u.BirimFiyat,
                                            k.KarPayi
                                        }
                                     into gp
                                        orderby gp.Key.KategoriAdi
                                        select new
                                        {
                                            gp.Key.UrunBarkod,
                                            gp.Key.KategoriAdi,
                                            gp.Key.UrunAdi,
                                            Toplam = gp.Sum(x => x.sd.Adet),
                                            ToplamKar = Math.Round((gp.Sum(x => x.sd.Adet) * gp.Key.BirimFiyat * gp.Key.KarPayi), 2)
                                        };

                dgvAylik.DataSource = aylikSatisListesi.ToList();
            }


        }

        private void cmbYillar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seciliYil = Convert.ToInt32(cmbYillar.SelectedItem);
            YillikSatislar(seciliYil);
        }
        public void YillikSatislar(int yil)
        {
            var kategoriler = new KategoriRepo().GetAll();
            var satis = new SatisRepo().GetAll();
            var satisDetay = new SatisDetayRepo().GetAll();
            var urunler = new UrunRepo().GetAll();

            if (cbYillar.Checked)
            {
                var yillikSatisListesi = from u in urunler
                                         join k in kategoriler on u.KategoriId equals k.KategoriId
                                         join sd in satisDetay on u.UrunId equals sd.UrunId
                                         join s in satis on sd.SatisId equals s.SatisId
                                         where s.SatisZamani.Year == yil
                                         group new
                                         {
                                             k,
                                             u,
                                             sd,
                                             s
                                         } by new
                                         {
                                             k.KategoriId,
                                             k.KategoriAdi,
                                             u.BirimFiyat,
                                             k.KarPayi
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

                dgvYillikSatislar.DataSource = yillikSatisListesi.ToList();
            }
            else
            {
                var yillikSatisListesi = from u in urunler
                                         join k in kategoriler on u.KategoriId equals k.KategoriId
                                         join sd in satisDetay on u.UrunId equals sd.UrunId
                                         join s in satis on sd.SatisId equals s.SatisId
                                         where s.SatisZamani.Year == yil
                                         group new
                                         {
                                             k,
                                             u,
                                             sd,
                                             s
                                         } by new
                                         {
                                             u.UrunId,
                                             u.UrunBarkod,
                                             k.KategoriAdi,
                                             u.UrunAdi,
                                             u.BirimFiyat,
                                             k.KarPayi
                                         }
                                     into gp
                                         orderby gp.Key.KategoriAdi
                                         select new
                                         {
                                             gp.Key.UrunId,
                                             gp.Key.UrunBarkod,
                                             gp.Key.UrunAdi,
                                             Toplam = gp.Sum(x => x.sd.Adet),
                                             ToplamKar = Math.Round((gp.Sum(x => x.sd.Adet) * gp.Key.BirimFiyat * gp.Key.KarPayi), 2)
                                         };

                dgvYillikSatislar.DataSource = yillikSatisListesi.ToList();
            }


        }

        private void rbNakit_CheckedChanged(object sender, EventArgs e)
        {
            var secilirb = OdemeTipi.Nakit;
            OdemeYontemiGetir(secilirb);
        }

        private void rbKredi_CheckedChanged(object sender, EventArgs e)
        {
            var secilirb = OdemeTipi.KrediKarti;
            OdemeYontemiGetir(secilirb);
        }
        private void OdemeYontemiGetir(OdemeTipi odeme)
        {
            var satis = new SatisRepo().GetAll();
            var satisDetay = new SatisDetayRepo().GetAll();
            var urun = new UrunRepo().GetAll();
            var kategoriler = new KategoriRepo().GetAll();

            var kksatisliste = from s in satis
                               join sd in satisDetay on s.SatisId equals sd.SatisId
                               join u in urun on sd.UrunId equals u.UrunId
                               join k in kategoriler on u.KategoriId equals k.KategoriId
                               where s.OdemeTipi == odeme
                               group new
                               {
                                   s,
                                   sd,
                                   u,
                                   k
                               }
                               by new
                               {
                                   s.SatisId,
                                   s.SatisZamani,
                                   s.OdemeTipi,
                                   u.BirimFiyat,
                                   k.KarPayi,
                                   k.KDV,
                                   sd.Adet,
                                   u.Indirim
                               }
                               into gp
                               orderby gp.Key.SatisId
                               select new
                               {
                                   gp.Key.SatisId,
                                   ToplamAdet = gp.Sum(x => x.sd.Adet),
                                   gp.Key.SatisZamani,
                                   gp.Key.OdemeTipi,
                                   ToplamSatis = Math.Round((gp.Sum(x => x.sd.Adet) * gp.Key.BirimFiyat * (1 + gp.Key.KDV) * (1 + gp.Key.KarPayi) * (1 - gp.Key.Indirim)), 2)
                               };
            dgvOdemeYontemi.DataSource = kksatisliste.ToList();
        }

        private void btnGunluk_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ToCsv(dgvGunluk, sfd.FileName);
                    MessageBox.Show("Excel e aktarma başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ToCsv(dgvStok, sfd.FileName);
                    MessageBox.Show("Excel e aktarma başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAylikExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ToCsv(dgvAylik, sfd.FileName);
                    MessageBox.Show("Excel e aktarma başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnYillikExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ToCsv(dgvYillikSatislar, sfd.FileName);
                    MessageBox.Show("Excel e aktarma başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ToCsv(DataGridView dGv, string filename)
        {
            string stOutput = "";
            string sHeaders = "";
            for (int j = 0; j < dGv.Columns.Count; j++)
            {
                sHeaders = sHeaders.ToString() + Convert.ToString(dGv.Columns[j].HeaderText) + "\t";
            }
            stOutput += sHeaders + "\r\n";
            for (int i = 0; i < dGv.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGv.Rows[i].Cells.Count; j++)
                {
                    stLine = stLine.ToString() + Convert.ToString(dGv.Rows[i].Cells[j].Value) + "\t";
                }
                stOutput += stLine + "\r\n";
            }

            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length);
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void cbGunluk_CheckedChanged(object sender, EventArgs e)
        {
            dtpTarih_ValueChanged(sender, e);
        }

        private void cbAylar_CheckedChanged(object sender, EventArgs e)
        {
            cmbAylar_SelectedIndexChanged(sender, e);
        }

        private void cbYillar_CheckedChanged(object sender, EventArgs e)
        {
            cmbYillar_SelectedIndexChanged(sender, e);
        }

        private void btnOdemeYonExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ToCsv(dgvOdemeYontemi, sfd.FileName);
                    MessageBox.Show("Excel e aktarma başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

