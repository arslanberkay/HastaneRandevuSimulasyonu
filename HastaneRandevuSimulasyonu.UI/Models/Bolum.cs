using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSimulasyonu.UI.Models
{
    public  class Bolum
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Aciklamasi { get; set; }

        public List<Doktor> Doktorlar { get; set; }

        public override string ToString()
        {
            return Adi;
        }
    }
}
