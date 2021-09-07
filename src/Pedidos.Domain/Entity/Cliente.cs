using Pedidos.Domain.Entity.Base;
using System.Collections.Generic;

namespace Pedidos.Domain.Entity
{
    public class Cliente : EntityBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int EnderecoId {  get; set; }
        public Endereco Endereco { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
