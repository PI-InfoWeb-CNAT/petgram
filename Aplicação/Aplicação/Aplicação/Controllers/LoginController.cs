using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aplicação.Models;
using Aplicação.DAL;

namespace Aplicação.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UsuarioCadastro usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UsuarioCadastro userWithThatEmail = UsuarioDAL.GetUserByEmail(usuario.Email);
                    return RedirectToAction("../Pet/Create", new { UserID = usuario.ID });
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