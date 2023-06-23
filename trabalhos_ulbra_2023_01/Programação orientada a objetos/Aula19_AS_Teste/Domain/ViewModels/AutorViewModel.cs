using System.Collections.Generic;

namespace Aula19_AS_Teste.Domain.ViewModels
{
    public class AutorViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<int> LivrosIds { get; set; }
    }
}
