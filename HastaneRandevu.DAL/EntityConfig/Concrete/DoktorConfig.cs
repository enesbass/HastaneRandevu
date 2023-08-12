using HastaneRandevu.DAL.EntityConfig.Abstract;
using HastaneRandevu.Entity.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevu.DAL.EntityConfig.Concrete
{
    public class DoktorConfig : BaseConfig<Doktor>
    {
        public override void Configure(EntityTypeBuilder<Doktor> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.DrAdi).HasMaxLength(50);
            builder.Property(p => p.DrSoyadi).HasMaxLength(50);
        }
    }
}
