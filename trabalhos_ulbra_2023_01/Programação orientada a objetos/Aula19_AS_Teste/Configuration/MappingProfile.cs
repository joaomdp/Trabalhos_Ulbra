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
                .ForMember(dest => dest.AutoresIds, opt => opt.MapFrom(src => GetAutoresIds(src)));
            CreateMap<LivroDTO, Livro>()
                .ForMember(dest => dest.Autores, opt => opt.Ignore());

            CreateMap<Autor, AutorDTO>()
                .ForMember(dest => dest.LivrosIds, opt => opt.MapFrom(src => GetLivrosIds(src)));
            CreateMap<AutorDTO, Autor>()
                .ForMember(dest => dest.Livros, opt => opt.Ignore());

            CreateMap<Usuario, UsuarioViewModel>();
            CreateMap<EmprestimoDTO, Usuario>()
                .ForMember(dest => dest.Emprestimos, opt => opt.Ignore());
        }

        private List<int> GetAutoresIds(Livro livro)
        {
            var autoresIds = new List<int>();
            foreach (var autor in livro.Autores)
            {
                autoresIds.Add(autor.AutorId);
            }
            return autoresIds;
        }

        private List<int> GetLivrosIds(Autor autor)
        {
            var livrosIds = new List<int>();
            foreach (var livro in autor.Livros)
            {
                livrosIds.Add(livro.LivroId);
            }
            return livrosIds;
        }
    }
}
