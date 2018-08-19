using IoC.Spring.Container.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Spring.Container.Repositories
{
    public class UsuariosRepository : IUsuariosRepository
    {
        public TestContext _context;

        public UsuariosRepository()
        {
            this._context = new TestContext();
        }

        public void Create(Usuario usuario)
        {
            this._context.Usuarios.Add(usuario);
            this._context.SaveChanges();
        }

        public void Delete(int id)
        {
            var usuario = this._context.Usuarios.FirstOrDefault(u => u.Id == id);
            this._context.Usuarios.Remove(usuario);
            this._context.SaveChanges();
        }

        public IList<Usuario> GetAll()
        {
            return this._context.Usuarios.ToList();
        }

        public void Update(Usuario usuario)
        {
            var usuarioDb = this._context.Usuarios.FirstOrDefault(u => u.Id == usuario.Id);
            usuarioDb.Nombre = usuario.Nombre;
            usuarioDb.Apellido = usuario.Apellido;
            usuarioDb.Documento = usuario.Documento;
            this._context.Entry(usuarioDb).State = EntityState.Modified;
            this._context.SaveChanges();
        }
    }
}
