using Pedidos.Application.Models.Produto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Application.Interfaces
{
    public interface IProdutoService
    {
        Task<ProdutoDto> GetByIdAsync(int id);
        Task AddAsync(ProdutoDto entity);
        Task AddRangeAsync(IEnumerable<ProdutoDto> entities);
        Task UpdateAsync(ProdutoDto entity);
        Task RemoveAsync(int id);
        Task<IEnumerable<ProdutoDto>> GetAllAsync();
    }
}
