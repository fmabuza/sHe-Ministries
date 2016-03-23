using sHe_Ministries.Models;
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
        [HttpGet]
        public ActionResult Share()
        {

            return View(new Prayers());

              }
        [HttpPost]
        public ActionResult Share (Prayers prayers)
        {
            var context = new ApplicationDbContext();

            context.Set<Prayers>().Add(prayers);
            context.SaveChanges();
            return RedirectToAction("Share");
        }
    }
}