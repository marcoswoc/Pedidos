using Pedidos.Application.Models.Pedido;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Application.Interfaces
{
    public interface IPedidoService
    {
        Task<PedidoDto> GetByIdAsync(int id);
        Task<PedidoDto> AddAsync(CreatePedidoDto entity);
        Task<PedidoDto> UpdateAsync(UpdatePedidoDto entity);
        Task RemoveAsync(int id);
        Task<IEnumerable<PedidoDto>> GetAllAsync();
    }
}
