﻿using Microsoft.AspNetCore.Mvc;

namespace WebAppTarde.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
