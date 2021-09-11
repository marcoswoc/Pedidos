using Pedidos.Application.Models.Produto;

namespace Pedidos.Application.Models.PedidoItem
{
    public class UpdatePedidoItemDto : CreateProdutoDto
    {
        public int Id { get; set; }
    }
}
