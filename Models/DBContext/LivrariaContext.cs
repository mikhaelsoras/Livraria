using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Livraria.Models
{
    public partial class LivrariaContext : DbContext
    {
        public LivrariaContext(DbContextOptions<LivrariaContext> options)
            : base(options)
        {
        }

        public DbSet<Livro> Livros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
