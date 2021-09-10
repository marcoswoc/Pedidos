using AutoMapper;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Models.Endereco;
using Pedidos.Domain.Entity;
using Pedidos.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Application.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IMapper _mapper;
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IMapper mapper, IEnderecoRepository enderecoRepository)
        {
            _mapper = mapper;
            _enderecoRepository = enderecoRepository;
        }

        public async Task<EnderecoDto> AddAsync(CreateEnderecoDto enderecoDto)
        {
            var endereco = await _enderecoRepository.AddAsync(_mapper.Map<Endereco>(enderecoDto));
            return _mapper.Map<EnderecoDto>(endereco);
        }

        public async Task<IEnumerable<EnderecoDto>> GetAllAsync()
        {
            var enderecos = await _enderecoRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<EnderecoDto>>(enderecos);
        }

        public async Task<EnderecoDto> GetByIdAsync(int id)
        {
            var endereco = await _enderecoRepository.GetByIdAsync(id);
            return _mapper.Map<EnderecoDto>(endereco);
        }

        public async Task RemoveAsync(int id)
        {
            await _enderecoRepository.RemoveAsync(id);
        }

        public async Task<EnderecoDto> UpdateAsync(UpdateEnderecoDto enderecoDto)
        {
            var endereco = await _enderecoRepository.UpdateAsync(_mapper.Map<Endereco>(enderecoDto));
            return _mapper.Map<EnderecoDto>(endereco);
        }
    }
}
