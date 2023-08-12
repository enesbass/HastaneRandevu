using HastaneRandevu.BL.Abstract;
using HastaneRandevu.DAL.Repository.Abstract;
using HastaneRandevu.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevu.BL.Concrete
{
    public class ManagerBase<T> : IManagerBase<T> where T : BaseEntity
    {
        private readonly IBaseRepository<T> repository;

        public ManagerBase(IBaseRepository<T> repository) 
        { 
            this.repository = repository;
        }
        public virtual async Task<int> InsertAsync(T entity)
        {
            return await repository.InsertAsync(entity);
        }

        public virtual async Task<int> UpdateAsync(T entity)
        {
            return await repository.UpdateAsync(entity);
        }
        public async Task<int> DeleteAsync(T entity)
        {
            return await repository.DeleteAsync(entity);
        }
        public async Task<T?> GetBy(Expression<Func<T, bool>> filter)
        {
            return await repository.GetBy(filter);
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await repository.GetByIdAsync(id);
        }


        public async Task<ICollection<T>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null)
        {
            return await repository.GetAllAsync(filter);
        }

        public async Task<IQueryable<T>> GetAllInclude(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] include)
        {
            return await repository.GetAllInclude(filter, include);
        }

        
    }
}
