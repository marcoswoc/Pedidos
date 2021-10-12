namespace Pedidos.Application.Models.Base
{
    public class ErrorDetailsModel
    {
        private string _parameter = default;
        public string Parameter
        {
            get => _parameter;
            set => _parameter = value;
        }

        public string Message { get; set; }

        public string Code { get; set; }

        public ErrorDetailsModel() { }

        public ErrorDetailsModel(string message) : this(message, null) { }

        public ErrorDetailsModel(string message, string field) : this(message, field, null) { }

        public ErrorDetailsModel(string message, string field, string code)
        {
            Message = message;
            Parameter = field;
            Code = code;
        }
    }
}
