using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Aula19_AS_Teste.Domain.DTOs;

namespace Aula19_AS_Teste
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivrosController : ControllerBase
    {
        private readonly ILivroService _livroService;
        private readonly IMapper _mapper;

        public LivrosController(ILivroService livroService, IMapper mapper)
        {
            _livroService = livroService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllLivros()
        {
            var livros = _livroService.GetAllLivros();
            var livroDTOs = _mapper.Map<List<LivroDTO>>(livros);
            return Ok(livroDTOs);
        }

        [HttpGet("{id}")]
        public IActionResult GetLivroById(int id)
        {
            var livro = _livroService.GetLivroById(id);
            if (livro == null)
            {
                return NotFound();
            }
            var livroDTO = _mapper.Map<LivroDTO>(livro);
            return Ok(livroDTO);
        }

        [HttpPost]
        public IActionResult CreateLivro([FromBody] LivroDTO livroDTO)
        {
            var livro = _mapper.Map<Livro>(livroDTO);
            _livroService.CreateLivro(livro);
            return Ok(new
            {
                StatusCode = 200,
                Message = "Livro cadastrado com sucesso",
                livro
            });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateLivro(int id, [FromBody] LivroDTO livroDTO)
        {
            var livro = _mapper.Map<Livro>(livroDTO);
            livro.Id = id;
            _livroService.UpdateLivro(livro);
            return Ok(new
            {
                StatusCode = 200,
                Message = "Livro atualizado com sucesso",
                livro
            });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteLivro(int id)
        {
            _livroService.DeleteLivro(id);
            return Ok(new
            {
                StatusCode = 200,
                Message = "Livro deletado com sucesso"
            });
        }
    }
}
