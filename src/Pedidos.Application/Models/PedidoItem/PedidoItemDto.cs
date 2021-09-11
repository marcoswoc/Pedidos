using Pedidos.Application.Models.Base;
using Pedidos.Application.Models.Pedido;
using Pedidos.Application.Models.Produto;

namespace Pedidos.Application.Models.PedidoItem
{
    public class PedidoItemDto : UpdatePedidoItemDto, IModelBase
    {       
        public PedidoDto Pedido { get; set; }        
        public ProdutoDto Produto { get; set; }        
    }
}
