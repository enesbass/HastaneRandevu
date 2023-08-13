using HastaneRandevu.BL.Abstract;
using HastaneRandevu.DAL.Repository.Abstract;
using HastaneRandevu.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevu.BL.Concrete
{
    public class RandevuManager : ManagerBase<Randevu>, IRandevuManager
    {
        public RandevuManager(IRandevuRepository repository) : base(repository)
        {
        }
    }
}
