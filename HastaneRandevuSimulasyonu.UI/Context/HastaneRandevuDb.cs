﻿using HastaneRandevuSimulasyonu.UI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSimulasyonu.UI.Context
{
    public class HastaneRandevuDb : DbContext
    {
        //Dbsetlerini yazdığım classları tablo olarak database taşıyorum.
        //migration : göç işlemi benim ilişkilerime göre verdiğim classları database taşınması için ayarlayan yerdir.
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<Doktor> Doktorlar { get; set; }
        public DbSet<Hasta> Hastalar { get; set; }
        public DbSet<Randevu> Randevular { get; set; }

        /// <summary>
        /// Burada connectionumu veriyorum (bağlantı)
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-C3QHSI5J\\SQLEXPRESS;database=HastaneRandevuDb;trusted_connection=true;trustservercertificate=true");
        }
    }
}
