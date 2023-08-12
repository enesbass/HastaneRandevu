using HastaneRandevu.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevu.Entity.Concrete
{
    public class Bolum:BaseEntity
    {
        public string BolumAdi { get; set; }
        public ICollection<Doktor>? Doktorlar { get;}
        public ICollection<Randevu>? Randevular { get; set; }
    }
}
