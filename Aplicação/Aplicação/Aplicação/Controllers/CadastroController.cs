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

        [HttpPost]
        public ActionResult Create(UsuarioCadastro usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    usuarioDAL.GravarUsuario(usuario);
                    return RedirectToAction("../Pet/Create", new { id = usuario.ID });
                }

                return View(usuario);
            } 
            catch
            {
                return View(usuario);
            }
        }

        // GET: Cadastro
        public ActionResult Create()
        {
            return View();
        }

    }
}