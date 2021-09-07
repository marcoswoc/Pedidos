using Pedidos.Domain.Entity.Base;
using Pedidos.Domain.Enums;
using System;
using System.Collections.Generic;

namespace Pedidos.Domain.Entity
{
    public class Pedido : EntityBase
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
