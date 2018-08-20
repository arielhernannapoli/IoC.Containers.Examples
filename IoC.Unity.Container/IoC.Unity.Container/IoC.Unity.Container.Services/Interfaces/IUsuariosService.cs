using IoC.Unity.Container.Models;
using System.Collections.Generic;

namespace IoC.Unity.Container.Services.Interfaces
{
    public interface IUsuariosService
    {
        IList<Usuario> GetAll();
        void AddNew(Usuario usuario);
        void Delete(int id);
        void Update(Usuario usuario);
    }
}
