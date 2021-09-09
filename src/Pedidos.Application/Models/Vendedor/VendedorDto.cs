using Pedidos.Application.Models.Pedido;
using System.Collections.Generic;

namespace Pedidos.Application.Models.Vendedor
{
    public class VendedorDto
    {
        public string Nome { get; set; }
        public ICollection<PedidoDto> Pedidos { get; set; }
    }
}
