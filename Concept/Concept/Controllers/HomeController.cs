using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Concept.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "This will become the new Concept Cleaning website";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }
    }
}
