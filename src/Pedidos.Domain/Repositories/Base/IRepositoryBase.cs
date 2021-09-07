using Pedidos.Domain.Entity.Base;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using System.Threading.Tasks;

namespace Pedidos.Domain.Repositories.Base
{
    public interface IRepositoryBase<T> where T : EntityBase
    {
        Task<T> GetByIdAsync(int id);      
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> predicate);
    }
}
