using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Spring.Container.Services.Business
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
