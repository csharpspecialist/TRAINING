using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCDbaseFirst3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Emp",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Employees", action = "Index", id = UrlParameter.Optional }
            );


            routes.MapRoute(
           name: "Default",
           url: "{controller}/{action}/{id}",
           defaults: new { controller = "MiniSeries", action = "Index", id = UrlParameter.Optional }
       );


        }
    }
}
