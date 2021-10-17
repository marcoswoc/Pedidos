using Pedidos.Domain.Entity.Base;

namespace Pedidos.Domain.Entity
{
    public class Cliente : EntityBase
    {        
        public virtual string Nome { get; set; }
        public virtual string Telefone { get; set; }
        public virtual string Cep { get; set; }
        public virtual string Logradouro { get; set; }
        public virtual string Complemento { get; set; }
        public virtual string Bairro { get; set; }
        public virtual string Cidade { get; set; }
        public virtual string Uf { get; set; }
        public virtual string NumeroEndereco { get; set; }
    }
}
