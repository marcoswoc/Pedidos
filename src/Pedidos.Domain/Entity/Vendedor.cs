using Pedidos.Domain.Entity.Base;
using System.Collections.Generic;

namespace Pedidos.Domain.Entity
{
    public class Vendedor : EntityBase
    {
        public string Nome { get; set; }
        public virtual ICollection<Pedido> Pedidos {  get; set; }

    }
}
