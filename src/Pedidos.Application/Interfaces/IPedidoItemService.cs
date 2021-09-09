using Pedidos.Application.Models.PedidoItem;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Application.Interfaces
{
    public interface IPedidoItemService
    {
        Task<PedidoItemDto> GetByIdAsync(int id);
        Task AddAsync(PedidoItemDto entity);
        Task AddRangeAsync(IEnumerable<PedidoItemDto> entities);
        Task UpdateAsync(PedidoItemDto entity);
        Task RemoveAsync(int id);
        Task<IEnumerable<PedidoItemDto>> GetAllAsync();
    }
}
