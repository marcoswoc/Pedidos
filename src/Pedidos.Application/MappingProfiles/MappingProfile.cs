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
            //Pedido
            CreateMap<Pedido, PedidoDto>().ReverseMap();
            CreateMap<UpdatePedidoDto, Pedido>();
            CreateMap<CreatePedidoDto, Pedido>();

            //Endereço
            CreateMap<Endereco, EnderecoDto>().ReverseMap();
            CreateMap<UpdateEnderecoDto, Endereco>();
            CreateMap<CreateEnderecoDto, Endereco>();

            //Cliente
            CreateMap<Cliente, ClienteDto>().ReverseMap();
            CreateMap<UpdateClienteDto, Cliente>();
            CreateMap<CreateClienteDto, Cliente>();

            //Vendedor
            CreateMap<Vendedor, VendedorDto>().ReverseMap();
            CreateMap<UpdateVendedorDto, Vendedor>();
            CreateMap<CreateVendedorDto, Vendedor>();

            //Produto
            CreateMap<Produto, ProdutoDto>().ReverseMap();
            CreateMap<UpdateProdutoDto, Produto>();
            CreateMap<CreateProdutoDto, Produto>();
            
            //Pedido Item
            CreateMap<PedidoItem, PedidoItemDto>().ReverseMap();
            CreateMap<UpdatePedidoItemDto, PedidoItem>();
            CreateMap<CreatePedidoItemDto, PedidoItem>();
        }
    }
}
