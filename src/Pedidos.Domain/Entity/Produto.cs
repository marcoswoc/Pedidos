using Pedidos.Domain.Entity.Base;
using Pedidos.Domain.Enums;

namespace Pedidos.Domain.Entity
{
    public class Produto : EntityBase
    {
        public virtual string Nome { get; set; }
        public virtual string Descricao { get; set; }
        public virtual UnidadeMedida UnidadeMedida { get; set; }
        public virtual int QuantidadeDisponivel { get; set; }
        public virtual decimal Valor { get; set; }
        public virtual bool Ativo { get; set; }
    }
}
