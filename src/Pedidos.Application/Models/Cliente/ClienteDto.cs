using Pedidos.Application.Models.Base;

namespace Pedidos.Application.Models.Cliente
{
    public class ClienteDto : CreateClienteDto, IModelBase
    {
        public int Id { get; set; }
    }
}
