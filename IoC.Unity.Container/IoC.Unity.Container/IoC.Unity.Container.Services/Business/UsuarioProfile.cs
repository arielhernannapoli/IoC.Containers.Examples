using AutoMapper;

namespace IoC.Unity.Container.Services.Business
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
