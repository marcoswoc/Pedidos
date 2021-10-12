using Pedidos.Application.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Pedidos.Application.Models.Cliente
{
    public class CreateClienteDto : IModelBase
    {
        [Required(ErrorMessage = "Nome do cliente obrigatório")]
        [MaxLength(80, ErrorMessage = "Quantidade máxima de {1} caracteres")]
        public string Nome { get; set; }

        [MaxLength(11, ErrorMessage = "Quantidade máxima de {1} caracteres")]
        public string Telefone { get; set; }

        [MaxLength(8, ErrorMessage = "Quantidade máxima de {1} caracteres")]
        public string Cep { get; set; }

        [MaxLength(80, ErrorMessage = "Quantidade máxima de {1} caracteres")]
        public string Logradouro { get; set; }

        [MaxLength(250, ErrorMessage = "Quantidade máxima de {1} caracteres")]
        public string Complemento { get; set; }

        [MaxLength(80, ErrorMessage = "Quantidade máxima de {1} caracteres")]
        public string Bairro { get; set; }

        [MaxLength(80, ErrorMessage = "Quantidade máxima de {1} caracteres")]
        public string Cidade { get; set; }

        [MaxLength(2, ErrorMessage = "Quantidade máxima de {1} caracteres")]
        public string Uf { get; set; }

        [MaxLength(10, ErrorMessage = "Quantidade máxima de {1} caracteres")]
        public string NumeroEndereco { get; set; }
    }
}
