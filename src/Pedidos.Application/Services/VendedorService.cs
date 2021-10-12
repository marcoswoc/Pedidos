using AutoMapper;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Models.Vendedor;
using Pedidos.Domain.Entity;
using Pedidos.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Application.Services
{
    public class VendedorService : IVendedorService
    {
        private readonly IMapper _mapper;
        private readonly IVendedorRepository _vendedorRepository;

        public VendedorService(IMapper mapper, IVendedorRepository vendedorRepository)
        {
            _mapper = mapper;
            _vendedorRepository = vendedorRepository;
        }

        public async Task<VendedorDto> CreateAsync(CreateVendedorDto VendedorDto)
        {
            var vendedor = await _vendedorRepository.CreateAsync(_mapper.Map<Vendedor>(VendedorDto));
            return _mapper.Map<VendedorDto>(vendedor);
        }

        public async Task<IEnumerable<VendedorDto>> GetAllAsync()
        {
            var vendedores = await _vendedorRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<VendedorDto>>(vendedores);
        }

        public async Task<VendedorDto> GetByIdAsync(int id)
        {
            var vendedor = await _vendedorRepository.GetByIdAsync(id);
            return _mapper.Map<VendedorDto>(vendedor);
        }

        public async Task RemoveAsync(int id)
        {
            await _vendedorRepository.RemoveAsync(id);
        }

        public async Task<VendedorDto> UpdateAsync(int id, CreateVendedorDto vendedorDto)
        {
            var entity = await _vendedorRepository.GetByIdAsync(id);

            await _vendedorRepository.UpdateAsync(_mapper.Map(vendedorDto, entity));

            return await GetByIdAsync(id);
        }
    }
}
