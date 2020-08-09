using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.GetDataFromServer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string serverName = System.Environment.MachineName;
            return View ("Index", (object)serverName);
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