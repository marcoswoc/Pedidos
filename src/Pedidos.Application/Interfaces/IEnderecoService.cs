using Pedidos.Application.Models.Endereco;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Application.Interfaces
{
    public interface IEnderecoService 
    {
        Task<EnderecoDto> GetByIdAsync(int id);
        Task<EnderecoDto> AddAsync(CreateEnderecoDto entity);
        Task<EnderecoDto> UpdateAsync(UpdateEnderecoDto entity);
        Task RemoveAsync(int id);
        Task<IEnumerable<EnderecoDto>> GetAllAsync();
    }
}
