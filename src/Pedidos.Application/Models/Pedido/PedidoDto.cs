using Pedidos.Application.Models.Base;
using Pedidos.Application.Models.Cliente;
using Pedidos.Application.Models.PedidoItem;
using Pedidos.Application.Models.Vendedor;
using System.Collections.Generic;

namespace Pedidos.Application.Models.Pedido
{
    public class PedidoDto : UpdatePedidoDto, IModelBase
    {        
        public ClienteDto Cliente { get; set; }
        public ICollection<PedidoItemDto> Itens { get; set; }
        public VendedorDto Vendedor { get; set; }
    }
}
