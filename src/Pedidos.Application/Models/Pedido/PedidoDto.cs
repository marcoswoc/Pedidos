using Pedidos.Application.Models.Base;
using Pedidos.Application.Models.Cliente;
using Pedidos.Application.Models.PedidoItem;
using Pedidos.Application.Models.Vendedor;
using Pedidos.Domain.Enums;
using System;
using System.Collections.Generic;

namespace Pedidos.Application.Models.Pedido
{
    public class PedidoDto : CreatePedidoDto, IModelBase
    {
        public int Id { get; set; }
        public long Codigo { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime? DataHoraInicio { get; set; }
        public DateTime? DataHoraFim { get; set; }
        public ClienteDto Cliente { get; set; }
        public VendedorDto Vendedor { get; set; }
        public StatusPedido StatusPedido { get; set; }
        public ICollection<PedidoItemDto> Itens { get; set; }        
    }
}
