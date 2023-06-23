using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Aula19_AS_Teste
{
    public class AutorRepository : IAutorRepository
    {
        private readonly MeuContexto _context;

        public AutorRepository(MeuContexto context)
        {
            _context = context;
        }

        public List<Autor> GetAll()
        {
            return _context.Autores.Include(a => a.Livros).ToList();
        }

        public Autor GetById(int id)
        {
            return _context.Autores.Include(a => a.Livros).FirstOrDefault(a => a.Id == id);
        }

        public void Create(Autor autor)
        {
            _context.Autores.Add(autor);
            _context.SaveChanges();
        }

        public void Update(Autor autor)
        {
            _context.Autores.Update(autor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var autor = _context.Autores.Find(id);
            if (autor != null)
            {
                _context.Autores.Remove(autor);
                _context.SaveChanges();
            }
        }
    }
}
