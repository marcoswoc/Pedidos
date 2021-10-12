using AutoMapper;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Models.Pedido;
using Pedidos.Application.Models.PedidoItem;
using Pedidos.Domain.Entity;
using Pedidos.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Application.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IMapper _mapper;
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IProdutoRepository _produtoRepository;

        public PedidoService(
            IMapper mapper,
            IPedidoRepository pedidoRepository,
            IProdutoRepository produtoRepository)
        {
            _mapper = mapper;
            _pedidoRepository = pedidoRepository;
            _produtoRepository = produtoRepository;
        }

        public async Task<PedidoDto> CreateAsync(CreatePedidoDto pedidoDto)
        {
            var pedido = await _pedidoRepository.CreateAsync(_mapper.Map<Pedido>(pedidoDto));
            return _mapper.Map<PedidoDto>(pedido);
        }

        public async Task<IEnumerable<PedidoDto>> GetAllAsync()
        {
            var pedidos = await _pedidoRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<PedidoDto>>(pedidos);
        }

        public async Task<PedidoDto> GetByIdAsync(int id)
        {
            var pedido = await _pedidoRepository.GetByIdAsync(id);
            return _mapper.Map<PedidoDto>(pedido);
        }

        public async Task RemoveAsync(int id)
        {
            await _pedidoRepository.RemoveAsync(id);
        }

        public async Task<PedidoDto> UpdateAsync(int id, CreatePedidoDto pedidoDto)
        {
            var entity = await _pedidoRepository.GetByIdAsync(id);

            await _pedidoRepository.UpdateAsync(_mapper.Map(pedidoDto, entity));

            return await GetByIdAsync(id);
        }

        public async Task<PedidoDto> AddItensAsync(int id, CreatePedidoItemDto pedidoItemDto)
        {
            var pedido = await _pedidoRepository.GetByIdAsync(id); 
            var pedidoItem = _mapper.Map<PedidoItem>(pedidoItemDto);
            pedidoItem.Produto = await _produtoRepository.GetByIdAsync(pedidoItemDto.ProdutoId);

            pedido.AdicionarItem(pedidoItem);

            await _pedidoRepository.UpdateAsync(pedido);

            return await GetByIdAsync(id);
        }
    }
}
