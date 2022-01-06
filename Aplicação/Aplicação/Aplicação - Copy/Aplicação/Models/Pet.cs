using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aplicação.Models
{
    public class Pet
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Qual o nome do seu Pet?")]
        [MaxLength(50, ErrorMessage = "O nome do seu Pet é muito grande!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A que categoria o seu Pet pertence?")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Me fale um pouco do seu Pet ;)")]
        public string Description { get; set; }

        public virtual Usuario Owner { get; set; }
        public int UserID { get; set; }
    }
}