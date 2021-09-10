using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Models.Cliente;
using System.Threading.Tasks;

namespace Pedidos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;
        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        public async Task<ActionResult<ClienteDto>> CreateAsync([FromBody] CreateClienteDto clienteDto)
        {
            return await _clienteService.AddAsync(clienteDto);
        }
    }
}
