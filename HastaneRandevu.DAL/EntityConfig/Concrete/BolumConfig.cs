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
    public class BolumConfig:BaseConfig<Bolum>
    {
        public override void Configure(EntityTypeBuilder<Bolum> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.BolumAdi).HasMaxLength(50);
            builder.HasIndex(p => p.BolumAdi).IsUnique();
        }
    }
}
