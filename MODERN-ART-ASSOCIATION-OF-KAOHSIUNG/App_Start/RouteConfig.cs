using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MODERN_ART_ASSOCIATION_OF_KAOHSIUNG
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //後台的Route
            routes.MapRoute(
                name: "Backstage",
                url: "Backstage/{controller}/{action}/{id}",
                defaults: new { controller = "BAA", action = "AssociationHistoryIndex", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
           
        }
    }
}
