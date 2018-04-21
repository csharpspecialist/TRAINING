using System.Web.Mvc;
using System.Web.Routing;

namespace MVCCodeFirst2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Menu", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
