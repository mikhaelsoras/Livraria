using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Livraria.Models;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.Controllers.Api
{
    public class ApiController : Controller
    {
        private readonly LivrariaContext _livrariaContext;

        public ApiController(LivrariaContext livrariaContext)
        {
            _livrariaContext = livrariaContext;
        }

        [HttpPatch]
        public ActionResult<Livro> Alterar(int id, string titulo, string autor)
        {
            var livro = _livrariaContext.Livros.Where(x => x.Id == id).FirstOrDefault();
            if (livro is null)
                return NotFound("Livro não encontrado.");

            livro.Autor = autor;
            livro.Titulo = titulo;

            _livrariaContext.SaveChanges();

            return Json(livro);
        }

        [HttpGet]
        public ActionResult<List<Livro>> CarregarTodos()
        {
            var livros = from livro in _livrariaContext.Livros
                         select livro;
            return Json(livros.ToList());
        }

        [HttpGet]
        public ActionResult<Livro> Carregar(int id)
        {
            var livro = (from clivro in _livrariaContext.Livros
                         where clivro.Id == id
                         select clivro).FirstOrDefault();

            if (livro is null)
                return NotFound("Livro não encontrado.");

            return Json(livro);
        }

        [HttpPost]
        public ActionResult Cadastrar(string titulo, string autor)
        {
            var livro = new Livro(titulo, autor);
            _livrariaContext.Livros.Add(livro);
            _livrariaContext.SaveChanges();

            return Json(livro);
        }

        [HttpDelete]
        public ActionResult Remover(int id)
        {
            var livro = _livrariaContext.Livros.Where(x => x.Id == id).FirstOrDefault();
            if (livro is null)
                return NotFound(new { message = $"Livro {id} não encontrado." });

            _livrariaContext.Livros.Remove(livro);
            _livrariaContext.SaveChanges();

            return Ok(new { message = "Removido com sucesso." });
        }
    }
}