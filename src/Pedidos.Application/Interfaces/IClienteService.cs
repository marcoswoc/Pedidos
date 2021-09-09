using Pedidos.Application.Models.Cliente;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Application.Interfaces
{
    public interface IClienteService
    {
        Task<ClienteDto> GetByIdAsync(int id);
        Task AddAsync(ClienteDto entity);
        Task AddRangeAsync(IEnumerable<ClienteDto> entities);
        Task UpdateAsync(ClienteDto entity);
        Task RemoveAsync(int id);
        Task<IEnumerable<ClienteDto>> GetAllAsync();
    }
}
