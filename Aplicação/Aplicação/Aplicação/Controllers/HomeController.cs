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
            Usuario usuario = userDAL.GetUserByID(userID);
            ViewBag.UserID = userID;
            return View(usuario);
        }

        //POST: Editar Perfil
        [HttpPost]
        public ActionResult EditarPerfil(Usuario usuario, HttpPostedFileBase imagem, string chkRemoverImagem)
        {
            if (ModelState.IsValid)
            {
                if (chkRemoverImagem != null)
                {
                    usuario.Imagem = null;
                }
                if (imagem != null)
                {
                    usuario.ImagemMimeType = imagem.ContentType;
                    usuario.Imagem = SetImagemUser(imagem);
                    usuario.NomeArquivo = imagem.FileName;
                    usuario.TamanhoArquivo = imagem.ContentLength;
                }
                userDAL.GravarUsuario(usuario);
                return RedirectToAction("Perfil", new { UserID = usuario.ID });
            }

            return View(usuario);

            
        }

        //POST: Deletar Usuario
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletarUsuario(long id)
        {
            
                Usuario user = userDAL.EliminarUsuarioPorId(id);
                TempData["Message"] = "Usuário " + user.Nome.ToUpper() + " foi removido";
                return RedirectToAction("../Cadastro/Create");
            /*try
            { 
            }
            catch
            {
                return RedirectToAction("Perfil", new { UserID = id });
            }*/
        }


        // GET: Feed
        public ActionResult Feed(int UserID)
        {
            ViewBag.UserID = UserID;
            return View(postDAL.ObterPostagensClassificadasPorData());
        }

        private byte[] SetImagemUser(HttpPostedFileBase imagem)
        {
            var bytesImagem = new byte[imagem.ContentLength];
            imagem.InputStream.Read(bytesImagem, 0, imagem.ContentLength);
            return bytesImagem;
        }
    }
}