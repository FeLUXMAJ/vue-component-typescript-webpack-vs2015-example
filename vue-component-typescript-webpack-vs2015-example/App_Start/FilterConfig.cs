using System.Web;
using System.Web.Mvc;

namespace vue_component_typescript_webpack_vs2015_example
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
