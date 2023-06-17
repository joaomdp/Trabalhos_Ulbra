using System.Collections.Generic;
using System.Threading.Tasks;
using Aula19_AS_Final.Domain.Entities;
using Aula19_AS_Final.Domain.Entities.Interfaces;

public class LivroService : ILivroService
{
    private readonly ILivroRepository _livroRepository;

    public LivroService(ILivroRepository livroRepository)
    {
        _livroRepository = livroRepository;
    }

    public async Task<List<Livro>> ObterTodosLivros()
    {
        return await _livroRepository.ObterTodos();
    }

    public async Task<Livro> ObterLivroPorId(int id)
    {
        return await _livroRepository.ObterPorId(id);
    }

    public async Task<int> AdicionarLivro(Livro livro)
    {
        return await _livroRepository.Inserir(livro);
    }

    public async Task AtualizarLivro(Livro livro)
    {
        await _livroRepository.Atualizar(livro);
    }

    public async Task RemoverLivro(int id)
    {
        await _livroRepository.Remover(id);
    }
}
