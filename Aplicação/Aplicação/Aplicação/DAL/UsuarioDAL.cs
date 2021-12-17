using Aplicação.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aplicação.DAL
{
    public class UsuarioDAL
    {
        EFContext context = new EFContext();

        public void GravarUsuario(Usuario usuario)
        {
            if (usuario.ID == 0)
                context.Usuarios.Add(usuario);
            else
                context.Entry(usuario).State = EntityState.Modified;

            context.SaveChanges();
        }

        public Usuario GetUserByID(long id)
        {
            return context.Usuarios.Where(u => u.ID == id).Include("Pets").Include("Postagens").First();
        }

        public Usuario GetUserByEmail(string Email)
        {
            return context.Usuarios.Where(u => u.Email == Email).First();
            //return context.Usuarios.Where(u => u.Email == Email).Include("Pets").First();
        }

        public Usuario EliminarUsuarioPorId(long id)
        {
            Usuario user = GetUserByID(id);
            context.Usuarios.Remove(user);
            context.SaveChanges();
            return user;
        }


    }
}