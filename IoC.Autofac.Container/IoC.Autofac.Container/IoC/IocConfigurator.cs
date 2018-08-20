using Autofac;
using Autofac.Integration.Mvc;
using IoC.Autofac.Container.Repositories;
using IoC.Autofac.Container.Repositories.Interfaces;
using IoC.Autofac.Container.Services;
using IoC.Autofac.Container.Services.Interfaces;
using System.Web.Mvc;

namespace IoC.Autofac.Container.IoC
{
    public static class IocConfigurator
    {
        public static void ConfigureDependencyInjection()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<UsuariosRepository>().As<IUsuariosRepository>();
            builder.RegisterType<UsuariosService>().As<IUsuariosService>();
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}