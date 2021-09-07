using Microsoft.EntityFrameworkCore;
using Pedidos.Persistence.Entity;

namespace Pedidos.Persistence.Context
{
    public class PedidosDataContext : DbContext
    {
        public PedidosDataContext(DbContextOptions<PedidosDataContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(p =>
            {
                p.ToTable("Clientes");
                p.HasKey(p => p.Id);
                p.Property(p => p.Nome).HasMaxLength(80).IsRequired();
                p.Property(p => p.Telefone).HasColumnType("CHAR(11)");

                p.HasMany(p => p.Pedidos)
                    .WithOne(p => p.Cliente)
                    .OnDelete(DeleteBehavior.Cascade);

                p.HasIndex(i => i.Nome).HasDatabaseName("idx_cliente_nome");
            });

            modelBuilder.Entity<Vendedor>(p =>
            {
                p.ToTable("Vendedores");
                p.HasKey(p => p.Id);
                p.Property(p => p.Nome).HasMaxLength(80).IsRequired();

                p.HasMany(p => p.Pedidos)
                    .WithOne(p => p.Vendedor)
                    .OnDelete(DeleteBehavior.Cascade);

                p.HasIndex(i => i.Nome).HasDatabaseName("idx_vendedor_nome");

            });

            modelBuilder.Entity<Produto>(p => 
            {
                p.ToTable("Produtos");
                p.HasKey(p => p.Id);
                p.Property(p => p.Nome).HasMaxLength(60).IsRequired();
                p.Property(p => p.QuantidadeDisponivel).IsRequired();
                p.Property(p => p.UnidadeMedida).HasConversion<string>().HasMaxLength(20).IsRequired();
                p.Property(p => p.Valor).IsRequired();
            });

            modelBuilder.Entity<Pedido>(p =>
            {
                p.ToTable("Pedidos");
                p.HasKey(p => p.Id);
                p.Property(p => p.DataHoraInicio).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
                p.Property(p => p.Codigo).IsRequired();
                p.Property(p => p.DataHoraFim);
                p.Property(p => p.Observacao).HasColumnType("VARCHAR(512)");
                p.Property(p => p.ValorPago);
                p.Property(p => p.ValorTotal).IsRequired();
                p.Property(p => p.StatusPedido).HasConversion<string>().HasMaxLength(20).IsRequired();
                p.Property(p => p.TipoPagamento).HasConversion<string>().HasMaxLength(20).IsRequired();
                p.Property(p => p.Pagamento).HasColumnType("BIT").IsRequired();
                
                p.HasMany(p => p.Itens)
                    .WithOne(p => p.Pedido)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<PedidoItem>(p =>
            {
                p.ToTable("PedidoItens");
                p.HasKey(p => p.Id);
                p.Property(p => p.Quantidade).HasDefaultValue(1).IsRequired();
                p.Property(p => p.Valor).IsRequired();                
            });

            modelBuilder.Entity<Endereco>(p =>
            {
                p.ToTable("Enderecos");
                p.HasKey(p => p.Id);
                p.Property(p => p.Bairro).HasMaxLength(80);
                p.Property(p => p.Cep).HasColumnType("CHAR(8)");
                p.Property(p => p.Cidade).HasMaxLength(80);
                p.Property(p => p.Complemento).HasColumnType("VARCHAR(250)");
                p.Property(p => p.Logradouro).HasMaxLength(80);
                p.Property(p  => p.Numero).IsRequired();
                p.Property(p => p.Uf).HasColumnType("CHAR(2)");
            });
        }

    }
}
