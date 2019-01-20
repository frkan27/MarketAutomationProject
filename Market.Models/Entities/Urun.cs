using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.Entities
{
    [Table("Urunler")]
   public class Urun
    {
        [Key]
        public int UrunId { get; set; }

        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Barkod sadece rakamlardan oluşmalıdır.")]
        public string UrunBarkod { get; set; }
        [StringLength(50)]
        [Required]
        public string UrunAdi { get; set; }
        [Required]
        public decimal BirimFiyat { get; set; }
        public int Adet { get; set; }
        public int Stok { get; set; }
        public decimal Indirim { get; set; }


        public int KategoriId { get; set; }

        [ForeignKey("KategoriId")]
        public virtual Kategori Kategori { get; set; }


        public virtual ICollection<SatisDetay> SatisDetaylari { get; set; } = new HashSet<SatisDetay>();


        public override string ToString() => $"{UrunAdi}";
       

    }
}
