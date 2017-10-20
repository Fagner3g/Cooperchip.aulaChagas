using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cooperchip.aulaChagas.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(string id, string code)
        {
            ViewBag.Message = "Aprendendo o Método ViewBag.";
            ViewBag.id = id;
            ViewBag.code = code;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Aprendendo Asp.Net pela internet.";

            return View();
        }

        public ActionResult Clientes()
        {
            return View();
        }

        public ActionResult Aprendizado()
        {
            return View();
        }
    }
}