﻿using Pedidos.Application.Models.Base;

namespace Pedidos.Application.Models.Endereco
{
    public class CreateEnderecoDto : IModelBase
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Numero { get; set; }
    }
}