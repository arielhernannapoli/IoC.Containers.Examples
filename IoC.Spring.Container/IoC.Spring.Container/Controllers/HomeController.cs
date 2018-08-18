using IoC.Spring.Container.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

    }
}