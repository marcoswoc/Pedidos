using Pedidos.Application.Models.Base;
using Pedidos.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Pedidos.Application.Models.Pedido
{
    public class CreatePedidoDto : IModelBase
    {

        [Required(ErrorMessage = "ClienteId obrigatório")]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "VendedorId obrigatório")]
        public int VendedorId { get; set; }
        
        public bool Pagamento { get; set; }

        [EnumDataType(typeof(TipoPagamento))]
        public TipoPagamento TipoPagamento { get; set; }
        
        public decimal? ValorPago { get; set; }
        
        [MaxLength(512, ErrorMessage = "Quantidade máxima de {1} caracteres")]
        public string Observacao { get; set; }
    }
}
