using AutoMapper;
using IoC.Spring.Container.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace IoC.Spring.Container
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ControllerBuilder.Current.SetControllerFactory(typeof(SpringControllerFactory));

            Mapper.Initialize(cfg =>
                cfg.AddProfiles(new[] {
                    "IoC.Spring.Container.Services",
                    "IoC.Spring.Container"
            }));
        }
    }
}
