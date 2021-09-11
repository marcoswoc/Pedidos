using Pedidos.Application.Models.PedidoItem;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Application.Interfaces
{
    public interface IPedidoItemService
    {
        Task<PedidoItemDto> GetByIdAsync(int id);
        Task<PedidoItemDto> AddAsync(CreatePedidoItemDto entity);
        Task<PedidoItemDto> UpdateAsync(UpdatePedidoItemDto entity);
        Task RemoveAsync(int id);
        Task<IEnumerable<PedidoItemDto>> GetAllAsync();
    }
}
