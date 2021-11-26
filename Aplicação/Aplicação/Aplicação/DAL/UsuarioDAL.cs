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

        public void GravarUsuario(UsuarioCadastro usuario)
        {
            if (usuario.ID == 0)
                context.Usuarios.Add(usuario);
            else
                context.Entry(usuario).State = EntityState.Modified;

            context.SaveChanges();
        }

        public UsuarioCadastro GetUserByID(long id)
        {
            return context.Usuarios.Where(u => u.ID == id).Include("Pets").First();
        }

        public UsuarioCadastro GetUserByEmail(string Email)
        {
            return context.Usuarios.Where(u => u.Email == Email).First();
            //return context.Usuarios.Where(u => u.Email == Email).Include("Pets").First();
        }


    }
}