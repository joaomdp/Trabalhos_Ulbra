using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Aula19_AS_Teste
{
    public class LivroAutor
    {
        public int LivroId { get; set; }
        public Livro Livro { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
    }
}