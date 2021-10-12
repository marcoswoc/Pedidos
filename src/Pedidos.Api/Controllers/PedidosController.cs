using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Models.Pedido;
using Pedidos.Application.Models.PedidoItem;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidosController : Controller
    {

        private readonly IPedidoService _pedidoService;

        public PedidosController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpPost]
        public async Task<ActionResult<PedidoDto>> AddAsync([FromBody] CreatePedidoDto pedidoDto)
        {
            return Ok(await _pedidoService.CreateAsync(pedidoDto));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PedidoDto>>> GetAllAsync()
        {
            return Ok(await _pedidoService.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<PedidoDto>> GetByIdAsync(int id)
        {
            return Ok(await _pedidoService.GetByIdAsync(id));
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<PedidoDto>> UpdateAsync([FromRoute] int id, [FromBody] CreatePedidoDto pedidoDto)
        {
            return Ok(await _pedidoService.UpdateAsync(id, pedidoDto));
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await _pedidoService.RemoveAsync(id);
            return NoContent();
        }

        [HttpPost("{id:int}/itens")]
        public async Task<ActionResult<PedidoDto>> AddItensAsync([FromRoute] int id, [FromBody] CreatePedidoItemDto pedidoItemDto)
        {
            return Ok(await _pedidoService.AddItensAsync(id, pedidoItemDto));
        }
    }
}
