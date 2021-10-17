using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Pedidos.Application.Security;
using System.Text;
using System;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using Pedidos.Persistence.Context;
using Microsoft.Extensions.Options;

namespace Pedidos.Api.Core.Extensions
{
    public static class AuthenticationExtensions
    {
        public static void AddAuthenticationPedidos(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtSection = configuration.GetSection("jwt");
            jwtSection.Bind(new JwtOptions());

            services.Configure<JwtOptions>(jwtSection);

            services.AddAuthorization();
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer("Bearer", options =>
            {
                var provider = services.BuildServiceProvider();
                var authOptions = provider.GetService<JwtOptions>() ?? provider.GetRequiredService<IOptions<JwtOptions>>()?.Value;

                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    CryptoProviderFactory = new CryptoProviderFactory()
                    {
                        CacheSignatureProviders = false
                    },
                    ClockSkew = TimeSpan.FromSeconds(1),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    LifetimeValidator = CustomLifetimeValidator,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(authOptions.SecretKey))
                };
            });

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<PedidosDataContext>()
                .AddDefaultTokenProviders();
        }

        private static bool CustomLifetimeValidator(DateTime? notBefore, DateTime? expires, SecurityToken tokenToValidate, TokenValidationParameters param)
        {
            if (expires != null)
            {
                return expires > DateTime.UtcNow;
            }
            return false;
        }
    }
}
