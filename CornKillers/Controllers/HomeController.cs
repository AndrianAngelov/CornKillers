using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CornKillers.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";
            ViewData["PopCorn"] = "Eat all these little bastards";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
