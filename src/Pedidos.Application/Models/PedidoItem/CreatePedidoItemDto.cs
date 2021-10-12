using Pedidos.Application.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Pedidos.Application.Models.PedidoItem
{
    public class CreatePedidoItemDto : IModelBase
    {
        [Required(ErrorMessage = "ProdutoId Obrigatório")]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Quantidade Obrigatória")]
        [Range(1, int.MaxValue)]
        public int Quantidade { get; set; }        
    }
}
