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
                Usuario User = context.Usuarios.Where(u => u.ID == post.UserID).First();
                post.Likes = 0;
                post.User = User;
                context.Postagens.Add(post);
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

        public Postagem EliminarPostagemPorId(long id)
        {
            Postagem post= ObterPostagemPorId(id);
            context.Postagens.Remove(post);
            context.SaveChanges();
            return post;
        }

        public IQueryable<Postagem> ObterPostagensClassificadasPorData()
        {
            return context.Postagens.OrderByDescending(p => p.Data).Include("User");
        }

        public long? RegistrarLike(long id)
        {
            Postagem post = ObterPostagemPorId(id);
            post.Likes += 1;
            context.Entry(post).State = EntityState.Modified;
            context.SaveChanges();

            return post.Likes;
        }
    }
}