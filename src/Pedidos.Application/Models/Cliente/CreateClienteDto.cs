using Pedidos.Application.Models.Base;

namespace Pedidos.Application.Models.Cliente
{
    public class CreateClienteDto : IModelBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string NumeroEndereco { get; set; }
    }
}
