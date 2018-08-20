using AutoMapper;

namespace IoC.Autofac.Container.Services.Business
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<Models.Usuario, Repositories.Usuario>();
            CreateMap<Repositories.Usuario, Models.Usuario>();
        }
    }
}
