using System.Collections.Generic;
using System.Threading.Tasks;
using Aula19_AS_Final.Domain.Entities;

namespace Aula19_AS_Final.Domain.Entities.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> ObterTodos();
        Task<Usuario> ObterPorId(int id);
        Task<int> Inserir(Usuario usuario);
        Task Atualizar(Usuario usuario);
        Task Remover(int id);
    }
}
