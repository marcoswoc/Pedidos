using Pedidos.Application.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Pedidos.Application.Models.Vendedor
{
    public class CreateVendedorDto : IModelBase
    {
        [Required(ErrorMessage = "Nome Obrigatório")]
        [MaxLength(80, ErrorMessage = "Quantidade máxima de {1} caracteres")]
        public string Nome { get; set; }
    }
}
