using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sHe_Ministries.Controllers
{
    public class PrayersController : Controller
    {
        // GET: Prayers
        public ActionResult Index()
        {
            return View();
        }
    }
}