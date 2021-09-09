using Pedidos.Application.Models.Pedido;
using Pedidos.Application.Models.Produto;

namespace Pedidos.Application.Models.PedidoItem
{
    public class PedidoItemDto
    {
        public int PedidoId { get; set; }
        public PedidoDto Pedido { get; set; }
        public int ProdutoId { get; set; }
        public ProdutoDto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
    }
}
