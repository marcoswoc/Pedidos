IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Enderecos] (
    [Id] int NOT NULL IDENTITY,
    [Cep] CHAR(8) NULL,
    [Logradouro] nvarchar(80) NULL,
    [Complemento] nvarchar(250) NULL,
    [Bairro] nvarchar(80) NULL,
    [Cidade] nvarchar(80) NULL,
    [Uf] CHAR(2) NULL,
    [Numero] nvarchar(10) NOT NULL,
    CONSTRAINT [PK_Enderecos] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Produtos] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(60) NOT NULL,
    [Descricao] nvarchar(512) NULL,
    [UnidadeMedida] nvarchar(20) NOT NULL,
    [QuantidadeDisponivel] int NOT NULL,
    [Valor] DECIMAL(18,2) NOT NULL,
    [Ativo] bit NOT NULL DEFAULT CAST(0 AS bit),
    CONSTRAINT [PK_Produtos] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Vendedores] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(80) NOT NULL,
    CONSTRAINT [PK_Vendedores] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Clientes] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(80) NOT NULL,
    [Telefone] CHAR(11) NULL,
    [EnderecoId] int NOT NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Clientes_Enderecos_EnderecoId] FOREIGN KEY ([EnderecoId]) REFERENCES [Enderecos] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Pedidos] (
    [Id] int NOT NULL IDENTITY,
    [Codigo] bigint NOT NULL,
    [ClienteId] int NOT NULL,
    [VendedorId] int NOT NULL,
    [StatusPedido] nvarchar(20) NOT NULL,
    [Pagamento] bit NOT NULL DEFAULT CAST(0 AS bit),
    [TipoPagamento] nvarchar(20) NOT NULL,
    [ValorTotal] DECIMAL(18,2) NOT NULL,
    [ValorPago] DECIMAL(18,2) NULL,
    [DataHoraInicio] datetime2 NULL DEFAULT (GETDATE()),
    [DataHoraFim] datetime2 NULL,
    [Observacao] nvarchar(512) NULL,
    CONSTRAINT [PK_Pedidos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Pedidos_Clientes_ClienteId] FOREIGN KEY ([ClienteId]) REFERENCES [Clientes] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Pedidos_Vendedores_VendedorId] FOREIGN KEY ([VendedorId]) REFERENCES [Vendedores] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [PedidoItens] (
    [Id] int NOT NULL IDENTITY,
    [PedidoId] int NOT NULL,
    [ProdutoId] int NOT NULL,
    [Quantidade] int NOT NULL DEFAULT 1,
    [Valor] DECIMAL(18,2) NOT NULL,
    CONSTRAINT [PK_PedidoItens] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_PedidoItens_Pedidos_PedidoId] FOREIGN KEY ([PedidoId]) REFERENCES [Pedidos] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_PedidoItens_Produtos_ProdutoId] FOREIGN KEY ([ProdutoId]) REFERENCES [Produtos] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [idx_cliente_nome] ON [Clientes] ([Nome]);
GO

CREATE INDEX [IX_Clientes_EnderecoId] ON [Clientes] ([EnderecoId]);
GO

CREATE INDEX [IX_PedidoItens_PedidoId] ON [PedidoItens] ([PedidoId]);
GO

CREATE INDEX [IX_PedidoItens_ProdutoId] ON [PedidoItens] ([ProdutoId]);
GO

CREATE INDEX [IX_Pedidos_ClienteId] ON [Pedidos] ([ClienteId]);
GO

CREATE INDEX [IX_Pedidos_VendedorId] ON [Pedidos] ([VendedorId]);
GO

CREATE INDEX [idx_vendedor_nome] ON [Vendedores] ([Nome]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210907175728_PrimeiraMigracao', N'5.0.9');
GO

COMMIT;
GO

