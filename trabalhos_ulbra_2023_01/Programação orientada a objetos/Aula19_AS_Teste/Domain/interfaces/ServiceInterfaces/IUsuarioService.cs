using System.Collections.Generic;
using Aula19_AS_Teste.Domain.DTOs;

namespace Aula19_AS_Teste
{
    public interface IUsuarioService
    {
        List<Usuario> GetAllUsuarios();
        Usuario GetUsuarioById(int id);
        void CreateUsuario(Usuario usuario);
        void UpdateUsuario(Usuario usuario);
        void DeleteUsuario(int id);
        void EmprestarLivro(Usuario usuario, Livro livro); 
        void DevolverLivro(Usuario usuario, Livro livro); 
        public List<LivroDTO> ObterLivrosEmprestados(int usuarioId);
    }
}
