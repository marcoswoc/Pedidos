using Pedidos.Persistence.Entity.Base;

namespace Pedidos.Persistence.Entity
{
    public class Cliente : Entidade
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
    }
}
