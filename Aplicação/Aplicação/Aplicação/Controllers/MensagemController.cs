using Aplicação.DAL;
using Aplicação.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplicação.Controllers
{
    public class MensagemController : Controller
    {
        MensagemDAL mensagemDAL = new MensagemDAL();

        // POST: Comentar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Comentar(Mensagem comentario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    mensagemDAL.GravarMensagem(comentario);
                }

                return View(comentario);
            }
            catch
            {
                return View(comentario);
            }

        }
    }
}