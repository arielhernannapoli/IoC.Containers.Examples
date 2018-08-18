using System.Web;
using System.Web.Mvc;

namespace IoC.Spring.Container
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
