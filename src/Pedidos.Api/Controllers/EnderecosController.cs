using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Models.Endereco;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnderecosController : Controller
    {
        private readonly IEnderecoService _enderecoService;
        public EnderecosController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpPost]
        public async Task<ActionResult<EnderecoDto>> CreateAsync([FromBody] CreateEnderecoDto enderecoDto)
        {
            return Ok(await _enderecoService.AddAsync(enderecoDto));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EnderecoDto>>> GetAllAsync()
        {
            return Ok(await _enderecoService.GetAllAsync());
        }
    }
}
