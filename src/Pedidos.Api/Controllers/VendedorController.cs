using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Models.Vendedor;
using System.Threading.Tasks;

namespace Pedidos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendedorController : Controller
    {
        private readonly IVendedorService _vendedorService;
        public VendedorController(IVendedorService vendedorService)
        {
            _vendedorService = vendedorService;
        }

        [HttpPost]
        public async Task<ActionResult<VendedorDto>> CreateAsync([FromBody] CreateVendedorDto vendedorDto)
        {
            return await _vendedorService.AddAsync(vendedorDto);
        }
    }
}
