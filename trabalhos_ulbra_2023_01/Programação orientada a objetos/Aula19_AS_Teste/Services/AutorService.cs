using System.Collections.Generic;
using Aula12_TestandoORM;

namespace Aula19_AS_Teste
{
    public class AutorService : IAutorService
    {
        private readonly IAutorRepository _autorRepository;

        public AutorService(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public List<Autor> GetAllAutores()
        {
            return _autorRepository.GetAll();
        }

        public Autor GetAutorById(int id)
        {
            return _autorRepository.GetById(id);
        }

        public void CreateAutor(Autor autor)
        {
            _autorRepository.Create(autor);
        }

        public void UpdateAutor(Autor autor)
        {
            _autorRepository.Update(autor);
        }

        public void DeleteAutor(int id)
        {
            _autorRepository.Delete(id);
        }
    }
}
