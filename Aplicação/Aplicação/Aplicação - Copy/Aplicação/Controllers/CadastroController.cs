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

        // GET: Cadastro
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cadastro
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuario usuario)
        {
            usuarioDAL.GravarUsuario(usuario);
            return RedirectToAction("../Pet/Create", new { UserID = usuario.ID, new_pet = false });
        }
    }
}