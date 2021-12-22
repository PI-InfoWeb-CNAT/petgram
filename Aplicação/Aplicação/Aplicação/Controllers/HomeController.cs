using Aplicação.DAL;
using Aplicação.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplicação.Controllers
{
    public class HomeController : Controller
    {
        PostagemDAL postDAL = new PostagemDAL();
        UsuarioDAL userDAL = new UsuarioDAL();
        
        //GET: Index
        public ActionResult Index()
        {
            return View();
        }

        //GET: Perfil
        public ActionResult Perfil(long UserID)
        {
            ViewBag.UserID = UserID;
            return View(userDAL.GetUserByID(UserID));
        }

        //GET: Editar Perfil
        public ActionResult EditarPerfil(long userID)
        {
            Usuario user = userDAL.GetUserByID(userID);
            ViewBag.UserID = userID;
            return View(user);
        }

        //POST: Editar Perfil
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarPerfil(Usuario user)
        {
            userDAL.GravarUsuario(user);
            return RedirectToAction("Perfil", new { UserID = user.ID });
        }

        //POST: Deletar Usuario
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletarUsuario(long id)
        {
            try
            {
                Usuario user = userDAL.EliminarUsuarioPorId(id);
                TempData["Message"] = "Usuário " + user.Nome.ToUpper() + " foi removido";
                return RedirectToAction("../Cadastro/Create");
            }
            catch
            {
                return RedirectToAction("Perfil", new { UserID = id });
            }
        }


        // GET: Feed
        public ActionResult Feed(int UserID)
        {
            ViewBag.UserID = UserID;
            return View(postDAL.ObterPostagensClassificadasPorData());
        }


    }
}