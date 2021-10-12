using Pedidos.Application.Models.Vendedor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Application.Interfaces
{
    public interface IVendedorService
    {
        Task<VendedorDto> GetByIdAsync(int id);
        Task<VendedorDto> CreateAsync(CreateVendedorDto entity);
        Task<VendedorDto> UpdateAsync(int id, CreateVendedorDto entity);
        Task RemoveAsync(int id);
        Task<IEnumerable<VendedorDto>> GetAllAsync();
    }
}
