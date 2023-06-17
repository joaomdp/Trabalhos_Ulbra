using System.Collections.Generic;

namespace Aula19_AS_Teste
{
    public interface IAutorService
    {
        List<Autor> GetAllAutores();
        Autor GetAutorById(int id);
        void CreateAutor(Autor autor);
        void UpdateAutor(Autor autor);
        void DeleteAutor(int id);
    }
}
