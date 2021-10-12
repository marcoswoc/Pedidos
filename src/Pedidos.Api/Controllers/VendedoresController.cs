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
            return Ok(await _vendedorService.CreateAsync(vendedorDto));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VendedorDto>>> GetAllAsync()
        {
            return Ok(await _vendedorService.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<VendedorDto>> GetByIdAsync(int id)
        {
            return Ok(await _vendedorService.GetByIdAsync(id));
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<VendedorDto>> UpdateAsync([FromRoute] int id, [FromBody] CreateVendedorDto produtoDto)
        {
            return Ok(await _vendedorService.UpdateAsync(id, produtoDto));
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await _vendedorService.RemoveAsync(id);
            return NoContent();
        }
    }
}
