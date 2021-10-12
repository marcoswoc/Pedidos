using AutoMapper;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Models.Cliente;
using Pedidos.Domain.Entity;
using Pedidos.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IMapper _mapper;
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(
            IClienteRepository clienteRepository,
            IMapper mapper)
        {
            _mapper = mapper;
            _clienteRepository = clienteRepository;
        }

        public async Task<ClienteDto> CreateAsync(CreateClienteDto clienteDto)
        {
            var cliente = await _clienteRepository.CreateAsync(_mapper.Map<Cliente>(clienteDto));
            return _mapper.Map<ClienteDto>(cliente);
        }

        public async Task<IEnumerable<ClienteDto>> GetAllAsync()
        {
            var clientes = await _clienteRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ClienteDto>>(clientes);
        }

        public async Task<ClienteDto> GetByIdAsync(int id)
        {
            var cliente = await _clienteRepository.GetByIdAsync(id);
            return _mapper.Map<ClienteDto>(cliente);
        }

        public async Task RemoveAsync(int id)
        {
            await _clienteRepository.RemoveAsync(id);
        }

        public async Task<ClienteDto> UpdateAsync(int id, CreateClienteDto clienteDto)
        {
            var entity = await _clienteRepository.GetByIdAsync(id);

            await _clienteRepository.UpdateAsync(_mapper.Map(clienteDto, entity));

            return await GetByIdAsync(id);
        }
    }
}
