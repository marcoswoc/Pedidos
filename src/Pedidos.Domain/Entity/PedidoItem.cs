using Pedidos.Domain.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pedidos.Domain.Entity
{
    public class PedidoItem : EntityBase
    {
        public virtual int PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }
        public virtual int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual int Quantidade { get; set; }
        public virtual decimal Valor { get; set; }
    }
}
