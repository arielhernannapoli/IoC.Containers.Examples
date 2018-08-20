using IoC.Spring.Container.Models;
using IoC.Spring.Container.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Spring.Container.Tests.Mocks
{
    public class MockUsuariosService : IUsuariosService
    {
        public void AddNew(Usuario usuario)
        {
            
        }

        public void Delete(int id)
        {
            
        }

        public IList<Usuario> GetAll()
        {
            return new List<Usuario>()
            {
                new Usuario() { Id = 1, Nombre = "Ariel", Apellido = "Napoli", Documento = "28445071" }
            };
        }

        public void Update(Usuario usuario)
        {
            
        }
    }
}
