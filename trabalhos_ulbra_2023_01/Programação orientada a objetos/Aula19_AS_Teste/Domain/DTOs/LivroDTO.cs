using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula19_AS_Teste.Domain.DTOs
{
    public class LivroDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool Emprestado { get; set; } 
        public List<int> AutoresIds { get; set; }
    }
}