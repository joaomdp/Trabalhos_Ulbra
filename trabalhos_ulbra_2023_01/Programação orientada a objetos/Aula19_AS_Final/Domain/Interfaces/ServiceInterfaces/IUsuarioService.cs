using System.Collections.Generic;
using System.Threading.Tasks;
using Aula19_AS_Final.Domain.Entities;

public interface IUsuarioService
{
    Task<List<Usuario>> ObterTodosUsuarios();
    Task<Usuario> ObterUsuarioPorId(int id);
    Task<int> AdicionarUsuario(Usuario usuario);
    Task AtualizarUsuario(Usuario usuario);
    Task RemoverUsuario(int id);
}
