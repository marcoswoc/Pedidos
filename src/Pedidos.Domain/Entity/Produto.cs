using Pedidos.Domain.Entity.Base;
using Pedidos.Domain.Enums;

namespace Pedidos.Domain.Entity
{
    public class Produto : Entidade
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
    }
}
