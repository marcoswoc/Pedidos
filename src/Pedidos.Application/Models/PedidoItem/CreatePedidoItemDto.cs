using Pedidos.Application.Models.Base;

namespace Pedidos.Application.Models.PedidoItem
{
    public class CreatePedidoItemDto : IModelBase
    {
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }        
    }
}
