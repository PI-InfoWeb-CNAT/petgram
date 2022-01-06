using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aplicação.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string User { get; set; }

        [Required(ErrorMessage = "Por favor, insira seu nome.")]
        [DisplayName("Nome")]
        [MaxLength(50, ErrorMessage = "O nome é muito grande.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, insira sua data de nascimento.")]
        [DisplayName("Data de nascimento")]
        public DateTime Data_Nascimento { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

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
        public string ImagemMimeType { get; set; }
        public byte[] Imagem { get; set; }
        public string NomeArquivo { get; set; }
        public long TamanhoArquivo { get; set; }
        public virtual ICollection<Pet> Pets { get; set; }

        public virtual ICollection<Postagem> Postagens { get; set; }

        public virtual ICollection<Mensagem> Comentarios { get; set; }
    }
}