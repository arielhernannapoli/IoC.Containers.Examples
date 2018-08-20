using IoC.Autofac.Container.Models;
using IoC.Autofac.Container.Repositories.Interfaces;
using IoC.Autofac.Container.Services.Interfaces;
using System.Collections.Generic;

namespace IoC.Autofac.Container.Services
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
