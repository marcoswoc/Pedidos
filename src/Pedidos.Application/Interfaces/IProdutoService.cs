using Pedidos.Application.Models.Produto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Application.Interfaces
{
    public interface IProdutoService
    {
        Task<ProdutoDto> GetByIdAsync(int id);
        Task<ProdutoDto> CreateAsync(CreateProdutoDto entity);
        Task<ProdutoDto> UpdateAsync(int id, CreateProdutoDto entity);
        Task RemoveAsync(int id);
        Task<IEnumerable<ProdutoDto>> GetAllAsync();
    }
}
