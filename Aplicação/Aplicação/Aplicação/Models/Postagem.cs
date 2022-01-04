using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplicação.Models
{
    public class Postagem
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Data { get; set; }

        public string ImagemMimeType { get; set; }
        public byte[] Imagem { get; set; }
        public string NomeArquivo { get; set; }
        public long TamanhoArquivo { get; set; }

        public string Descricao { get; set; }
        public VisibilidadePostagem Visibilidade { get; set; }
        public Categorias Filtro { get; set; }
        public ICollection<Mensagem> Comentarios { get; set; }
        public long? Likes { get; set; }
        public enum VisibilidadePostagem
        {
            Público,
            Privado,
            Apenas_amigos
        }
    }
}