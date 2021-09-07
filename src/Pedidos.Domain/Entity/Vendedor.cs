using Pedidos.Domain.Entity.Base;
using System.Collections.Generic;

namespace Pedidos.Domain.Entity
{
    public class Vendedor : Entidade
    {
        public string Nome { get; set; }
        public ICollection<Pedido> Pedidos {  get; set; }

    }
}
