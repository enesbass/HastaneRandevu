using HastaneRandevu.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevu.Entity.Concrete
{
    public class Randevu: BaseEntity
    {
        public DateTime RandevuTarihi { get; set; }
        public TimeSpan RandevuSaati { get; set; }
        public int? HastaId { get; set; }
        public Hasta? Hasta { get; set; }
        public int? BolumId { get; set; }
        public Bolum? Bolum { get; set; }
        public int? DoktorId { get; set; }
        public Doktor? Doktor { get; set; }


    }
}
