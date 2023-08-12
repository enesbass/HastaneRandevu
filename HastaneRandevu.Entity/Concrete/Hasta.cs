using HastaneRandevu.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevu.Entity.Concrete
{
    public class Hasta:BaseEntity
    {
        public string HastaAdi { get; set; }
        public string HastaSoyadi { get; set; }
        public string? Cinsiyeti { get; set; }
        public string HastaTcNo { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public ICollection<Doktor>? Doktorlar { get; set; }
        public ICollection<Randevu>? Randevular { get; set; }

    }
}
