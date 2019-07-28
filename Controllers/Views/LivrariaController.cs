using Livraria.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Livraria.Controllers.Views
{
    public class LivrariaController : Controller
    {
        private readonly LivrariaContext _livrariaContext;

        public LivrariaController(LivrariaContext livrariaContext)
        {
            _livrariaContext = livrariaContext;
        }

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

        public ActionResult<List<Livro>> Teste()
        {
            var livros = from livro in _livrariaContext.Livros
                         select livro;
            return livros.ToList();
        }
    }
}
