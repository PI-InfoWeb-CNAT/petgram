using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplicação.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Perfil()
        {
            return View();
        }

        public ActionResult Feed()
        {
            return View();
        }

        public ActionResult Publicar()
        {
            return View();
        }
    }
}