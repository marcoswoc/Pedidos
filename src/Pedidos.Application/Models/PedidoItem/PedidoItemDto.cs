using Pedidos.Application.Models.Base;
using Pedidos.Application.Models.Produto;

namespace Pedidos.Application.Models.PedidoItem
{
    public class PedidoItemDto : CreatePedidoItemDto, IModelBase
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public ProdutoDto Produto { get; set; }        
    }
}
