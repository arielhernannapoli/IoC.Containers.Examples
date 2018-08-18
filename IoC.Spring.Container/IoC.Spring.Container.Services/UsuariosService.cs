using IoC.Spring.Container.Repositories.Interfaces;
using IoC.Spring.Container.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Spring.Container.Services
{
    public class UsuariosService : IUsuariosService
    {
        public UsuariosService(IUsuariosRepository usuariosRepository)
        {

        }
    }
}
