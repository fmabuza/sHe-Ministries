using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sHe_Ministries.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "sHe is the one that was chosen by Him.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Please give us your feedback.";

            return View();

        }

        [HttpPost]
        public ActionResult Contact(string message)

        {
            //TO DO: SEND MESSAGE TO HQ
            ViewBag.TheMessage = "Thank you. Your opinion matters to us.";

            return View();
        }
    }
}