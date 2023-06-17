using System.Collections.Generic;
using System.Threading.Tasks;
using Aula19_AS_Final.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Aula19_AS_Final.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutorController : ControllerBase
    {
        private readonly IAutorService _autorService;

        public AutorController(IAutorService autorService)
        {
            _autorService = autorService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Autor>>> GetAutores()
        {
            var autores = await _autorService.ObterTodosAutores();
            return Ok(autores);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Autor>> GetAutor(int id)
        {
            var autor = await _autorService.ObterAutorPorId(id);
            if (autor == null)
                return NotFound();

            return Ok(autor);
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateAutor(Autor autor)
        {
            var autorId = await _autorService.AdicionarAutor(autor);
            return CreatedAtAction(nameof(GetAutor), new { id = autorId }, autorId);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAutor(int id, Autor autor)
        {
            if (id != autor.Id)
                return BadRequest();

            await _autorService.AtualizarAutor(autor);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAutor(int id)
        {
            await _autorService.RemoverAutor(id);
            return NoContent();
        }
    }
}
