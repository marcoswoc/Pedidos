using AutoMapper;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Models.Produto;
using Pedidos.Domain.Entity;
using Pedidos.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IMapper _mapper;
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IMapper mapper, IProdutoRepository produtoRepository)
        {
            _mapper = mapper;
            _produtoRepository = produtoRepository;
        }

        public async Task<ProdutoDto> CreateAsync(CreateProdutoDto ProdutoDto)
        {
            var produto = await _produtoRepository.CreateAsync(_mapper.Map<Produto>(ProdutoDto));
            return _mapper.Map<ProdutoDto>(produto);
        }

        public async Task<IEnumerable<ProdutoDto>> GetAllAsync()
        {
            var produtos = await _produtoRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProdutoDto>>(produtos);
        }

        public async Task<ProdutoDto> GetByIdAsync(int id)
        {
            var produto = await _produtoRepository.GetByIdAsync(id);
            return _mapper.Map<ProdutoDto>(produto);
        }

        public async Task RemoveAsync(int id)
        {
            await _produtoRepository.RemoveAsync(id);
        }

        public async Task<ProdutoDto> UpdateAsync(int id, CreateProdutoDto ProdutoDto)
        {
            var entity = await _produtoRepository.GetByIdAsync(id);

            await _produtoRepository.UpdateAsync(_mapper.Map(ProdutoDto, entity));

            return await GetByIdAsync(id);
        }

    }
}
