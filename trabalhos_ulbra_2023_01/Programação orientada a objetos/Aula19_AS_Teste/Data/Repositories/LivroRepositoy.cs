using System.Collections.Generic;
using System.Linq;
using Aula19_AS_Teste;
using Microsoft.EntityFrameworkCore;

namespace Aula19_AS_Teste
{
    public class LivroRepository : ILivroRepository
    {
        private readonly MeuContexto _context;

        public LivroRepository(MeuContexto context)
        {
            _context = context;
        }

        public List<Livro> GetAll()
        {
            return _context.Livros.Include(l => l.Autores).ToList();
        }

        public Livro GetById(int id)
        {
            return _context.Livros.Include(l => l.Autores).FirstOrDefault(l => l.Id == id);
        }

        public void Create(Livro livro)
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
        }

        public void Update(Livro livro)
        {
            _context.Livros.Update(livro);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var livro = _context.Livros.Find(id);
            if (livro != null)
            {
                _context.Livros.Remove(livro);
                _context.SaveChanges();
            }
        }
    }
}
