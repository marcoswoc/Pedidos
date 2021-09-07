using Pedidos.Domain.Entity.Base;

namespace Pedidos.Domain.Entity
{
    public class Endereco : Entidade
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Numero { get; set; }
    }
}
