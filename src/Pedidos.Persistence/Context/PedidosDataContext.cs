﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pedidos.Domain.Entity;

namespace Pedidos.Persistence.Context
{
    public class PedidosDataContext : IdentityDbContext
    {
        public PedidosDataContext(DbContextOptions<PedidosDataContext> options) 
            : base(options)
        {

        }

        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Vendedor> Vendedores { get; set; }
        public virtual DbSet<PedidoItem> PedidoItens { get; set; }        

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
                p.Property(p => p.Bairro).HasMaxLength(80);
                p.Property(p => p.Cep).HasColumnType("CHAR(8)");
                p.Property(p => p.Cidade).HasMaxLength(80);
                p.Property(p => p.Complemento).HasMaxLength(250);
                p.Property(p => p.Logradouro).HasMaxLength(80);
                p.Property(p => p.NumeroEndereco).HasMaxLength(10).IsRequired();
                p.Property(p => p.Uf).HasColumnType("CHAR(2)");

                p.HasIndex(i => i.Nome).HasDatabaseName("idx_cliente_nome");
            });

            modelBuilder.Entity<Vendedor>(p =>
            {
                p.ToTable("Vendedores");
                p.HasKey(p => p.Id);
                p.Property(p => p.Nome).HasMaxLength(80).IsRequired();

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
            });

            modelBuilder.Entity<PedidoItem>(p =>
            {
                p.ToTable("PedidoItens");
                p.HasKey(p => p.Id);
                p.Property(p => p.Quantidade).HasDefaultValue(1).IsRequired();
                p.Property(p => p.Valor).HasColumnType("DECIMAL(18,2)").IsRequired();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
