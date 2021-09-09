using Pedidos.Domain.Enums;

namespace Pedidos.Application.Models.Produto
{
    public class ProdutoDto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
    }
}
