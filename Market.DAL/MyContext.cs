﻿using Market.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.DAL
{
   public class MyContext:DbContext
    {
        public MyContext():base("name=MarketCon")
        {

        }


        public virtual DbSet<Urun> Urunler { get; set; } 
        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Satis> Satislar { get; set; }
        public virtual DbSet<SatisDetay> SatisDetaylar { get; set; }
    }
}
