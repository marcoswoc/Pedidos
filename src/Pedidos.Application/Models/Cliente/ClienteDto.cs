using Pedidos.Application.Models.Endereco;
using Pedidos.Application.Models.Pedido;
using System.Collections.Generic;

namespace Pedidos.Application.Models.Cliente
{
    public class ClienteDto
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int EnderecoId { get; set; }
        public EnderecoDto Endereco { get; set; }
        public ICollection<PedidoDto> Pedidos { get; set; }
    }
}
