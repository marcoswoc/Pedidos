using Microsoft.EntityFrameworkCore;
using Pedidos.Domain.Entity;

namespace Pedidos.Persistence.Context
{
    public class PedidosDataContext : DbContext
    {
        public PedidosDataContext(DbContextOptions<PedidosDataContext> options) 
            : base(options)
        {

        }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<PedidoItem> PedidoItens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
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
                p.Property(p => p.Valor).HasColumnType("DECIMAL(18,2)").IsRequired();
                p.Property(p => p.Descricao).HasMaxLength(512);
                p.Property(p => p.Ativo).HasColumnType("bit").HasDefaultValue(false);
            });

            modelBuilder.Entity<Pedido>(p =>
            {
                p.ToTable("Pedidos");
                p.HasKey(p => p.Id);
                p.Property(p => p.DataHoraInicio).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
                p.Property(p => p.Codigo);
                p.Property(p => p.DataHoraFim);
                p.Property(p => p.Observacao).HasMaxLength(512);
                p.Property(p => p.ValorPago).HasColumnType("DECIMAL(18,2)"); 
                p.Property(p => p.ValorTotal).HasColumnType("DECIMAL(18,2)").IsRequired();
                p.Property(p => p.StatusPedido).HasConversion<string>().HasMaxLength(20).IsRequired();
                p.Property(p => p.TipoPagamento).HasConversion<string>().HasMaxLength(20).IsRequired();
                p.Property(p => p.Pagamento).HasColumnType("bit").HasDefaultValue(false);
                
                p.HasMany(p => p.Itens)
                    .WithOne(p => p.Pedido)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<PedidoItem>(p =>
            {
                p.ToTable("PedidoItens");
                p.HasKey(p => p.Id);
                p.Property(p => p.Quantidade).HasDefaultValue(1).IsRequired();
                p.Property(p => p.Valor).HasColumnType("DECIMAL(18,2)").IsRequired();                
            });

            modelBuilder.Entity<Endereco>(p =>
            {
                p.ToTable("Enderecos");
                p.HasKey(p => p.Id);
                p.Property(p => p.Bairro).HasMaxLength(80);
                p.Property(p => p.Cep).HasColumnType("CHAR(8)");
                p.Property(p => p.Cidade).HasMaxLength(80);
                p.Property(p => p.Complemento).HasMaxLength(250);
                p.Property(p => p.Logradouro).HasMaxLength(80);
                p.Property(p  => p.Numero).HasMaxLength(10).IsRequired();
                p.Property(p => p.Uf).HasColumnType("CHAR(2)");
            });
        }

    }
}
