using IoC.Spring.Container.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Spring.Container.Services.Interfaces
{
    public interface IUsuariosService
    {
        IList<Usuario> GetAll();
    }
}
