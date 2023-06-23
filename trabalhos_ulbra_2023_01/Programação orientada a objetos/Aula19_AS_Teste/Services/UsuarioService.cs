using System.Collections.Generic;
using Aula19_AS_Teste.Domain.DTOs;
using AutoMapper;

namespace Aula19_AS_Teste
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ILivroRepository _livroRepository;
        private readonly IMapper _mapper;

        public UsuarioService(IUsuarioRepository usuarioRepository, ILivroRepository livroRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _livroRepository = livroRepository;
            _mapper = mapper;
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

        public void EmprestarLivro(Usuario usuario, Livro livro)
        {
            if (livro.Emprestado)
            {
                throw new Exception("Livro já emprestado");
            }

            var emprestimo = new Emprestimo
            {
                Usuario = usuario,
                Livro = livro
            };

            livro.Emprestado = true;

            usuario.Emprestimos.Add(emprestimo);

            _usuarioRepository.Update(usuario);
            _livroRepository.Update(livro);
        }

        public void DevolverLivro(Usuario usuario, Livro livro)
        {
            var emprestimo = usuario.Emprestimos.FirstOrDefault(e => e.Livro == livro);
            if (emprestimo == null)
            {
                throw new Exception("Livro não emprestado pelo usuário");
            }

            usuario.Emprestimos.Remove(emprestimo);

            livro.Emprestado = false;

            _usuarioRepository.Update(usuario);
            _livroRepository.Update(livro);
        }

        public List<LivroDTO> ObterLivrosEmprestados(int usuarioId)
        {
            var emprestimos = GetUsuarioById(usuarioId)?.Emprestimos;
            if (emprestimos != null)
            {
                var livrosEmprestados = emprestimos.Select(e => _mapper.Map<LivroDTO>(e.Livro)).ToList();
                return livrosEmprestados;
            }
            return new List<LivroDTO>();
        }

    }
}
