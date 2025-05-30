﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSimulasyonu.UI.Models
{
    public class Doktor
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }

        public int BolumId { get; set; }
        public Bolum Bolum { get; set; }

        public List<Randevu> Randevular { get; set; }

        public override string ToString()
        {
            return Ad + " " + Soyad;
        }
    }
}
