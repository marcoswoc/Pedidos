using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Models.Base;
using Pedidos.Application.Models.Pedido;
using Pedidos.Application.Models.PedidoItem;
using Pedidos.Application.Models.Produto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Api.Controllers
{
    [ApiController]
    [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status404NotFound)]
    [Route("api/[controller]")]
    public class PedidosController : Controller
    {
        private readonly IPedidoService _pedidoService;
        public PedidosController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(PedidoDto), StatusCodes.Status200OK)]
        public async Task<ActionResult<PedidoDto>> AddAsync([FromBody] CreatePedidoDto pedidoDto)
        {
            return Ok(await _pedidoService.CreateAsync(pedidoDto));
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<PedidoDto>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<PedidoDto>>> GetAllAsync()
        {
            return Ok(await _pedidoService.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(PedidoDto), StatusCodes.Status200OK)]
        public async Task<ActionResult<PedidoDto>> GetByIdAsync(int id)
        {
            return Ok(await _pedidoService.GetByIdAsync(id));
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(typeof(PedidoDto), StatusCodes.Status200OK)]
        public async Task<ActionResult<PedidoDto>> UpdateAsync([FromRoute] int id, [FromBody] CreatePedidoDto pedidoDto)
        {
            return Ok(await _pedidoService.UpdateAsync(id, pedidoDto));
        }       

        [HttpPost("{id:int}/itens")]
        [ProducesResponseType(typeof(PedidoDto), StatusCodes.Status200OK)]
        public async Task<ActionResult<PedidoDto>> AddItensAsync([FromRoute] int id, [FromBody] CreatePedidoItemDto pedidoItemDto)
        {
            return Ok(await _pedidoService.AddItensAsync(id, pedidoItemDto));
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(typeof(SuccessModel), StatusCodes.Status200OK)]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await _pedidoService.RemoveAsync(id);
            return Ok(new SuccessModel("deletado com sucesso"));
        }
    }
}
