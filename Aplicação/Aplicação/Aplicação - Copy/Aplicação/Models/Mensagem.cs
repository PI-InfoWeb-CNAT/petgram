using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aplicação.Models
{
    public class Mensagem
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int PostID { get; set; }

        [DisplayName("Comentário")]
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
    }
}