using Pedidos.Domain.Entity;
using Pedidos.Domain.Repositories;
using Pedidos.Persistence.Context;
using Pedidos.Persistence.Repositories.Base;

namespace Pedidos.Persistence.Repositories
{
    public class VendedorRepository : RepositoryBase<Vendedor>, IVendedorRepository
    {
        public VendedorRepository(PedidosDataContext context) : base(context)
        {
        }
    }
}
