using Pedidos.Application.Models.Base;
using Pedidos.Domain.Enums;
using System;

namespace Pedidos.Application.Models.Pedido
{
    public class CreatePedidoDto : IModelBase
    {
        public long Codigo { get; set; }
        public int ClienteId { get; set; }
        public int VendedorId { get; set; }
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
