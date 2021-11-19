using Aplicação.DAL;
using Aplicação.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplicação.Controllers
{
    public class CadastroController : Controller
    {
        UsuarioDAL usuarioDAL = new UsuarioDAL();
        private ActionResult GravarUsuario(UsuarioCadastro usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    usuarioDAL.GravarUsuario(usuario);
                    return RedirectToAction("../Pet/Create);
                }

                return View(usuario);
            } 
            catch
            {
                return View(usuario);
            }
        }

        // GET: Cadastro
        public ActionResult Cadastro()
        {
            return View();
        }

        // POST: Cadastro
        [HttpPost]
        public ActionResult Cadastro(UsuarioCadastro usuario)
        {
            return GravarUsuario(usuario);
        }
    }
}