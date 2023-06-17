using System.Collections.Generic;
using System.Threading.Tasks;
using Aula19_AS_Final.Domain.Entities;
using Aula19_AS_Final.Domain.Entities.Interfaces;

namespace Name
{
    
}
public class AutorService : IAutorService
{
    private readonly IAutorRepository _autorRepository;

    public AutorService(IAutorRepository autorRepository)
    {
        _autorRepository = autorRepository;
    }

    public async Task<List<Autor>> ObterTodosAutores()
    {
        return await _autorRepository.ObterTodos();
    }

    public async Task<Autor> ObterAutorPorId(int id)
    {
        return await _autorRepository.ObterPorId(id);
    }

    public async Task<int> AdicionarAutor(Autor autor)
    {
        return await _autorRepository.Inserir(autor);
    }

    public async Task AtualizarAutor(Autor autor)
    {
        await _autorRepository.Atualizar(autor);
    }

    public async Task RemoverAutor(int id)
    {
        await _autorRepository.Remover(id);
    }
}
