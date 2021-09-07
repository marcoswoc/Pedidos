using Pedidos.Domain.Entity;
using Pedidos.Domain.Repositories;
using Pedidos.Persistence.Context;
using Pedidos.Persistence.Repositories.Base;

namespace Pedidos.Persistence.Repositories
{
    public class PedidoRepository : RepositoryBase<Pedido>, IPedidoRepository
    {
        public PedidoRepository(PedidosDataContext context) : base(context)
        {
        }
    }
}
