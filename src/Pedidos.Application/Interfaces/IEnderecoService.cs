using Pedidos.Application.Models.Endereco;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Application.Interfaces
{
    public interface IEnderecoService
    {
        Task<EnderecoDto> GetByIdAsync(int id);
        Task AddAsync(EnderecoDto entity);
        Task AddRangeAsync(IEnumerable<EnderecoDto> entities);
        Task UpdateAsync(EnderecoDto entity);
        Task RemoveAsync(int id);
        Task<IEnumerable<EnderecoDto>> GetAllAsync();
    }
}
