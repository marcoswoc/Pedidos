using Pedidos.Persistence.Entity.Base;
using Pedidos.Persistence.Entity.ValueObjects;
using System;
using System.Collections.Generic;

namespace Pedidos.Persistence.Entity
{
    public class Pedido : Entidade
    {
        public long Codigo { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int VendedorId { get; set; }
        public Vendedor Vendedor { get; set; }
        public ICollection<PedidoItem> Itens { get; set; }
        public StatusPedido StatusPedido { get; set; }
        public bool Pagamento { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal? ValorPago { get; set; }
        public DateTime? DataHoraInicio { get; set; }
        public DateTime? DataHoraFim { get; set; }
        public string Observacao { get; set; }
    }
}
