using Pedidos.Application.Models.Base;
using Pedidos.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Pedidos.Application.Models.Produto
{
    public class CreateProdutoDto : IModelBase
    {
        [Required(ErrorMessage = "Nome Obrigatório")]
        [MaxLength(60, ErrorMessage = "Quantidade máxima de {1} caracteres")]        
        public string Nome { get; set; }

        [Required(ErrorMessage = "Nome Obrigatório")]
        [MaxLength(512, ErrorMessage = "Quantidade máxima de {1} caracteres")]
        public string Descricao { get; set; }

        [EnumDataType(typeof(UnidadeMedida))]
        public UnidadeMedida UnidadeMedida { get; set; }

        [Required(ErrorMessage = "QuantidadeDisponivel Obrigatório")]
        [Range(1, int.MaxValue)]        
        public int QuantidadeDisponivel { get; set; }

        [Required(ErrorMessage = "Valor Obrigatório")]
        [Range(0.1, 99999.99)]
        public decimal Valor { get; set; }

        public bool Ativo { get; set; }
    }
}
