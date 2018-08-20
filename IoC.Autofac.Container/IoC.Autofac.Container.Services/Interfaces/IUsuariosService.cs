using IoC.Autofac.Container.Models;
using System.Collections.Generic;

namespace IoC.Autofac.Container.Services.Interfaces
{
    public interface IUsuariosService
    {
        IList<Usuario> GetAll();
        void AddNew(Usuario usuario);
        void Delete(int id);
        void Update(Usuario usuario);
    }
}
