using Pedidos.Application.Models.Base;

namespace Pedidos.Application.Models.Cliente
{
    public class CreateClienteDto : IModelBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int EnderecoId { get; set; }
    }
}
