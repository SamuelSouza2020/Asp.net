using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FirstProjectInMVC
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
                name: "Home.Index",//nome da rota, esse nome é unico
                url: "", //quando acessar a url vazia, vai ser chamado o metodo Home e Index
                defaults: new { controller = "Home", action = "Index" }
            );
            routes.MapRoute(
                name: "Home.Contato",
                url: "contato",
                defaults: new { controller = "Home", action = "Contato" }
            );
        }
    }
}
