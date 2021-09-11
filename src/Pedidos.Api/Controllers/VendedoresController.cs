using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Models.Vendedor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendedoresController : Controller
    {
        private readonly IVendedorService _vendedorService;
        public VendedoresController(IVendedorService vendedorService)
        {
            _vendedorService = vendedorService;
        }

        [HttpPost]
        public async Task<ActionResult<VendedorDto>> CreateAsync([FromBody] CreateVendedorDto vendedorDto)
        {
            return Ok(await _vendedorService.AddAsync(vendedorDto));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VendedorDto>>> GetAllAsync()
        {
            return Ok(await _vendedorService.GetAllAsync());
        }
    }
}
