using System.Collections.Generic;
using Aula19_AS_Teste.Domain.DTOs;
using Aula19_AS_Teste.Domain.ViewModels;
using AutoMapper;

namespace Aula19_AS_Teste
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Livro, LivroDTO>()
                .ForMember(dest => dest.AutoresIds, opt => opt.MapFrom(src => src.Autores.Select(la => la.AutorId).ToList()));
            CreateMap<LivroDTO, Livro>()
                .ForMember(dest => dest.Autores, opt => opt.Ignore());

            CreateMap<Autor, AutorDTO>()
                .ForMember(dest => dest.LivrosIds, opt => opt.MapFrom(src => GetLivrosIds(src)));
            CreateMap<AutorDTO, Autor>()
                .ForMember(dest => dest.Livros, opt => opt.MapFrom(src => GetLivros(src)));

            CreateMap<UsuarioDTO, Usuario>();
            CreateMap<Usuario, UsuarioDTO>();
            CreateMap<Usuario, UsuarioViewModel>();
            CreateMap<EmprestimoDTO, Usuario>()
                .ForMember(dest => dest.Emprestimos, opt => opt.Ignore());

            CreateMap<LivroDTO, LivroViewModel>();
            CreateMap<LivroViewModel, LivroDTO>();
            CreateMap<AutorDTO, AutorViewModel>()
                .ForMember(dest => dest.LivrosIds, opt => opt.MapFrom(src => GetLivros(src)));
            CreateMap<AutorViewModel, AutorDTO>();

        }

        private List<int> GetLivrosIds(Autor autor)
        {
            var livrosIds = new List<int>();
            foreach (var livroAutor in autor.Livros)
            {
                livrosIds.Add(livroAutor.LivroId);
            }
            return livrosIds;
        }

        private List<LivroAutor> GetLivros(AutorDTO autorDTO)
        {
            var livros = new List<LivroAutor>();
            foreach (var livroId in autorDTO.LivrosIds)
            {
                var livroAutor = new LivroAutor { LivroId = livroId };
                livros.Add(livroAutor);
            }
            return livros;
        }
    }
}
