using LivrariaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LivrariaAPI.Data.Dtos
{
    public class LivrariaContext : DbContext
    {
        public LivrariaContext(DbContextOptions<LivrariaContext> opt) : base(opt)
        {

        }
        public DbSet<Livro> Livros{ get; set; }
    }
}
