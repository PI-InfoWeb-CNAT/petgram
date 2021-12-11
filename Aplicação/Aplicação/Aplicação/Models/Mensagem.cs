using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplicação.Models
{
    public class Mensagem
    {
        public int ID { get; set; }
        public int FK { get; set; }
        public string Descricao { get; set; }
        public DateTime data { get; set; }
    }
}