using AutoMapper;
using Pedidos.Application.Models.Cliente;
using Pedidos.Application.Models.Endereco;
using Pedidos.Application.Models.Pedido;
using Pedidos.Application.Models.PedidoItem;
using Pedidos.Application.Models.Produto;
using Pedidos.Application.Models.Vendedor;
using Pedidos.Domain.Entity;

namespace Pedidos.Application.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Pedido, PedidoDto>().ReverseMap();

            //Endereço
            CreateMap<Endereco, EnderecoDto>().ReverseMap();
            CreateMap<UpdateEnderecoDto, Endereco>();
            CreateMap<CreateEnderecoDto, Endereco>();

            //Cliente
            CreateMap<Cliente, ClienteDto>().ReverseMap();
            CreateMap<UpdateClienteDto, Cliente>();
            CreateMap<CreateClienteDto, Cliente>();

            CreateMap<Vendedor, VendedorDto>().ReverseMap();
            CreateMap<Produto, ProdutoDto>().ReverseMap();
            
            CreateMap<PedidoItem, PedidoItemDto>().ReverseMap();
        }
    }
}
