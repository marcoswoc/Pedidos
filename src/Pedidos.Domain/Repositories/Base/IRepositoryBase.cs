using Pedidos.Domain.Entity.Base;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using System.Threading.Tasks;

namespace Pedidos.Domain.Repositories.Base
{
    public interface IRepositoryBase<T> where T : IEntityBase
    {
        Task<T> GetByIdAsync(int id);      
        Task<T> CreateAsync(T entity);
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
        Task<T> UpdateAsync(T entity);
        Task RemoveAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> predicate);
    }
}
