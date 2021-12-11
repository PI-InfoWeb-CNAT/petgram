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
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public VisibilidadePostagem Visibilidade { get; set; }
        public Categorias Filtro { get; set; }
        public ICollection<Mensagem> Comentarios { get; set; }

        public enum VisibilidadePostagem
        {
            Público,
            Privado,
            Apenas_amigos
        }
    }
}