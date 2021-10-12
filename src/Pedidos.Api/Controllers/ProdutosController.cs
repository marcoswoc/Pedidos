using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Models.Base;
using Pedidos.Application.Models.Produto;
using Pedidos.Application.Models.Vendedor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pedidos.Api.Controllers
{
    [ApiController]
    [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status404NotFound)]
    [Route("api/[controller]")]
    public class ProdutosController : Controller
    {
        private readonly IProdutoService _produtoService;
        public ProdutosController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(ProdutoDto), StatusCodes.Status200OK)]
        public async Task<ActionResult<ProdutoDto>> CreateAsync([FromBody] CreateProdutoDto produtoDto)
        {
            return Ok(await _produtoService.CreateAsync(produtoDto));
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ProdutoDto>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetAllAsync()
        {
            return Ok(await _produtoService.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(ProdutoDto), StatusCodes.Status200OK)]
        public async Task<ActionResult<ProdutoDto>> GetByIdAsync(int id)
        {
            return Ok(await _produtoService.GetByIdAsync(id));
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(typeof(ProdutoDto), StatusCodes.Status200OK)]
        public async Task<ActionResult<ProdutoDto>> UpdateAsync([FromRoute] int id, [FromBody] CreateProdutoDto produtoDto)
        {
            return Ok(await _produtoService.UpdateAsync(id, produtoDto));
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(typeof(SuccessModel), StatusCodes.Status200OK)]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await _produtoService.RemoveAsync(id);
            return Ok(new SuccessModel("deletado com sucesso"));
        }
    }
}
