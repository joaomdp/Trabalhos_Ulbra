using System.Collections.Generic;
using System.Threading.Tasks;
using Aula19_AS_Final.Domain.Entities;
using Aula19_AS_Final.Domain.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Aula19_AS_Final.Data.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly DbContext _dbContext;

        public LivroRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Livro>> ObterTodos()
        {
            return await _dbContext.Set<Livro>().ToListAsync();
        }

        public async Task<Livro> ObterPorId(int id)
        {
            return await _dbContext.Set<Livro>().FindAsync(id);
        }

        public async Task<int> Inserir(Livro livro)
        {
            await _dbContext.Set<Livro>().AddAsync(livro);
            await _dbContext.SaveChangesAsync();

            return livro.Id;
        }

        public async Task Atualizar(Livro livro)
        {
            _dbContext.Entry(livro).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task Remover(int id)
        {
            var livro = await _dbContext.Set<Livro>().FindAsync(id);
            _dbContext.Set<Livro>().Remove(livro);
            await _dbContext.SaveChangesAsync();
        }
    }
}
