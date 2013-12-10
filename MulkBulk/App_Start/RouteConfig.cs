using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MulkBulk
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
             * */


            routes.MapRoute(
                name: "AccountDefault",
                url: "account/{action}",
                defaults: new { controller = "Account" }
            );

            routes.MapRoute(
            name: "ManageAccount",
            url: "account/manage",
            defaults: new { controller = "Account", action = "Manage" }
        );
            
            routes.MapRoute(
              name: "Login",
              url: "login",
              defaults: new { controller = "Account", action = "Login" }
          );


            routes.MapRoute(
             name: "Register",
             url: "register",
             defaults: new { controller = "Account", action = "Register" }
         );

            routes.MapRoute(
            name: "Messages",
            url: "messages",
            defaults: new { controller = "Home", action = "Messages" }
        );

        routes.MapRoute(
          name: "UserMessages",
          url: "messages/{username}",
          defaults: new { controller = "Home", action = "Messages" }
      );

        routes.MapRoute(
        name: "UserDefault",
        url: "{username}/{action}",
        defaults: new { controller = "user", action = "index" }

      );

        routes.MapRoute(
           name: "Default",
           url: "",
           defaults: new { controller = "home", action = "index" }
       );


        }
    }
}
