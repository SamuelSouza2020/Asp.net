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
        public string Index()
        {
            return "Hello World";
        }
    }
}