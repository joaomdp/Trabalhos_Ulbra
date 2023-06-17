using System.Collections.Generic;
using Aula19_AS_Teste;

namespace Aula19_AS_Teste
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<LivroAutor> Livros { get; set; }
    }
}
