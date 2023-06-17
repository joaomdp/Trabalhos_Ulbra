using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula19_AS_Teste
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Emprestimo> Emprestimos { get; set; }
    }
}