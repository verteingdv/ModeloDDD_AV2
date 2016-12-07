using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModeloDDD_AV2.MVC.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public int EnderecoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Logradouro.")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Preencha o campo Numero.")]
        [MaxLength(15, ErrorMessage = "Máximo de {0} caracteres.")]
        public string Numero { get; set; }

        
        [Required(ErrorMessage = "Preencha o campo Complemento.")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres.")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Preencha o campo Bairro.")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres.")]
        public string Bairro { get; set; }

        
        [Required(ErrorMessage = "Preencha o campo Municipio.")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres.")]
        public string Municipio { get; set; }

        [Required(ErrorMessage = "Preencha o campo CEP.")]
        [MaxLength(9, ErrorMessage = "Máximo de {0} caracteres.")]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "O CEP deverá estar no formato 00000-000")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Preencha o campo Uf.")]
        [MaxLength(2, ErrorMessage = "Máximo de {0} caracteres. Exemplo: RJ para Rio de Janeiro, SP para São Paulo...")]
        public string Uf { get; set; }

        public int FornecedorId { get; set; }
        public virtual FornecedorViewModel Fornecedor { get; set; }
    }
}
