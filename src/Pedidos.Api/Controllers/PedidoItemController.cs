﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.Interfaces;
using Pedidos.Application.Models.PedidoItem;
using System.Threading.Tasks;

namespace Pedidos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoItemController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPedidoItemService _pedidoItemService;
        public PedidoItemController(IMapper mapper, IPedidoItemService pedidoItemService)
        {
            _mapper = mapper;
            _pedidoItemService = pedidoItemService;
        }

        [HttpPost]
        public async Task<ActionResult<PedidoItemDto>> AddAsync([FromBody] CreatePedidoItemDto pedidoItemDto)
        {
            return await _pedidoItemService.AddAsync(pedidoItemDto);
        }
    }
}