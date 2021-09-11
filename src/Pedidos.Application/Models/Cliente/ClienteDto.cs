using Pedidos.Application.Models.Base;
using Pedidos.Application.Models.Endereco;

namespace Pedidos.Application.Models.Cliente
{
    public class ClienteDto : UpdateClienteDto, IModelBase
    {
        public EnderecoDto Endereco { get; set; }
    }
}
