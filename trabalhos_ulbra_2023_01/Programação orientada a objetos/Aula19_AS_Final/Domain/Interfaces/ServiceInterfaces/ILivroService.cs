using System.Collections.Generic;
using System.Threading.Tasks;
using Aula19_AS_Final.Domain.Entities;

public interface ILivroService
{
    Task<List<Livro>> ObterTodosLivros();
    Task<Livro> ObterLivroPorId(int id);
    Task<int> AdicionarLivro(Livro livro);
    Task AtualizarLivro(Livro livro);
    Task RemoverLivro(int id);
}
