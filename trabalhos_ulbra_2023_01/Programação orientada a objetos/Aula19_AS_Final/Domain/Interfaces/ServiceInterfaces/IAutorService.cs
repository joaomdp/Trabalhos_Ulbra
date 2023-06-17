using System.Collections.Generic;
using System.Threading.Tasks;
using Aula19_AS_Final.Domain.Entities;

public interface IAutorService
{
    Task<List<Autor>> ObterTodosAutores();
    Task<Autor> ObterAutorPorId(int id);
    Task<int> AdicionarAutor(Autor autor);
    Task AtualizarAutor(Autor autor);
    Task RemoverAutor(int id);
}
