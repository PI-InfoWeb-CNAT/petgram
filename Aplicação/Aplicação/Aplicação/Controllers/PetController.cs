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
                    ViewBag.new_pet = 134;
                    //return Redirect($"{Request.UrlReferrer.ToString()}&new_pet=True");
                    return RedirectToAction("../Pet/Create", new { UserID = Pet.UserID, new_pet = true });
                }

                return View(Pet);
            }
            catch
            {
                return View(Pet);
            }
        }

        // GET: Pet
        public ActionResult Create(int UserID, bool new_pet)
        {
            if (new_pet)
                ViewBag.new_pet = "Pet adicionado!";

            ViewBag.UserID = UserID;
            return View();
        }

        // POST: Pet
        [HttpPost]
        public ActionResult Create(Pet Pet)
        {
            return GravarPet(Pet);
        }

        // POST: Pet
        [HttpPost]
        public ActionResult Create2(Pet Pet)
        {
            return RedirectToAction("../Cadastro/Create");
        }
    }
}