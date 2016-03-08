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
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Send us your prayer request.";

            return View();

        }

        [httpPost]
        public ActionResult Contact(string message)

        {
            //TO DO: SEND MESSAGE TO HQ
            ViewBag.TheMessage = "Thank you. Your prayer request has been received.";

            return View();
        }
    }
}