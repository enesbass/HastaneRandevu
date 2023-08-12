using HastaneRandevu.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevu.Entity.Concrete
{
    public class Doktor:BaseEntity
    {
        public string DrAdi { get; set; }
        public string DrSoyadi { get; set; }
        public int? BolumId { get; set; }
        public Bolum? Bolum { get; set; }
        public ICollection<Hasta>? Hastalar { get; set; }
        public ICollection<Randevu>? Randevular { get; set; }
    }
}
