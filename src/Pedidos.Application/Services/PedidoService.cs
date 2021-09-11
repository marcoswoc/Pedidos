using AutoMapper;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Models.Pedido;
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

        public PedidoService(IMapper mapper, IPedidoRepository pedidoRepository)
        {
            _mapper = mapper;
            _pedidoRepository = pedidoRepository;
        }

        public async Task<PedidoDto> AddAsync(CreatePedidoDto pedidoDto)
        {
            var pedido = await _pedidoRepository.AddAsync(_mapper.Map<Pedido>(pedidoDto));
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

        public async Task<PedidoDto> UpdateAsync(UpdatePedidoDto pedidoDto)
        {
            var pedido = await _pedidoRepository.UpdateAsync(_mapper.Map<Pedido>(pedidoDto));
            return _mapper.Map<PedidoDto>(pedido);
        }
    }
}
