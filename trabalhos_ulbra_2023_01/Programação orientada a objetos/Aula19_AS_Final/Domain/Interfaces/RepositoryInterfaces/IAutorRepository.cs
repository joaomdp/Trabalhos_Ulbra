using System.Collections.Generic;
using System.Threading.Tasks;
using Aula19_AS_Final.Domain.Entities;

namespace Aula19_AS_Final.Domain.Entities.Interfaces
{
    public interface IAutorRepository
    {
        Task<List<Autor>> ObterTodos();
        Task<Autor> ObterPorId(int id);
        Task<int> Inserir(Autor autor);
        Task Atualizar(Autor autor);
        Task Remover(int id);
    }
}
