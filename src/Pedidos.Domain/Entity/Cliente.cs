using Pedidos.Domain.Entity.Base;
using System.Collections.Generic;

namespace Pedidos.Domain.Entity
{
    public class Cliente : EntityBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int EnderecoId {  get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
