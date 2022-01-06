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

        public void GravarComentario(Mensagem comentario)
        {
            //if (comentario.ID == 0)
            context.Comentarios.Add(comentario);
            //else
            //    context.Entry(comentario).State = EntityState.Modified;

            Usuario User = context.Usuarios.Where(u => u.ID == comentario.UserID).First();
            User.Comentarios.Add(comentario);

            Postagem Post = context.Postagens.Where(p => p.ID == comentario.PostID).First();
            Post.Comentarios.Add(comentario);

            context.SaveChanges();
        }

        public IQueryable<Mensagem> GetCommentsByPostID(int PostID)
        {
            try
            {
                return context.Comentarios.Where(p => p.PostID == PostID);
            }
            catch
            {
                return null;
            }
        }
    }
}