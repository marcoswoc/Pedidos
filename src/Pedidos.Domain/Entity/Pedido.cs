using Pedidos.Domain.Entity.Base;
using Pedidos.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pedidos.Domain.Entity
{
    public class Pedido : EntityBase
    {
        public virtual long Codigo { get; set; }
        public virtual int ClienteId { get; set; }   
        public virtual Cliente Cliente { get; set; }
        public virtual Vendedor Vendedor { get; set; }
        public virtual int VendedorId { get; set; }        
        public virtual StatusPedido StatusPedido { get; set; }
        public virtual bool Pagamento { get; set; }
        public virtual TipoPagamento TipoPagamento { get; set; }
        public virtual decimal ValorTotal { get; set; }
        public virtual decimal? ValorPago { get; set; }
        public virtual DateTime? DataHoraInicio { get; set; }
        public virtual DateTime? DataHoraFim { get; set; }
        public virtual string Observacao { get; set; }
        public virtual ICollection<PedidoItem> Itens { get; set; } = new List<PedidoItem>();

        public void AdicionarItem(PedidoItem item)
        {
            this.Itens.Add(item);
        }
    }
}
