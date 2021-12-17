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
        public ActionResult Create(Usuario usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    usuarioDAL.GravarUsuario(usuario);
                    return RedirectToAction("../Pet/Create", new { UserID = usuario.ID, new_pet = false });
                }

                return View(usuario);
            }
            catch
            {
                return View(usuario);
            }
        }
    }
}