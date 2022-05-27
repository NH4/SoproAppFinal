using SoproAppFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoproAppFinal.Controllers
{
    public class HomeController : Controller
    {
        Model1 model = new Model1();
        public ActionResult Index()
        {
            //var mtl = model.Movies.ToList();
            return View(model.Movies.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}