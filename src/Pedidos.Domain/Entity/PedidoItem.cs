using Pedidos.Domain.Entity.Base;

namespace Pedidos.Domain.Entity
{
    public class PedidoItem : Entidade
    {
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
    }
}
