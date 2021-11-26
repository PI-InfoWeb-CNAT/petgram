using System;
using System.Collections.Generic;
using System.Linq;
using Aplicação.DAL;
using Aplicação.Models;
using System.Web;
using System.Web.Mvc;

namespace Aplicação.Controllers
{
    public class PetController : Controller
    {
        PetDAL petDAL = new PetDAL();
        private ActionResult GravarPet(Pet Pet)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    petDAL.GravarPet(Pet);
                    return RedirectToAction("../Cadastro/Create");
                }

                return View(Pet);
            }
            catch
            {
                return View(Pet);
            }
        }

        // GET: Pet
        public ActionResult Create(int UserID)
        {
            ViewBag.UserID = UserID;
            return View();
        }

        // POST: Pet
        [HttpPost]
        public ActionResult Create(Pet Pet)
        {
            return GravarPet(Pet);
        }
    }
}