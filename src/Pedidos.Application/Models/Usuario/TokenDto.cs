using System.Collections.Generic;

namespace Pedidos.Application.Models.Usuario
{
    public class TokenDto
    {
        public string Token { get; set; }
        public bool Result { get; set; }
        public List<string> Erros { get; set; }
    }
}
