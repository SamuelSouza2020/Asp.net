using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstProjectInMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home  metodo
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult Index()
        {
            //ViewData["Titulo"] = "Home - Index";
            ViewBag.Titulo = "Home - Index";
            return View();
        }
        public ActionResult Contato()
        {
            //ViewData["Titulo"] = "Home - Contato";
            ViewBag.Titulo = "Home - Contato";
            return View();
        }
    }
}