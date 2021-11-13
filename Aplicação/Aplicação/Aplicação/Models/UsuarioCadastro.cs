using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aplicação.Models
{
    public class UsuarioCadastro
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Por favor, insira um nome de usuário.")]
        [DisplayName("Nome")]
        [MaxLength(50, ErrorMessage = "O nome de usuário é muito grande.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, insira sua idade.")]
        [DisplayName("Idade")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Por favor, insira um endereço de email.")]
        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "Por favor, insira um endereço de email válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor, insira uma senha válida.")]
        [DisplayName("Senha")]
        [DataType(DataType.Password)]
        [Compare("ConfirmaSenha", ErrorMessage = "As senhas não coincidem.")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Por favor, confirme sua senha.")]
        [DisplayName("Confirmar senha")]
        [DataType(DataType.Password)]
        public string ConfirmaSenha { get; set; }
    }
}