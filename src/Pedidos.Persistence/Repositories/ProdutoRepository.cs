using Pedidos.Domain.Entity;
using Pedidos.Domain.Repositories;
using Pedidos.Persistence.Context;
using Pedidos.Persistence.Repositories.Base;

namespace Pedidos.Persistence.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public ProdutoRepository(PedidosDataContext context) : base(context)
        {
        }
    }
}
