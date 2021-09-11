using Pedidos.Application.Models.Base;

namespace Pedidos.Application.Models.Vendedor
{
    public class UpdateVendedorDto : CreateVendedorDto, IModelBase
    {
        public int Id { get; set; }
    }
}
