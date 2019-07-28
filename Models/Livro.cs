using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Models
{
    public class Livro
    {
        public Livro()
        { }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo ?? throw new ArgumentNullException(nameof(titulo));
            Autor = autor ?? throw new ArgumentNullException(nameof(autor));
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
    }
}
