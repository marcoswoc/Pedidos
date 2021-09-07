using Pedidos.Persistence.Entity.Base;
using Pedidos.Persistence.Entity.ValueObjects;

namespace Pedidos.Persistence.Entity
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
