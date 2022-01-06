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
        UsuarioDAL usuarioDAL = new UsuarioDAL();

        //GET
        public ActionResult Comentar(int UserID, int PostID)
        {
            ViewBag.Comments = mensagemDAL.GetCommentsByPostID(PostID);
            return View();
        }

        // POST: Comentar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Comentar(Mensagem comentario)
        {
            try
            {
                comentario.Data = DateTime.Today;
                if (ModelState.IsValid)
                {
                    mensagemDAL.GravarComentario(comentario);
                }

                ViewBag.Comments = mensagemDAL.GetCommentsByPostID(comentario.PostID);
                //return View(comentario);
                return RedirectToAction("../Mensagem/Comentar", new { UserID = comentario.UserID, PostID = comentario.PostID });
            }
            catch
            {
                ViewBag.Comments = mensagemDAL.GetCommentsByPostID(comentario.PostID);
                return View(comentario);
            }

        }

        public string GetUserName(long UserID)
        {
            Usuario usuario = usuarioDAL.ObterUsuarioPorId(UserID);
            return usuario.Nome;
        }
    }
}