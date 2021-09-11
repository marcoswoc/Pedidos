using Pedidos.Application.Models.Base;

namespace Pedidos.Application.Models.Vendedor
{
    public class CreateVendedorDto : IModelBase
    {
        public string Nome { get; set; }
    }
}
