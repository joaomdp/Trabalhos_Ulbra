using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace Aula19_AS_Teste
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IMapper _mapper;

        public UsuariosController(IUsuarioService usuarioService, IMapper mapper)
        {
            _usuarioService = usuarioService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllUsuarios()
        {
            var usuarios = _usuarioService.GetAllUsuarios();
            var usuarioDTOs = _mapper.Map<List<UsuarioDTO>>(usuarios);
            return Ok(usuarioDTOs);
        }

        [HttpGet("{id}")]
        public IActionResult GetUsuarioById(int id)
        {
            var usuario = _usuarioService.GetUsuarioById(id);
            if (usuario == null)
            {
                return NotFound();
            }
            var usuarioDTO = _mapper.Map<UsuarioDTO>(usuario);
            return Ok(usuarioDTO);
        }

        [HttpPost]
        public IActionResult CreateUsuario([FromBody] UsuarioDTO usuarioDTO)
        {
            var usuario = _mapper.Map<Usuario>(usuarioDTO);
            _usuarioService.CreateUsuario(usuario);
            return Ok(new
            {
                StatusCode = 200,
                Message = "Usuário cadastrado com sucesso",
                usuario
            });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUsuario(int id, [FromBody] UsuarioDTO usuarioDTO)
        {
            var usuario = _mapper.Map<Usuario>(usuarioDTO);
            usuario.Id = id;
            _usuarioService.UpdateUsuario(usuario);
            return Ok(new
            {
                StatusCode = 200,
                Message = "Usuário atualizado com sucesso",
                usuario
            });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUsuario(int id)
        {
            _usuarioService.DeleteUsuario(id);
            return Ok(new
            {
                StatusCode = 200,
                Message = "Usuário deletado com sucesso"
            });
        }
    }
}
