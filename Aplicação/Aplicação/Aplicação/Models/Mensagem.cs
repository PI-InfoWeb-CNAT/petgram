using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplicação.Models
{
    public class Mensagem
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int PostID { get; set; }
        public string Descricao { get; set; }
        public string Data { get; set; }
    }
}