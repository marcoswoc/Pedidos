using Pedidos.Application.Models.Base;

namespace Pedidos.Application.Models.PedidoItem
{
    public class CreatePedidoItemDto : IModelBase
    {
        public int PedidoId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
    }
}
