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
        private IUsuariosRepository _repository;

        public UsuariosService(IUsuariosRepository usuariosRepository)
        {
            this._repository = usuariosRepository;
        }

        public void AddNew(Usuario usuario)
        {
            this._repository.Create(AutoMapper.Mapper.Map<Models.Usuario, Repositories.Usuario>(usuario));
            return;
        }

        public void Delete(int id)
        {
            this._repository.Delete(id);
            return;
        }

        public IList<Usuario> GetAll()
        {
            var usuarios = this._repository.GetAll();
            return AutoMapper.Mapper.Map<IList<Repositories.Usuario>,IList<Models.Usuario>>(usuarios);
        }

        public void Update(Usuario usuario)
        {
            this._repository.Update(AutoMapper.Mapper.Map<Models.Usuario, Repositories.Usuario>(usuario));
            return;
        }
    }
}
