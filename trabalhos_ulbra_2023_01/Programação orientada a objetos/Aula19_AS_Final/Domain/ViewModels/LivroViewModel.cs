using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula19_AS_Final.Domain.ViewModels
{
    public class LivroViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public List<AutorViewModel> Autores { get; set; }
        public List<UsuarioViewModel> UsuariosEmprestados { get; set; }
    }

}