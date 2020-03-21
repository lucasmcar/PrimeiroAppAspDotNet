using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DevPoa.TesteAspNetMvc.Web.Models
{
    public class Pessoa
    {
        /// <summary>
        /// Campo Nome é obrigatório
        /// </summary>
        [Required(ErrorMessage = "O nome é obrigatório")]
        [DisplayName("Seu nome: ")]
        [MaxLength(50, ErrorMessage = "Nome pode ter no máximo 50 caracteres")]
        [MinLength(5, ErrorMessage = "Nome deve ter no mínimo 5 caracteres")]
        public string Nome { get; set; }

        [DisplayName("Sua idade:")]
        public int Idade { get; set; }

        /// <summary>
        /// Campo endereço é obrigatório
        /// </summary>
        [Required(ErrorMessage = "O endereço da pessoa é obrigatório")]
        [DisplayName("Seu endereço: ")]
        [MaxLength(100, ErrorMessage ="Enredeço poder ter no máximo 100 caracteres")]
        
        public string Endereco { get; set; }

        /// <summary>
        /// Email é obrigatório
        /// </summary>
        [Required(ErrorMessage = "O email da pessoa é obrigatório")]
        [DisplayName("Email:")]
        [DataType(DataType.EmailAddress)]
        public  String Email { get; set; }

        public Boolean Ativo { get; set; }
    }
}