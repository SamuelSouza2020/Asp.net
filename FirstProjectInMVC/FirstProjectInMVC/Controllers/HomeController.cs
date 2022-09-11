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

            HomeIndexModel model = new HomeIndexModel();
            model.TituloDaPagina = "Home - Index";
            model.DataAtual = DateTime.Now;

            //HomeContatoModel model = new HomeContatoModel();

            return View(model);
        }
        public ActionResult ParametrosQueryString(string nome)
        {
            return Content(nome);
        }
        public ActionResult ParametrosRota(string nome)
        {
            return Content(nome);
        }
        public ActionResult ParametrosRota2(int? pagina)
        {
            return Content(pagina.HasValue ? pagina.ToString() : "0");
        }
        public ActionResult Contato()
        {
            //ViewData["Titulo"] = "Home - Contato";
            ViewBag.Titulo = "Home - Contato";
            return View();
        }
    }
}