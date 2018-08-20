using IoC.Spring.Container.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Web.Mvc;

namespace IoC.Spring.Container.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            HomeController controller = new HomeController();
            controller.UsuariosService = new Mocks.MockUsuariosService();
            ViewResult viewResult = controller.Index() as ViewResult;
            Assert.AreEqual(((IList<Models.Usuario>)viewResult.Model).Count, 1);
        }

        [TestMethod]
        public void Create()
        {
            HomeController controller = new HomeController();
            controller.UsuariosService = new Mocks.MockUsuariosService();
            RedirectToRouteResult redirectResult = controller.Create(new Models.Usuario() { Id = 2, Nombre = "Pepe", Apellido = "Argento", Documento = "09387837" }) as RedirectToRouteResult;
            Assert.IsTrue(redirectResult.RouteValues["action"].Equals("Index"));
        }

        [TestMethod]
        public void Contact()
        {

        }
    }
}
