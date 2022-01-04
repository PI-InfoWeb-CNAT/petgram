using Aplicação.DAL;
using Aplicação.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplicação.Controllers
{
    public class PostagemController : Controller
    {
        PostagemDAL postDAL = new PostagemDAL();

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



        // GET: Publicar
        public ActionResult Publicar(int UserID)
        {
            ViewBag.UserID = UserID;
            ViewBag.Data = DateTime.Now.ToString();
            return View();
        }

        // POST: Publicar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Publicar(Postagem post, HttpPostedFileBase imagem = null)
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
                    return RedirectToAction("../Home/Feed", new { UserID = post.UserID });
                }

                return View(post);
            }
            catch
            {
                return View(post);
            }
        }

        // POST: Deletar Postagem
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletarPostagem(long postID, long userID)
        {
            try
            {
                Postagem post = postDAL.EliminarPostagemPorId(postID);
                TempData["Message"] = "Postagem excluída com sucesso!";
                return RedirectToAction("../Home/Perfil", new { UserID = userID });
            }
            catch
            {
                return RedirectToAction("../Home/Perfil", new { UserID = userID });
            }
        }

        // GET: Like
        public void Like(long postID)
        {
            postDAL.RegistrarLike(postID);
        }
    }
}