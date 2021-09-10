using Microsoft.Extensions.DependencyInjection;
using Pedidos.Application.MappingProfiles;

namespace Pedidos.Api.Core.Extensions
{
    public static class AutoMapperExtensions
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
