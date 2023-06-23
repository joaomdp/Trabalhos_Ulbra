using System.Collections.Generic;

namespace Aula19_AS_Teste.Domain.ViewModels
{
    public class LivroViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool Emprestado { get; set; }
        public List<int> AutoresIds { get; set; }
    }
}
