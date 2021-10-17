using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.Models.Usuario;
using System.Threading.Tasks;
using Pedidos.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace Pedidos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]    
    public class UsuariosController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuariosController(
            IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateAsync([FromBody] UsuarioDto model)
        {
            return Ok(await _usuarioService.CreateAsync(model));
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginAsync([FromBody] LoginDto model)
        {
            return Ok(await _usuarioService.LoginAsync(model));
        }
    }
}
