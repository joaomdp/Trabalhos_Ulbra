using System.Collections.Generic;
using Aula12_TestandoORM;

namespace Aula19_AS_Teste
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public List<Livro> GetAllLivros()
        {
            return _livroRepository.GetAll();
        }

        public Livro GetLivroById(int id)
        {
            return _livroRepository.GetById(id);
        }

        public void CreateLivro(Livro livro)
        {
            _livroRepository.Create(livro);
        }

        public void UpdateLivro(Livro livro)
        {
            _livroRepository.Update(livro);
        }

        public void DeleteLivro(int id)
        {
            _livroRepository.Delete(id);
        }
    }
}
