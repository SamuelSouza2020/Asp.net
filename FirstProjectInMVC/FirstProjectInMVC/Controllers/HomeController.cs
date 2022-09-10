using FirstProjectInMVC.Models;
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
            
            //ViewBag.Titulo = "Home - Index";

            //HomeIndexModel model = new HomeIndexModel();
            //model.TituloDaPagina = "Home - Index";
            //model.DataAtual = DateTime.Now;

            HomeContatoModel model = new HomeContatoModel();

            return View(model);
        }
        public ActionResult Contato()
        {
            //ViewData["Titulo"] = "Home - Contato";
            ViewBag.Titulo = "Home - Contato";
            return View();
        }
    }
}