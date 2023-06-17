using System.Collections.Generic;

namespace Aula19_AS_Teste
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public List<Usuario> GetAllUsuarios()
        {
            return _usuarioRepository.GetAll();
        }

        public Usuario GetUsuarioById(int id)
        {
            return _usuarioRepository.GetById(id);
        }

        public void CreateUsuario(Usuario usuario)
        {
            _usuarioRepository.Create(usuario);
        }

        public void UpdateUsuario(Usuario usuario)
        {
            _usuarioRepository.Update(usuario);
        }

        public void DeleteUsuario(int id)
        {
            _usuarioRepository.Delete(id);
        }
    }
}
