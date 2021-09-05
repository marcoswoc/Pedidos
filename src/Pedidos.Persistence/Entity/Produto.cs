using Pedidos.Persistence.Entity.Base;

namespace Pedidos.Persistence.Entity
{
    public class Produto : Entidade
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string UnidadeMedida { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
    }
}
