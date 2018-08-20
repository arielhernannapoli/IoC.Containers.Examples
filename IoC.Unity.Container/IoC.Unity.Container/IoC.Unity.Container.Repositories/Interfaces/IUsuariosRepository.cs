using System.Collections.Generic;

namespace IoC.Unity.Container.Repositories.Interfaces
{
    public interface IUsuariosRepository
    {
        IList<Usuario> GetAll();
        void Create(Usuario usuario);
        void Delete(int id);
        void Update(Usuario usuario);
    }
}
