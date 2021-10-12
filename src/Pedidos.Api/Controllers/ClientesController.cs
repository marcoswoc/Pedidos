using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Models.Cliente;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClientesController(
            IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        public async Task<ActionResult<ClienteDto>> CreateAsync([FromBody] CreateClienteDto clienteDto)
        {
            return Ok(await _clienteService.CreateAsync(clienteDto));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClienteDto>>> GetAllAsync()
        {
            return Ok(await _clienteService.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ClienteDto>> GetByIdAsync(int id)
        {
            return Ok(await _clienteService.GetByIdAsync(id));
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<ClienteDto>> UpdateAsync([FromRoute]int id, [FromBody]CreateClienteDto clienteDto)
        {
            return Ok(await _clienteService.UpdateAsync(id,clienteDto));
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await _clienteService.RemoveAsync(id);
            return NoContent();
        }

    }
}
