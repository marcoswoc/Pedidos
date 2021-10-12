using AutoMapper;
using Pedidos.Application.Models.Cliente;
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
            CreateMap<CreatePedidoDto, Pedido>();

            //Cliente
            CreateMap<Cliente, ClienteDto>().ReverseMap();
            CreateMap<CreateClienteDto, Cliente>();

            //Vendedor
            CreateMap<Vendedor, VendedorDto>().ReverseMap();
            CreateMap<CreateVendedorDto, Vendedor>();

            //Produto
            CreateMap<Produto, ProdutoDto>().ReverseMap();
            CreateMap<CreateProdutoDto, Produto>();
            
            //Pedido Item
            CreateMap<PedidoItem, PedidoItemDto>().ReverseMap();
            CreateMap<CreatePedidoItemDto, PedidoItem>();
        }
    }
}
