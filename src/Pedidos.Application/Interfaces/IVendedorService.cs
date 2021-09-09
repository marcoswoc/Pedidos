using Pedidos.Application.Models.Vendedor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Application.Interfaces
{
    public interface IVendedorService
    {
        Task<VendedorDto> GetByIdAsync(int id);
        Task AddAsync(VendedorDto entity);
        Task AddRangeAsync(IEnumerable<VendedorDto> entities);
        Task UpdateAsync(VendedorDto entity);
        Task RemoveAsync(int id);
        Task<IEnumerable<VendedorDto>> GetAllAsync();
    }
}
