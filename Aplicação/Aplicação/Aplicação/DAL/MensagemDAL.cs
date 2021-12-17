using Aplicação.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aplicação.DAL
{
    public class MensagemDAL
    {
        EFContext context = new EFContext();

        public void GravarMensagem(Mensagem mensagem)
        {
            Usuario User = context.Usuarios.Where(u => u.ID == mensagem.UserID).First();
            User.Mensagens.Add(mensagem);

            Postagem Post = context.Postagens.Where(p => p.ID == mensagem.PostID).First();
            Post.Comentarios.Add(mensagem);

            context.SaveChanges();
        }
    }
}