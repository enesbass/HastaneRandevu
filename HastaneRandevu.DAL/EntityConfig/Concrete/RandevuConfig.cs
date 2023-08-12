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
    public class RandevuConfig : BaseConfig<Randevu>
    {
        public override void Configure(EntityTypeBuilder<Randevu> builder)
        {
            base.Configure(builder);
        }
    }
}
