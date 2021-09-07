using Pedidos.Persistence.Entity.Base;
using System;
using System.Collections.Generic;

namespace Pedidos.Persistence.Entity
{
    public class Cliente : Entidade
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int EnderecoId {  get; set; }
        public Endereco Endereco { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
