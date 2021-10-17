using System.ComponentModel.DataAnnotations;

namespace Pedidos.Application.Models.Usuario
{
    public class UsuarioDto
    {
        [Required]
        [Display(Name ="Nome")]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password {  get; set; }
    }
}
