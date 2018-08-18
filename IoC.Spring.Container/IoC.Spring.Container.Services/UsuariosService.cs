using IoC.Spring.Container.Models;
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

        public IList<Usuario> GetAll()
        {
            return new List<Usuario>()
            {
                new Usuario() { Nombre = "Ariel", Apellido = "Napoli", Documento = "28445071" }
            };
        }
    }
}
