using System.Collections.Generic;
using System.Threading.Tasks;
using Aula19_AS_Final.Domain.Entities;
using Aula19_AS_Final.Domain.Entities.Interfaces;

public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _usuarioRepository;

    public UsuarioService(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    public async Task<List<Usuario>> ObterTodosUsuarios()
    {
        return await _usuarioRepository.ObterTodos();
    }

    public async Task<Usuario> ObterUsuarioPorId(int id)
    {
        return await _usuarioRepository.ObterPorId(id);
    }

    public async Task<int> AdicionarUsuario(Usuario usuario)
    {
        return await _usuarioRepository.Inserir(usuario);
    }

    public async Task AtualizarUsuario(Usuario usuario)
    {
        await _usuarioRepository.Atualizar(usuario);
    }

    public async Task RemoverUsuario(int id)
    {
        await _usuarioRepository.Remover(id);
    }
}
