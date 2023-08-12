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
    public class HastaConfig:BaseConfig<Hasta>
    {
        public override void Configure(EntityTypeBuilder<Hasta> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.HastaAdi).HasMaxLength(50);
            builder.Property(p => p.HastaSoyadi).HasMaxLength(50);
            builder.Property(p => p.HastaTcNo).HasMaxLength(11);
            builder.Property(p => p.Cinsiyeti).HasMaxLength(10);
        }
    }
}
