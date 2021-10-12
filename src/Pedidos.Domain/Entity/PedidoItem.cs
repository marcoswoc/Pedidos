using Pedidos.Domain.Entity.Base;

namespace Pedidos.Domain.Entity
{
    public class PedidoItem : EntityBase
    {
        public virtual int PedidoId { get; set; }
        public virtual int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual int Quantidade { get; set; }
        public virtual decimal Valor { get; set; }

        public void CalculaValor()
        {
            this.Valor += this.Quantidade * this.Produto.Valor;            
        }

        public void AtualizaValor(PedidoItem item)
        {
            this.Quantidade += item.Quantidade;
            this.Valor += item.Valor;            
        }
    }
}
