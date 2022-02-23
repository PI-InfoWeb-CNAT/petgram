using Aplicação.DAL;
using Aplicação.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplicação.Controllers
{
    public class CadastroController : Controller
    {
        UsuarioDAL usuarioDAL = new UsuarioDAL();

        // GET: Cadastro
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cadastro
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuario usuario, HttpPostedFileBase imagem = null)
        {
            int idade = DateTime.Now.Subtract(usuario.Data_Nascimento).Days;
            idade = idade / 365;

            if (idade >= 14)
            {
                if (imagem != null)
                {
                    usuario.ImagemMimeType = imagem.ContentType;
                    usuario.Imagem = SetImagemUser(imagem);
                    usuario.NomeArquivo = imagem.FileName;
                    usuario.TamanhoArquivo = imagem.ContentLength;
                }
                usuarioDAL.GravarUsuario(usuario);
                return RedirectToAction("../Pet/Create", new { UserID = usuario.ID, new_pet = false });
            }
            else
            {
                ViewBag.VerificaIdade = "Sua idade deve ser maior ou igual a 14 anos";
                return View(usuario);
            }
        }

        private byte[] SetImagemUser(HttpPostedFileBase imagem)
        {
            var bytesImagem = new byte[imagem.ContentLength];
            imagem.InputStream.Read(bytesImagem, 0, imagem.ContentLength);
            return bytesImagem;
        }

        public FileContentResult GetImagemUser(long id)
        {
            Usuario usuario = usuarioDAL.ObterUsuarioPorId(id);
            if (usuario != null && usuario.Imagem != null)
            {
                return File(usuario.Imagem, usuario.ImagemMimeType);
            }
            return null;
        }
    }
}