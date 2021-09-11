using Pedidos.Application.Models.Base;
using Pedidos.Application.Models.Pedido;
using System.Collections.Generic;

namespace Pedidos.Application.Models.Vendedor
{
    public class VendedorDto :UpdateVendedorDto, IModelBase
    {
        public ICollection<PedidoDto> Pedidos { get; set; }
    }
}
