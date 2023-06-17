using AutoMapper;
using Aula19_AS_Final.Domain.Entities;
using Aula19_AS_Final.Domain.ViewModels;

namespace Aula19_AS_Final.API.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Autor, AutorViewModel>().ReverseMap();
            CreateMap<Livro, LivroViewModel>().ReverseMap();
            CreateMap<Usuario, UsuarioViewModel>().ReverseMap();
        }
    }
}
