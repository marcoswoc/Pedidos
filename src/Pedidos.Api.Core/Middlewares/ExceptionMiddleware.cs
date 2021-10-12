using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Pedidos.Application.Exceptions;
using Pedidos.Application.Models.Base;
using System;
using System.Threading.Tasks;

namespace Pedidos.Api.Core.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;

        protected bool IsDevelopment { get; set; }

        public ExceptionMiddleware(RequestDelegate next, IWebHostEnvironment env, ILogger<ExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;

            IsDevelopment = env.IsDevelopment();
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try 
            {
                await _next(context);
            } 
            catch (Exception ex)
            {
                await AnalyzeAsync(context, ex);
            }
        }

        public async Task AnalyzeAsync(HttpContext context, Exception error)
        {
            context.Response.ContentType = "application/json";

            var isCoreException = error is CoreException;
            var message = isCoreException ? $"{error?.Message} - {error?.InnerException?.Message}" : "Ocorreu um erro interno da aplicação";

            var exception = isCoreException ? (error as CoreException) : new CoreException(message);

            context.Response.StatusCode = isCoreException ? StatusCodes.Status400BadRequest : StatusCodes.Status500InternalServerError;

            await context.Response.WriteAsync(new ErrorModel().Add(exception).ToString());
        }
    }
}
