using LivrariaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Livraria.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LivrariaController : ControllerBase
    {
        private readonly ToDoContext _context;

        public LivrariaController(ToDoContext context)
        {
            _context = context;

            _context.todoProducts.Add(new Produto { ProdutoId = "1", Nome = "Book1", Preco = 124.0, Categoria = "Ação", Img = "img1" });
            _context.todoProducts.Add(new Produto { ProdutoId = "2", Nome = "Book2", Preco = 524.0, Categoria = "Aventura", Img = "img2" });
            _context.todoProducts.Add(new Produto { ProdutoId = "3", Nome = "Book3", Preco = 224.0, Categoria = "Ficção", Img = "img3" });
            _context.todoProducts.Add(new Produto { ProdutoId = "4", Nome = "Book4", Preco = 324.0, Categoria = "Romance", Img = "img4" });
            _context.todoProducts.Add(new Produto { ProdutoId = "5", Nome = "Book5", Preco = 24.5, Categoria = "Ação", Img = "img5" });

            _context.SaveChanges();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        {
            return await _context.todoProducts.ToListAsync();
        }
    }
}
