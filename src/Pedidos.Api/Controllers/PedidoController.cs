using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Models.Pedido;
using System.Threading.Tasks;

namespace Pedidos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPedidoService _pedidoService;
        public PedidoController(IMapper mapper, IPedidoService pedidoService)
        {
            _mapper = mapper;
            _pedidoService = pedidoService;
        }

        [HttpPost]
        public async Task<ActionResult<PedidoDto>> AddAsync([FromBody] CreatePedidoDto pedidoDto)
        {
            return await _pedidoService.AddAsync(pedidoDto);
        }
    }
}
