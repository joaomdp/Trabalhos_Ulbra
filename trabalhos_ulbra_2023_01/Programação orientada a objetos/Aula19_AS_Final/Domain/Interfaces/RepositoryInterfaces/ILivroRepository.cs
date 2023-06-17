using System.Collections.Generic;
using System.Threading.Tasks;
using Aula19_AS_Final.Domain.Entities;

namespace Aula19_AS_Final.Domain.Entities.Interfaces
{
    public interface ILivroRepository
    {
        Task<List<Livro>> ObterTodos();
        Task<Livro> ObterPorId(int id);
        Task<int> Inserir(Livro livro);
        Task Atualizar(Livro livro);
        Task Remover(int id);
    }
}
