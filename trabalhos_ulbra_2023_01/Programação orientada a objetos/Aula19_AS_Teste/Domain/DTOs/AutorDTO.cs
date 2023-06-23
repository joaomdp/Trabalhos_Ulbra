using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula19_AS_Teste.Domain.DTOs
{
    public class AutorDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<int> LivrosIds { get; set; }
    }
}
