using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        EF_TestEntities con = new EF_TestEntities();
        public ActionResult Index()
        {
            ViewBag.Message = con.Messages.First().Message1;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = con.Messages.Last().Message1;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
