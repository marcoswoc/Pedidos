using AutoMapper;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Models.PedidoItem;
using Pedidos.Domain.Entity;
using Pedidos.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Application.Services
{
    public class PedidoItemService : IPedidoItemService
    {
        private readonly IMapper _mapper;
        private readonly IPedidoItemRepository _pedidoItemRepository;

        public PedidoItemService(IMapper mapper, IPedidoItemRepository pedidoItemRepository)
        {
            _mapper = mapper;
            _pedidoItemRepository = pedidoItemRepository;
        }

        public async Task<PedidoItemDto> AddAsync(CreatePedidoItemDto pedidoItemDto)
        {
            var pedidoItem = await _pedidoItemRepository.AddAsync(_mapper.Map<PedidoItem>(pedidoItemDto));
            return _mapper.Map<PedidoItemDto>(pedidoItem);
        }

        public async Task<IEnumerable<PedidoItemDto>> GetAllAsync()
        {
            var pedidoItens = await _pedidoItemRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<PedidoItemDto>>(pedidoItens);
        }

        public async Task<PedidoItemDto> GetByIdAsync(int id)
        {
            var pedidoItem = await _pedidoItemRepository.GetByIdAsync(id);
            return _mapper.Map<PedidoItemDto>(pedidoItem);
        }

        public async Task RemoveAsync(int id)
        {
            await _pedidoItemRepository.RemoveAsync(id);
        }

        public async Task<PedidoItemDto> UpdateAsync(UpdatePedidoItemDto pedidoItemDto)
        {
            var pedidoItem = await _pedidoItemRepository.UpdateAsync(_mapper.Map<PedidoItem>(pedidoItemDto));
            return _mapper.Map<PedidoItemDto>(pedidoItem);
        }
    }
}
