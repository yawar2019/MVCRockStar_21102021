using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCRockStar_21102021
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           

            routes.MapRoute(
               name: "Default23",
               url: "school/class/{eid=1211}", //seo
               defaults: new { controller = "Default", action = "getEmployeeId", eid = UrlParameter.Optional }
           );

           

            routes.MapRoute(
               name: "Default22",
               url: "hotel/bedroom", //seo
               defaults: new { controller = "Default", action = "GetId", id = UrlParameter.Optional }
           );


            routes.MapRoute(
             name: "Default",
             url: "{controller}/{action}/{id}",//old client Default/index
             defaults: new { controller = "Default", action = "GetId", id = UrlParameter.Optional }
         );


        }
    }
}
