using Market.BLL.Repository;
using Market.Models.Entities;
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
    public partial class UrunEkleForm : Form
    {
        public UrunEkleForm()
        {
            InitializeComponent();
        }
        int kutuAdet;
        public Urun urun;
        bool yeniUrunMu = true;

        public void Barkod(string brk,int adet)// ??????
        {
            txtBarkod.Text = brk;
            kutuAdet = adet;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {



            if (yeniUrunMu)
            {
                var secili = cmbKategori.SelectedItem as Kategori;


                try
                {
                    new UrunRepo().Insert(new Urun()
                    {
                        UrunBarkod = txtBarkod.Text,
                        UrunAdi = txtUrun.Text,
                        KategoriId = secili.KategoriId,//Ürünün kategoriıd sini sectiğimiz kategorinin ıd si ile eşitliyoruz.
                        Adet = Convert.ToInt32(nudAdet.Value),
                        BirimFiyat = nudFiyat.Value,
                        Stok = kutuAdet * Convert.ToInt32(nudAdet.Value)

                    });
                    MessageBox.Show("urun kaydı basarılı");
                    DialogResult = DialogResult.OK;//kaydettikten sonra formun kapanmasınısağlıyor.
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                } 
            }
            else
            {
                try
                {
                    //ürün güncelleme işlemi.
                    var seciliUrun = new UrunRepo().Queryable().First(x => x.UrunBarkod == txtBarkod.Text);
                    seciliUrun.UrunAdi = txtUrun.Text;
                    seciliUrun.BirimFiyat = nudFiyat.Value;
                    seciliUrun.Adet =Convert.ToInt32( nudAdet.Value);
                    seciliUrun.Indirim = nudİndirim.Value;
                    seciliUrun.Kategori.KategoriId = (cmbKategori.SelectedItem as Kategori).KategoriId;
                    new UrunRepo().Update();

                    MessageBox.Show("ürününüz güncellendi");
                    DialogResult = DialogResult.OK;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                



           }

        private void UrunEkleForm_Load(object sender, EventArgs e)
        {
            var kategoriler = new KategoriRepo().GetAll().ToList();//tüm kategorileri liste halinde getiriyoruz.
            cmbKategori.DataSource = kategoriler;//combobox a atuyoruz.
            cmbKategori.SelectedIndex = -1;//başlangıçta boş gözüksün diye.
            if (urun != null)
                UrunuGetir(urun);
        }

        private void UrunuGetir(Urun seciliUrun)// ??????
        {
            yeniUrunMu = false;
            txtBarkod.Text = seciliUrun.UrunBarkod;
            txtUrun.Text = seciliUrun.UrunAdi;
            nudFiyat.Value = seciliUrun.BirimFiyat;
            nudAdet.Value = seciliUrun.Adet;
            nudİndirim.Value = seciliUrun.Indirim;
            cmbKategori.Text = seciliUrun.Kategori.KategoriAdi;
        }
    }
    }

