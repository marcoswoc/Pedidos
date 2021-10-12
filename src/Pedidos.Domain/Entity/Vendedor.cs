using Pedidos.Domain.Entity.Base;

namespace Pedidos.Domain.Entity
{
    public class Vendedor : EntityBase
    {
        public virtual string Nome { get; set; }
    }
}
