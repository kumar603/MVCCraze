using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCraze
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

            //This is custom route created to handle the url request
            //from user that will find the Products controller and List action
            //Route : http://localhost:53291/Products/List
            routes.MapRoute(
                name: "MainRoute",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Products", action = "List", id = UrlParameter.Optional }
                );


            //can add custom route parameters like  

            //Route : http://localhost:53291/Products/List/All/1  - It will fetch all the brands and by Id 
            //Route : http://localhost:53291/Products/List/Nike  - It will get all the Nikes brands as default all
            //Route : http://localhost:53291/Products/List/Nike/1 - It will get Nike brands from Id 1

            //public ActionResult List(string category, int? id)

            routes.MapRoute(
            name : "CustomParameterisedRoute",
            url: "{controller}/{action}/{category}/{id}",
        defaults: new { controller = "Products", action = "List", category = "All", id = UrlParameter.Optional }
        );

        }
    }
}
