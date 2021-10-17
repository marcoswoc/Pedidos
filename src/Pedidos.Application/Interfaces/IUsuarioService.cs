using Microsoft.AspNetCore.Identity;
using Pedidos.Application.Models.Usuario;
using System.Threading.Tasks;

namespace Pedidos.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task<IdentityResult> CreateAsync(UsuarioDto model);
        Task<TokenDto> LoginAsync(LoginDto model);
    }
}
