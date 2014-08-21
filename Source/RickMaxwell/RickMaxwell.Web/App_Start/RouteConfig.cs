using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RickMaxwell.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Sculptor",
                "Sculptor",
                new { controller = "Home", action = "Index" }
                );

            routes.MapRoute(
                "BentWood",
                "BentWood",
                new { controller = "Home", action = "BentWood" }
                );

            routes.MapRoute(
               "Wall-Reliefs",
               "Wall-Reliefs",
               new { controller = "Home", action = "WallReliefs" }
               );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}