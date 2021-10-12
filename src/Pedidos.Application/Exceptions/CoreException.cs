using System;

namespace Pedidos.Application.Exceptions
{
    public class CoreException : Exception
    {
        private string _parameter = default;
        public string Parameter
        {
            get => _parameter;
            set => _parameter = value;
        }
        public int Status { get; set; } = 400;

        public string Code { get; protected set; } = nameof(CoreException);
        
        public CoreException(string message) : base(message) { }

        public CoreException(string message, Exception inner) : base(message, inner) { }

        public CoreException(string message, string parameter) : base(message)
        {
            Parameter = parameter;
        }
    }
}
