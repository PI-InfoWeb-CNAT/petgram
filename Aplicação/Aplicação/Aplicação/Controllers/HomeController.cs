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
        MensagemDAL mensagemDAL = new MensagemDAL();
        UsuarioDAL userDAL = new UsuarioDAL();
        private ActionResult GravarPost(Postagem post, HttpPostedFileBase imagem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (imagem != null)
                    {
                        post.ImagemMimeType = imagem.ContentType;
                        post.Imagem = SetImagem(imagem);
                        post.NomeArquivo = imagem.FileName;
                        post.TamanhoArquivo = imagem.ContentLength;
                    }

                    postDAL.GravarPost(post);
                    return RedirectToAction("Feed", new { UserID = post.UserID });
                }

                return View(post);
            }
            catch
            {
                return View(post);
            }
        }

        private byte[] SetImagem(HttpPostedFileBase imagem)
        {
            var bytesImagem = new byte[imagem.ContentLength];
            imagem.InputStream.Read(bytesImagem, 0, imagem.ContentLength);
            return bytesImagem;
        }

        public FileContentResult GetImagem(long id)
        {
            Postagem post = postDAL.ObterPostagemPorId(id);
            if (post != null && post.Imagem != null)
            {
                return File(post.Imagem, post.ImagemMimeType);
            }
            return null;
        }

        public ActionResult Perfil(int UserID)
        {

            return View(userDAL.GetUserByID(UserID));
        }

        [HttpPost]
        public ActionResult EditarPerfil(Usuario user)
        {
            userDAL.GravarUsuario(user);
            return RedirectToAction("Perfil", new { UserID = user.ID });
        }

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


        // GET: Publicar
        public ActionResult Publicar(int UserID)
        {
            ViewBag.UserID = UserID;
            ViewBag.Data = DateTime.Now.ToString();
            return View();
        }

        // POST: Publicar
        [HttpPost]
        public ActionResult Publicar(Postagem post, HttpPostedFileBase imagem = null)
        {
            return GravarPost(post, imagem);
        }

        // POST: Comentar
        [HttpPost]
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