using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IoC.Spring.Container.IoC
{
    public class SpringControllerFactory : DefaultControllerFactory, IControllerFactory
    {
        IController IControllerFactory.CreateController(System.Web.Routing.RequestContext requestContext, string controllerName)
        {
            IController controller = null;
            String controllerClassName = string.Format("{0}Controller", controllerName);
            if(SpringApplicationContext.Contains(controllerClassName))
            {
                controller = SpringApplicationContext.Resolve<IController>(controllerClassName);
            }
            else
            {
                try
                {
                    controller = base.CreateController(requestContext, controllerName);
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
            return controller;
        }

        void IControllerFactory.ReleaseController(IController controller)
        {
            IDisposable disposable = controller as IDisposable;
            if(disposable != null)
            {
                disposable.Dispose();
            }
        }
    }
}