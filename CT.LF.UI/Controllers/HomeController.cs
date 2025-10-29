using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CT.LF.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult SaveLocation(double latitude, double longitude)
        {
            // You could log this to a database, for example:
            // _db.Locations.Add(new UserLocation { Lat = latitude, Lng = longitude });
            // _db.SaveChanges();

            return Json(new { success = true, message = "Location received", latitude, longitude });
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