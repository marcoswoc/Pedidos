namespace Pedidos.Application.Models.Base
{
    public class SuccessModel : IModelBase
    {
        public bool Success { get; set; } = true;
        public string Message { get; set; }
        public object Value { get; set; }

        public SuccessModel() { }

        public SuccessModel(string message, bool success = true)
        {
            Success = success;
            Message = message;
        }

        public SuccessModel(object value, bool success = true)
        {
            Success = success;
            Value = value;
        }
    }
}
