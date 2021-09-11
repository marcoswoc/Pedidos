using Pedidos.Application.Models.Base;
using Pedidos.Domain.Enums;

namespace Pedidos.Application.Models.Produto
{
    public class CreateProdutoDto : IModelBase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
    }
}
