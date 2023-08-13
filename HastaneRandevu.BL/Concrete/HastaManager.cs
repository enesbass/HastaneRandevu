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
    public class HastaManager : ManagerBase<Hasta>, IHastaManager
    {
        public HastaManager(IHastaRepository repository) : base(repository)
        {
        }
    }
}
