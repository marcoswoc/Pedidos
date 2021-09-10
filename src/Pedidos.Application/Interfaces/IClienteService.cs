using Pedidos.Application.Models.Cliente;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Application.Interfaces
{
    public interface IClienteService
    {
        Task<ClienteDto> GetByIdAsync(int id);
        Task<ClienteDto> AddAsync(CreateClienteDto entity);
        Task<ClienteDto> UpdateAsync(UpdateClienteDto entity);
        Task RemoveAsync(int id);
        Task<IEnumerable<ClienteDto>> GetAllAsync();
    }
}
