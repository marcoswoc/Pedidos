
using Pedidos.Persistence.Entity.Base;
using System.Collections.Generic;

namespace Pedidos.Persistence.Entity
{
    public class Vendedor : Entidade
    {
        public string Nome { get; set; }
        public ICollection<Pedido> Pedidos {  get; set; }

    }
}
