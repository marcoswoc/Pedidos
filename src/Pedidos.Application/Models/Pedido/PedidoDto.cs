using Pedidos.Application.Models.Base;
using Pedidos.Application.Models.Cliente;
using Pedidos.Application.Models.PedidoItem;
using Pedidos.Application.Models.Vendedor;
using Pedidos.Domain.Enums;
using System;
using System.Collections.Generic;

namespace Pedidos.Application.Models.Pedido
{
    public class PedidoDto : IModelBase
    {
        public long Codigo { get; set; }
        public int ClienteId { get; set; }
        public ClienteDto Cliente { get; set; }
        public int VendedorId { get; set; }
        public VendedorDto Vendedor { get; set; }
        public ICollection<PedidoItemDto> Itens { get; set; }
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
