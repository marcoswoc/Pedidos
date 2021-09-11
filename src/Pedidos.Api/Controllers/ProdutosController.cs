using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Models.Produto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : Controller
    {
        private readonly IProdutoService _produtoService;
        public ProdutosController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpPost]
        public async Task<ActionResult<ProdutoDto>> CreateAsync([FromBody] CreateProdutoDto produtoDto)
        {
            return Ok(await _produtoService.AddAsync(produtoDto));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetAllAsync()
        {
            return Ok(await _produtoService.GetAllAsync());
        }
    }
}
