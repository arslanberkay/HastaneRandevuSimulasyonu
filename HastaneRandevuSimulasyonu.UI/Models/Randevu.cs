using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSimulasyonu.UI.Models
{
    public   class Randevu
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }

        public int HastaId { get; set; }
        public Hasta Hasta { get; set; }

        public int DoktorId { get; set; }
        public Doktor Doktor { get; set; }
    }
}
