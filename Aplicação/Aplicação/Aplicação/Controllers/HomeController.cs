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
        private ActionResult GravarPost(Postagem post)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    postDAL.GravarPost(post);
                    return RedirectToAction("Feed");
                }

                return View(post);
            }
            catch
            {
                return View(post);
            }
        }

        public ActionResult Perfil()
        {
            return View();
        }

        public ActionResult Feed()
        {
            return View();
        }


        // GET: Publicar
        public ActionResult Publicar(int UserID)
        {
            ViewBag.UserID = UserID;
            ViewBag.Data = DateTime.Now;
            return View();
        }

        // POST: Publicar
        [HttpPost]
        public ActionResult Publicar(Postagem post)
        {
            return GravarPost(post);
        }
    }
}