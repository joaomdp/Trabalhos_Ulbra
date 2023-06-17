using System.Collections.Generic;

namespace Aula19_AS_Teste
{
    public interface ILivroService
    {
        List<Livro> GetAllLivros();
        Livro GetLivroById(int id);
        void CreateLivro(Livro livro);
        void UpdateLivro(Livro livro);
        void DeleteLivro(int id);
    }
}
