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
    public class BolumManager : ManagerBase<Bolum>, IBolumManager
    {
        public BolumManager(IBolumRepository repository) : base(repository)
        {
        }
    }
}
