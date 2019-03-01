using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace VBC.Service
{ 

    public interface IBaseService<TEntity, TViewModel> 
        where TEntity : class, new() 
        where TViewModel : class, new()
    {
        IQueryable<TViewModel> Get();
        IQueryable<TViewModel> Get(Expression<Func<TEntity, bool>> predicate);

        Task<TViewModel> CreateAsync(TViewModel data);
        Task<TViewModel> UpdateAsync(TViewModel data);
        Task DeleteAsync<TKey>(TKey id);
        Task<TViewModel> FirstOrDefaultAsync();
        Task<TViewModel> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

    }
}