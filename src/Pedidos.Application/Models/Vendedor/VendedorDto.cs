using Pedidos.Application.Models.Base;

namespace Pedidos.Application.Models.Vendedor
{
    public class VendedorDto : CreateVendedorDto, IModelBase
    {
        public int Id { get; set; }
    }
}
