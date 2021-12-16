using Aplicação.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aplicação.DAL
{
    public class PostagemDAL
    {
        EFContext context = new EFContext();

        public void GravarPost(Postagem post)
        {
            if (post.ID == 0)
            {
                context.Postagens.Add(post);
                Usuario User = context.Usuarios.Where(u => u.ID == post.UserID).First();
                User.Postagens.Add(post);
            }

            else
                context.Entry(post).State = EntityState.Modified;

            context.SaveChanges();
        }

        public Postagem ObterPostagemPorId(long id)
        {
            return context.Postagens.Where(p => p.ID == id).First();
        }

        public IQueryable<Postagem> ObterPostagensClassificadasPorData()
        {
            return context.Postagens.OrderBy(p => p.Data);
        }
    }
}