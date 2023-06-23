using System.Collections.Generic;
using Aula12_TestandoORM;

namespace Aula19_AS_Teste
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepository;
        private readonly IAutorRepository _autorRepository;

        public LivroService(ILivroRepository livroRepository, IAutorRepository autorRepository)
        {
            _livroRepository = livroRepository;
            _autorRepository = autorRepository;
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

        public void AdicionarAutor(Livro livro, Autor autor)
        {
            var livroAutor = new LivroAutor
            {
                LivroId = livro.Id,
                AutorId = autor.Id
            };

            livro.Autores.Add(livroAutor);
            _livroRepository.Update(livro);

            autor.Livros.Add(livroAutor);
            _autorRepository.Update(autor);
        }
    }
}