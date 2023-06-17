using System.Collections.Generic;
using System.Threading.Tasks;
using Aula19_AS_Final.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Aula19_AS_Final.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivroController : ControllerBase
    {
        private readonly ILivroService _livroService;

        public LivroController(ILivroService livroService)
        {
            _livroService = livroService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Livro>>> GetLivros()
        {
            var livros = await _livroService.ObterTodosLivros();
            return Ok(livros);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Livro>> GetLivro(int id)
        {
            var livro = await _livroService.ObterLivroPorId(id);
            if (livro == null)
                return NotFound();

            return Ok(livro);
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateLivro(Livro livro)
        {
            var livroId = await _livroService.AdicionarLivro(livro);
            return CreatedAtAction(nameof(GetLivro), new { id = livroId }, livroId);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLivro(int id, Livro livro)
        {
            if (id != livro.Id)
                return BadRequest();

            await _livroService.AtualizarLivro(livro);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLivro(int id)
        {
            await _livroService.RemoverLivro(id);
            return NoContent();
        }
    }
}
