using Pedidos.Persistence.Entity.Base;
using System;
using System.Collections.Generic;

namespace Pedidos.Persistence.Entity
{
    public class Pedido : Entidade
    {
        public long Codigo { get; set; }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public List<Produto> Produtos { get; set; }
        public string Status { get; set; }
        public string StatusPagamento { get; set; }
        public string TipoPagamento { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorPago { get; set; }
        public DateTime DataHora { get; set; }
        public  string Observacao { get; set; }
    }
}
