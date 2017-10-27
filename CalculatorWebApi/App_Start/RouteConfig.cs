using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CalculatorWebApi
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Home-Calc",
                url: "Home/Calc.aspx",
                defaults: new { controller = "Home", action = "Calc" }
                );

            routes.MapRoute(
                "Home-Result",
                "Home/Result.aspx",
                new { controller = "Home", action = "Result" }
                );
        }
    }
}
