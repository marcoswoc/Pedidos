﻿using Pedidos.Application.Models.Produto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Application.Interfaces
{
    public interface IProdutoService
    {
        Task<ProdutoDto> GetByIdAsync(int id);
        Task<ProdutoDto> AddAsync(CreateProdutoDto entity);
        Task<ProdutoDto> UpdateAsync(UpdateProdutoDto entity);
        Task RemoveAsync(int id);
        Task<IEnumerable<ProdutoDto>> GetAllAsync();
    }
}
