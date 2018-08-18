using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoC.Spring.Container.IoC
{
    public static class SpringApplicationContext
    {
        private static IApplicationContext Context { get; set; }

        public static bool Contains(string objectName)
        {
            SpringApplicationContext.EnsureContext();
            return SpringApplicationContext.Context.ContainsObject(objectName);
        }

        public static object Resolve(string objectName)
        {
            SpringApplicationContext.EnsureContext();
            return SpringApplicationContext.Context.GetObject(objectName);
        }

        public static T Resolve<T>(string objectName)
        {
            return (T)SpringApplicationContext.Resolve(objectName);
        }

        public static void EnsureContext()
        {
            if(SpringApplicationContext.Context == null)
            {
                SpringApplicationContext.Context = ContextRegistry.GetContext();
            }
        }
    }
}