using System.ComponentModel.DataAnnotations;

namespace Pedidos.Application.Models.Usuario
{
    public class LoginDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
