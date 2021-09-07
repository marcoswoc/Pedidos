using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pedidos.Persistence.Context;

namespace Pedidos.Api.Core.Extensions
{
    public static class SqlExtensions
    {
        public static void AddSqlDatabase(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<PedidosDataContext>(o =>
                o.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        }
    }
}
