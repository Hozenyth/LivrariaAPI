using AutoMapper;
using LivrariaAPI.Data.Dtos;
using LivrariaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LivrariaController : ControllerBase
    {
        private LivrariaContext _context;
        private IMapper _mapper;

        public LivrariaController(LivrariaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaLivro([FromBody] CreateLivroDto livroDto)
        {
            Livro livro = _mapper.Map<Livro>(livroDto);

            _context.Livros.Add(livro);
            _context.SaveChanges();

            return CreatedAtAction(nameof(RecuperaLivrosPorId), new { Id = livro.Id }, livro);
        }
        [HttpGet]
        public IEnumerable<Livro> GetProdutos()
        {
            return _context.Livros;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Livro>> RecuperaLivrosPorId(int id)
        {
            Livro livro = _context.Livros.FirstOrDefault(Produto => Produto.Id == id);

            if (livro != null)
            {
                ReadLivroDto livroDto = _mapper.Map<ReadLivroDto>(livro);

                return Ok(livroDto);
            }

            return NotFound();
        }

    }
}
