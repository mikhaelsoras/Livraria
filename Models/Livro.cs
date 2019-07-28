using System;

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

        public virtual int Id { get; set; }
        public virtual string Titulo { get; set; }
        public virtual string Autor { get; set; }
    }
}
