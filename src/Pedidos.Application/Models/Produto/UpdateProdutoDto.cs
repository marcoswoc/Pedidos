using Pedidos.Application.Models.Base;

namespace Pedidos.Application.Models.Produto
{
    public class UpdateProdutoDto : CreateProdutoDto, IModelBase
    {
        public int Id { get; set; }
    }
}
