using IoC.Spring.Container.Services.Interfaces;
using System.Linq;
using System.Web.Mvc;

namespace IoC.Spring.Container.Controllers
{
    public class HomeController : Controller
    {
        public IUsuariosService UsuariosService { get; set; }

        public ActionResult Index()
        {
            var usuarios = this.UsuariosService.GetAll();
            return View(usuarios);
        }

        public ActionResult Create()
        {
            return View(new Models.Usuario());
        }

        [HttpPost]
        public ActionResult Create(Models.Usuario model)
        {
            if(model.Id.ToString() == "0")
            {
                this.UsuariosService.AddNew(model);
            }
            else
            {
                this.UsuariosService.Update(model);
            }            
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var usuario = this.UsuariosService.GetAll().FirstOrDefault(u => u.Id == id);
            return View("Create", usuario);
        }

        public ActionResult Delete(string id)
        {
            this.UsuariosService.Delete(int.Parse(id));
            return RedirectToAction("Index");
        }
    }
}