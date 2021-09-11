using AutoMapper;
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
        private readonly IMapper _mapper;
        private readonly IPedidoService _pedidoService;
        public PedidosController(IMapper mapper, IPedidoService pedidoService)
        {
            _mapper = mapper;
            _pedidoService = pedidoService;
        }

        [HttpPost]
        public async Task<ActionResult<PedidoDto>> AddAsync([FromBody] CreatePedidoDto pedidoDto)
        {
            return Ok(await _pedidoService.AddAsync(pedidoDto));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PedidoDto>>> GetAllAsync()
        {
            return Ok(await _pedidoService.GetAllAsync());
        }

        [HttpPost("{id:int}/itens")]
        public async Task<ActionResult<PedidoDto>> AddItensAsync([FromBody] CreatePedidoItemDto pedidoItemDto, int id)
        {
            return Ok(await _pedidoService.AddItensAsync(id, pedidoItemDto));
        }
    }
}
