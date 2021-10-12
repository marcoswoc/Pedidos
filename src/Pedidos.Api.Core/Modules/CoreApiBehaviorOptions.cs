using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Pedidos.Application.Exceptions;
using Pedidos.Application.Models.Base;
using System.Linq;

namespace Pedidos.Api.Core.Modules
{
    public class CoreApiBehaviorOptions : IConfigureOptions<ApiBehaviorOptions>
    {
        public void Configure(ApiBehaviorOptions options)
        {
            options.InvalidModelStateResponseFactory = InvalidModelStateResponse;
        }

        public static BadRequestObjectResult InvalidModelStateResponse(ActionContext action)
        {
            var result = new ErrorModel();

            foreach (var error in action.ModelState
                .Where(modelError => modelError.Value.Errors.Count > 0))
            {
                result.Add(new InvalidParameterException(error.Value.Errors.FirstOrDefault()?.ErrorMessage, error.Key));
            }

            return new BadRequestObjectResult(result);
        }
    }
}
