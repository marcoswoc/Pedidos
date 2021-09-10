using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Models.Endereco;
using System.Threading.Tasks;

namespace Pedidos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnderecoController : Controller
    {
        private readonly IEnderecoService _enderecoService;
        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpPost]
        public async Task<ActionResult<EnderecoDto>> CreateAsync([FromBody] CreateEnderecoDto enderecoDto)
        {
            return await _enderecoService.AddAsync(enderecoDto);
        }
    }
}
