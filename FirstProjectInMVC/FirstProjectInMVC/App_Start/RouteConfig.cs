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
                name: "Home.ParametrosQueryString",
                url: "parametros",
                defaults: new { controller = "Home", action = "ParametrosQueryString" }
            );
            routes.MapRoute(
                name: "Home.ParametrosRota",
                url: "parametros/{nome}", 
                defaults: new { controller = "Home", action = "ParametrosRota" }
            );
            routes.MapRoute(
                name: "Home.ParametrosRota2",
                url: "parametros2/{pagina}", 
                defaults: new { controller = "Home", action = "ParametrosRota2" }
            );
            routes.MapRoute(
                name: "Home.Contato",
                url: "contato",
                defaults: new { controller = "Home", action = "Contato" }
            );
            routes.MapRoute(
                name: "Tarefas.Index",
                url: "tarefas",
                defaults: new { controller = "Tarefas", action = "Index" }
            );
        }
    }
}
