using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Models.Base;
using Pedidos.Application.Models.Vendedor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Api.Controllers
{
    [ApiController]
    [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status404NotFound)]
    [Route("api/[controller]")]
    public class VendedoresController : Controller
    {
        private readonly IVendedorService _vendedorService;
        public VendedoresController(IVendedorService vendedorService)
        {
            _vendedorService = vendedorService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(VendedorDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateAsync([FromBody] CreateVendedorDto vendedorDto)
        {
            return Ok(await _vendedorService.CreateAsync(vendedorDto));
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<VendedorDto>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<VendedorDto>>> GetAllAsync()
        {
            return Ok(await _vendedorService.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(VendedorDto), StatusCodes.Status200OK)]
        public async Task<ActionResult<VendedorDto>> GetByIdAsync(int id)
        {
            return Ok(await _vendedorService.GetByIdAsync(id));
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(typeof(VendedorDto), StatusCodes.Status200OK)]
        public async Task<ActionResult<VendedorDto>> UpdateAsync([FromRoute] int id, [FromBody] CreateVendedorDto produtoDto)
        {
            return Ok(await _vendedorService.UpdateAsync(id, produtoDto));
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(typeof(SuccessModel), StatusCodes.Status200OK)]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await _vendedorService.RemoveAsync(id);
            return Ok(new SuccessModel("deletado com sucesso"));
        }
    }
}
