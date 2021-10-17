namespace Pedidos.Application.Security
{
    public class JwtOptions
    {
        public string SecretKey { get; set; }
        public int ExpirySeconds { get; set; }
        public string Type { get; set; }
        public string Issuer { get; set; }
        public string Authentication { get; set; }
    }
}
