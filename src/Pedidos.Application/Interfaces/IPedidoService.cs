using Pedidos.Application.Models.Pedido;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Application.Interfaces
{
    public interface IPedidoService
    {
        Task<PedidoDto> GetByIdAsync(int id);
        Task AddAsync(PedidoDto entity);
        Task AddRangeAsync(IEnumerable<PedidoDto> entities);
        Task UpdateAsync(PedidoDto entity);
        Task RemoveAsync(int id);
        Task<IEnumerable<PedidoDto>> GetAllAsync();
    }
}
