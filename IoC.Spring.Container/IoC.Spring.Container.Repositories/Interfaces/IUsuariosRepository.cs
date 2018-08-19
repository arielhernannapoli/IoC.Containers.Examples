using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Spring.Container.Repositories.Interfaces
{
    public interface IUsuariosRepository
    {
        IList<Usuario> GetAll();
        void Create(Usuario usuario);
        void Delete(int id);
        void Update(Usuario usuario);
    }
}
