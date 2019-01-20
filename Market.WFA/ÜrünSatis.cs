using iTextSharp.text;
using iTextSharp.text.pdf;
using Market.BLL.Repository;
using Market.Models.Entities;
using Market.Models.Enums;
using Market.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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
        private decimal ToplamHesapla()
        {
            lstSatıs.Items.Clear();
            foreach (var item in satislar)
            {
                lstSatıs.Items.Add(item);
            }
            var toplam = satislar.Sum(x => x.Toplam());
            lblToplam.Text = $"{toplam:c2}";
            return toplam;
        }

        private void btnİslem_Click(object sender, EventArgs e)
        {
            var radioButtons = gbOdemeTipi.Controls.OfType<RadioButton>().ToArray();
            if(!(rbKredi.Checked||rbKredi.Checked))
            {
                MessageBox.Show(" Öncelikle odeme tipi seçiniz.");
                return;
            }
            var selectedIndex = Array.IndexOf(radioButtons, radioButtons.Single(rb => rb.Checked));

            try
            {
                var yenisatis = new SatisRepo().Insert(new Satis()
                {
                    OdemeTipi = (OdemeTipi)selectedIndex
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
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF File|*.pdf", ValidateNames = true })
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A5.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        var urunsatis = lstSatıs.Items;

                        DateTime tarih = DateTime.Now;

                        iTextSharp.text.pdf.BaseFont Courier_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Courier", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);

                        iTextSharp.text.Font font = new iTextSharp.text.Font(Courier_Turkish, 12, iTextSharp.text.Font.NORMAL);

                        doc.Add(new Paragraph("ZAF BIRLESIK MAGAZALAR A.S \nBesiktas/ISTANBUL \nKuloglu Mh., Barbaros Blv. Yıldız Is Hanı No:9", font));
                        doc.Add(new Paragraph($"\nFis No:{new SatisRepo().GetAll().Last().SatisId}\nTarih:{tarih.ToString("dd.MM.yyyy")}\n Saat:{tarih.ToString("HH:mm:ss")}", font));
                        doc.Add(new Paragraph("\nÜrün adı                        Adet    KDV    Fiyat\n", font));
                        foreach (var item in urunsatis)
                        {
                            doc.Add(new Paragraph(item.ToString(), font));
                        }
                        doc.Add(new Paragraph($"\nToplam : {lblToplam.Text:c2}", font));
                        if (rbNakit.Checked == true)
                        {
                            doc.Add(new Paragraph($"Alınan Miktar: {nudAlinanPara.Value.ToString()}\nPara Üstü:{lblParaUstu.Text:c2}", font));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    finally
                    {
                        doc.Close();
                    }
                }

            MessageBox.Show("Satış başarılı");
            DialogResult = DialogResult.OK;
            ListeyiTemizle();
            SatislariGetir();




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

        private void nudAlinanPara_ValueChanged(object sender, EventArgs e)
        {
            lblParaUstu.Text = (nudAlinanPara.Value - ToplamHesapla()).ToString("C2", CultureInfo.CurrentCulture);//???
        }

        private void cbPoset_CheckedChanged(object sender, EventArgs e)
        {
            if(cbPoset.CheckState==CheckState.Checked)
            {
                nudPoset.Enabled = true;

                try
                {
                    satislar.Add(new SatisDetayViewModel()
                    {
                        UrunId = 0,
                        UrunAdi = "Peset",
                        Adet = (int)nudAdet.Value,
                        SatisFiyati=(decimal)0.25,
                        KDV=0,
                        İndirim=0

                    });

                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                nudPoset.Enabled = false;
                nudPoset.Value = 0;
                if (satislar.Contains(satislar.Find(x => x.UrunId.Equals(0))))
                    satislar.Remove(satislar.Find(x => x.UrunId.Equals(0)));
            }
            SatislariGetir();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstSatıs.SelectedItem == null) return;

            var seciliSatis = lstSatıs.SelectedItem as SatisDetayViewModel;
            new UrunRepo().GetById(seciliSatis.UrunId).Stok += seciliSatis.Adet;
            new UrunRepo().Update();
            satislar.Remove(seciliSatis);
            SatislariGetir();

        }

        private void nudPoset_ValueChanged(object sender, EventArgs e)
        {
            SatisDetayViewModel poset = satislar.Find(x => x.UrunId.Equals(0));
            poset.Adet = (int)nudPoset.Value;
            SatislariGetir();
            ToplamHesapla();
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if(lstUrunler.SelectedItem==null||txtBarkod.Text=="")
                {
                    MessageBox.Show("lütfen lsiteden bir ürünseçiniz");
                    return;
                }
                var seciliUrun = lstUrunler.SelectedItem as Urun;
                if(seciliUrun.Stok==0)
                {
                    MessageBox.Show("Ürününstoğu yok");
                    return;
                }
                if((int)nudAdet.Value>seciliUrun.Stok)
                {
                    MessageBox.Show("Stokta yeterli ürün yoktur");
                    return;
                }
                bool listedeMi = false;
                var listedekiUrun = new SatisDetayViewModel();
                foreach (var satisDetayView in satislar)
                {
                    if (seciliUrun.UrunId==satisDetayView.UrunId)
                    {
                        listedeMi = true;
                        listedekiUrun = satisDetayView;
                        break;
                    }

                }
                if(listedeMi)
                {
                    var urun = new UrunRepo().GetById(seciliUrun.UrunId);
                    if ((int)nudAdet.Value<=urun.Stok)
                    {
                        listedekiUrun.Adet += (int)nudAdet.Value;
                        urun.Stok -= (int)nudAdet.Value;
                        new UrunRepo().Update();

                    }
                    else
                    {
                        MessageBox.Show("Stokta bu kadar ürün yok!");
                        return;
                    }

                }
                else
                {
                    satislar.Add(new SatisDetayViewModel()
                    {
                        UrunId = seciliUrun.UrunId,
                        İndirim = seciliUrun.Indirim,
                        KDV = new KategoriRepo().GetById(seciliUrun.KategoriId).KDV,
                        Adet = (int)nudAdet.Value,
                        UrunAdi = seciliUrun.UrunAdi,
                        SatisFiyati = seciliUrun.BirimFiyat * (1 + seciliUrun.Kategori.KDV + seciliUrun.Kategori.KarPayi)

                    });
                    seciliUrun.Stok -= (int)nudAdet.Value;
                    new UrunRepo().Update();
                }
                ToplamHesapla();
                nudAdet.Value = 1;
                    




            }
        }

        private void nudAdet_ValueChanged(object sender, EventArgs e)
        {
            txtBarkod.Focus();
            txtBarkod.Select(0, 0);
            txtBarkod.SelectionStart = txtBarkod.MaxLength;
        }
    }
}
