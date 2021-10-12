using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Models.Base;
using Pedidos.Application.Models.Cliente;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Api.Controllers
{
    [ApiController]
    [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status404NotFound)]
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
        [ProducesResponseType(typeof(ClienteDto), StatusCodes.Status200OK)]
        public async Task<ActionResult<ClienteDto>> CreateAsync([FromBody] CreateClienteDto clienteDto)
        {
            return Ok(await _clienteService.CreateAsync(clienteDto));
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ClienteDto>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ClienteDto>>> GetAllAsync()
        {
            return Ok(await _clienteService.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(ClienteDto), StatusCodes.Status200OK)]
        public async Task<ActionResult<ClienteDto>> GetByIdAsync(int id)
        {
            return Ok(await _clienteService.GetByIdAsync(id));
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(typeof(ClienteDto), StatusCodes.Status200OK)]
        public async Task<ActionResult<ClienteDto>> UpdateAsync([FromRoute]int id, [FromBody]CreateClienteDto clienteDto)
        {
            return Ok(await _clienteService.UpdateAsync(id,clienteDto));
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(typeof(SuccessModel), StatusCodes.Status200OK)]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await _clienteService.RemoveAsync(id);
            return Ok(new SuccessModel("deletado com sucesso"));
        }

    }
}
