using Livraria.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Livraria.Controllers.Views
{
    public class LivrariaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Listar()
        {
            return View();
        }

        public IActionResult Alterar(int id)
        {
            ViewData["Id"] = id;
            return View();
        }
    }
}
