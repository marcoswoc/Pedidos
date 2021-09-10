using Pedidos.Application.Models.Base;

namespace Pedidos.Application.Models.Cliente
{
    public class UpdateClienteDto : CreateClienteDto, IModelBase
    {
        public int Id { get; set; }
    }
}
