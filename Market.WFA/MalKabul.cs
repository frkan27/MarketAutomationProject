using Market.BLL.Repository;
using Market.Models.Entities;
using Market.WFA.Dialog;
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
    public partial class MalKabul : Form
    {
        public MalKabul()
        {
            InitializeComponent();
        }

        private void MalKabul_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;//ekranı tam kaplamasını sağlıyor.
            lblBilgler.Visible = true;
            this.ControlBox = false;
            KategorileriGetir();
        }

        private void KategorileriGetir()
        {
            tvUrunler.Nodes.Clear();
            var kategoriler = new KategoriRepo().GetAll().OrderBy(x => x.KategoriAdi).ToList();
            foreach (var kategori in kategoriler)
            {
                TreeNode node = new TreeNode(kategori.KategoriAdi);
                node.Tag = kategori.KategoriId;
                tvUrunler.Nodes.Add(node);
                if (kategori.Urunler.Count>0)//kategori classımdaki ürünler listesindeki ürünlerin sayısı.
                {
                    // 0dan büüykse ürünleri getirelim.
                    var urunler = new UrunRepo().GetAll(x => x.KategoriId == kategori.KategoriId).ToList();
                    foreach (var urun in urunler)
                    {
                        TreeNode subnode = new TreeNode(urun.UrunAdi);//treenode urunadı yazsın diye böyle ekliyoruz.
                        subnode.ContextMenuStrip = cmsÜrünİşlemleri;   //Bunun için Urun classında overrride etmemiz lazım.
                        subnode.Tag = urun.UrunId;
                        node.Nodes.Add(subnode);

                    }
                }
            }

            tvUrunler.ExpandAll();//dallara ayır.
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                new KategoriRepo().Insert(new Kategori()
                {
                    KategoriAdi = txtKategoriAdi.Text,
                    KarPayi=nudKar.Value,
                    KDV=nudKDV.Value
             
                });
                MessageBox.Show("Kategori ekleme basarılı");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            KategorileriGetir();
            FormuTemizle();
        }
        Kategori kategori;
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var seciliKategori = new KategoriRepo().Queryable().First(x => x.KategoriId == kategori.KategoriId);
                seciliKategori.KategoriAdi = txtKategoriAdi.Text;
                seciliKategori.KDV = nudKDV.Value;
                seciliKategori.KarPayi = nudKar.Value;
                new KategoriRepo().Update();
                MessageBox.Show("kategoriniz güncellenmiştir");
            }
            
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            KategorileriGetir();//GÜncel kategoriler gelsin diye tekrar cagırıyoruz.
            FormuTemizle();
        }

        private void FormuTemizle()
        {
            foreach (Control control in this.Controls)//formun içinde control tipinde dönüyoruz.
            {
                if (control is TextBox)
                {
                    if (control.Name == "txtAra")
                        continue;
                    else control.Text = string.Empty;
                }
                if (control is NumericUpDown nud)
                    nud.Value = 0;
                   

            }
            lblBilgler.Text = string.Empty;
        }

        private void btnBarkodoku_Click(object sender, EventArgs e)
        {
            BarkodOkuma barkod = new BarkodOkuma();

            DialogResult cevap = barkod.ShowDialog();//barkoduoku butununa tıkladığımda barkoduoku formu geliyor.show dialogla.

            if (cevap==DialogResult.OK)//enter a basınca olanlar.
            {
                UrunEkleForm urunEkle = new UrunEkleForm();
                urunEkle.Barkod(barkod.Barkod, barkod.KutuAdet);
                urunEkle.ShowDialog();//ürünekle formu geliyor.
                KategorileriGetir();
                   

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (kategori.Urunler.Count != 0)
                {
                    MessageBox.Show("bu kategori altında ürün olduğu için silemezsiniz.");
                }
                else
                {
                    new KategoriRepo().Delete(kategori);
                    MessageBox.Show(" basarıyla silindi.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            KategorileriGetir();
            FormuTemizle();
        }
        private int urunId;
        private int kategoriId;
        Urun urun;
        
        private void tvUrunler_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lblBilgler.Visible = true;
            FormuTemizle();
            if (e.Node == null) return;
            if(new UrunRepo().Queryable().FirstOrDefault(x=>x.UrunAdi==e.Node.Text)!=null)//treeview da secilen üründe yazanı ürün adına ata.
            {
                urunId = (int)e.Node.Tag;//secilen tag ın ıd sini ürünıd ye ata.
                urun = new UrunRepo().GetById(urunId);//urunıd 1 olan urunu yeni tanımladığımız urun e eşitle.
                if (urun == null) return;
                lblBilgler.Text= $"Ürün Adı:{urun.UrunAdi}\nBarkod No:{urun.UrunBarkod}\nBirim Fiyatı:{urun.BirimFiyat:c2}" + $"\nStok Miktarı:{urun.Stok} adet\nÜrün Kategorisi: {urun.Kategori}\nKutu Başına Adet:{urun.Adet}";

            }
            if(new KategoriRepo().Queryable().FirstOrDefault(x=> x.KategoriAdi==e.Node.Text) != null)
            {//treeview daki kategoriye tıklayınca bilgileri sağdaki texboxa ve nud lara yazdır.
                kategoriId =(int)e.Node.Tag;
                kategori= new KategoriRepo().GetById(kategoriId);
                if (kategori == null) return;
                txtKategoriAdi.Text = kategori.KategoriAdi;
                nudKar.Value = kategori.KarPayi;
                nudKDV.Value = kategori.KDV;
                lblBilgler.Text = $"Kategorideki ürünler : \n";
                foreach (var item in new UrunRepo().GetAll(x=>x.KategoriId==kategori.KategoriId))
                {
                    lblBilgler.Text += $"{item} {item.Stok} Adet\n ";
                }
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var urun = new UrunRepo().Queryable().First(x => x.UrunId == urunId);
                new UrunRepo().Delete(urun);
                MessageBox.Show("silme işlemi başarılı");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            KategorileriGetir();

        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunEkleForm urunEkle = new UrunEkleForm();
            urunEkle.urun = urun;
            DialogResult cevap = urunEkle.ShowDialog();
            if (cevap == DialogResult.OK)
                KategorileriGetir();
        }

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            FormuTemizle();
                string ara = txtAra.Text.ToLower();//txtara yazılan kelimeyi küçük harflerle yaz.

            List<Urun> bulunanlar = new List<Urun>();//bulunanlar diyeb iliste oluştur.
            new UrunRepo().Queryable().Where(x => x.UrunAdi.ToLower().Contains(ara) || x.UrunBarkod.ToLower().Contains(ara))
                .ToList()//urun adı ara stringindeki harfle esleşenleri getir listele.
                .ForEach(x => bulunanlar.Add(new Urun()
                {
                    UrunId=x.UrunId,
                    BirimFiyat=x.BirimFiyat,
                    KategoriId=x.KategoriId,
                    UrunAdi=x.UrunAdi,
                    Adet=x.Adet,
                    Indirim=x.Indirim,
                    Stok=x.Stok

                }));
            tvUrunler.Nodes.Clear();
            foreach (var bulunan in bulunanlar)
            {
                if(ara=="")//ara boşsa treeview ü temizle sonra kategorileri getir.
                {
                    tvUrunler.Nodes.Clear();
                    KategorileriGetir();
                }
                else
                {//boş değilse
                    TreeNode node = new TreeNode(bulunan.UrunAdi);//bulunan ürünün adını node a ata.
                    node.Tag = bulunan.UrunId;//bulunan ürünün ıd sini tag a ata.
                    node.ContextMenuStrip = cmsÜrünİşlemleri;
                    tvUrunler.Nodes.Add(node);//node u treeview a getir.yani ürünün adını.
                }

            }
            tvUrunler.ExpandAll();//ürün ağacını acıyor dallarını.
        }
    }
}
