using Pedidos.Domain.Entity;
using Pedidos.Domain.Repositories;
using Pedidos.Persistence.Context;
using Pedidos.Persistence.Repositories.Base;

namespace Pedidos.Persistence.Repositories
{
    public class EnderecoRepository : RepositoryBase<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(PedidosDataContext context) : base(context)
        {

        }
    }
}
