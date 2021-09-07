using Pedidos.Domain.Entity;
using Pedidos.Domain.Repositories;
using Pedidos.Persistence.Context;
using Pedidos.Persistence.Repositories.Base;

namespace Pedidos.Persistence.Repositories
{
    public class PedidoItemRepository : RepositoryBase<PedidoItem>, IPedidoItemRepository
    {
        public PedidoItemRepository(PedidosDataContext context) : base(context)
        {
        }
    }
}
