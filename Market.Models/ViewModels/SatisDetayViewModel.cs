using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.ViewModels
{
    public class SatisDetayViewModel
    {
        public int UrunId { get; set; }
        public int SatisId { get; set; }
        public int Adet { get; set; }
        public decimal SatisFiyati { get; set; }
        public string UrunAdi { get; set; }
        public decimal KDV { get; set; }
        public decimal İndirim { get; set; }
        public decimal Toplam()
        {
            return Adet * SatisFiyati;
        }
        public override string ToString()
        {
            string urunAdiStr = UrunAdi;
            if (UrunAdi.Length > 30)//urunadi 30 karakterden fazlaysa 27. den sonrasını ... yap.
                urunAdiStr = UrunAdi.Substring(0, 27) + "...";
            else
            {
                for (int i = 0; i < 30-UrunAdi.Length; i++)
                {
                    urunAdiStr += " ";//30 karakterden küçükse 30 a kadar boşluk koy.
                }
            }
            return $"{UrunAdi,-30} x {Adet,-6} %{KDV,-6} {Toplam():c2}";

           
           





        }

    }
}
