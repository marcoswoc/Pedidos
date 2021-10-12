namespace Pedidos.Application.Exceptions
{
    public class InvalidParameterException : CoreException
    {
        public InvalidParameterException(string message, string parameter) : base(message, parameter)
        {
            Status = 400;
            Code = nameof(InvalidParameterException);
        }
    }
}
