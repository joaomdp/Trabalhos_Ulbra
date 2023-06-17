using System.Collections.Generic;
using Aula19_AS_Teste.Domain.DTOs;

namespace Aula19_AS_Teste
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<LivroDTO> LivrosEmprestados { get; set; }
    }
}
