using Pedidos.Application.Models.Base;
using Pedidos.Application.Models.Endereco;
using Pedidos.Application.Models.Pedido;
using System.Collections.Generic;

namespace Pedidos.Application.Models.Cliente
{
    public class ClienteDto : UpdateClienteDto, IModelBase
    {
        public EnderecoDto Endereco { get; set; }
        public ICollection<PedidoDto> Pedidos { get; set; }
    }
}
