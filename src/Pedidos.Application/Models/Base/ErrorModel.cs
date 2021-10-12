using Pedidos.Application.Exceptions;
using System.Collections.Generic;
using System.Text.Json;

namespace Pedidos.Application.Models.Base
{
    public class ErrorModel : IModelBase
    {
        public List<ErrorDetailsModel> Errors { get; set; } = new();
        public ErrorModel() { }
        public ErrorModel Add(CoreException exception)
        {
            Errors.Add(new ErrorDetailsModel(exception.Message, exception.Parameter, exception.Code));

            return this;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
