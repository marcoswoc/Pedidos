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
        
        public ClienteService(IMapper mapper, IClienteRepository clienteRepository)
        {
            _mapper = mapper;
            _clienteRepository = clienteRepository;
        }

        public async Task<ClienteDto> AddAsync(CreateClienteDto clienteDto)
        {
            var cliente = await _clienteRepository.AddAsync(_mapper.Map<Cliente>(clienteDto));
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

        public async Task<ClienteDto> UpdateAsync(UpdateClienteDto clienteDto)
        {
            var cliente = await _clienteRepository.UpdateAsync(_mapper.Map<Cliente>(clienteDto));
            return _mapper.Map<ClienteDto>(cliente);
        }
    }
}
