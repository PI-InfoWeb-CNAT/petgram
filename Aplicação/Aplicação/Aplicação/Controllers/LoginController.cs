﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aplicação.Models;
using Aplicação.DAL;

namespace Aplicação.Controllers
{
    public class LoginController : Controller
    {
        UsuarioDAL usuarioDAL = new UsuarioDAL();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UsuarioCadastro usuario)
        {
            try
            {
                UsuarioCadastro userWithThatEmail = usuarioDAL.GetUserByEmail(usuario.Email);
                if (usuario.Senha == userWithThatEmail.Senha)
                {
                    return RedirectToAction("../LOGADO");
                }
                return RedirectToAction("../SENHA_ERRADA");
            }
            catch
            {
                return RedirectToAction("../EMAIL_ERRADO/");
            }
        }

    }
}