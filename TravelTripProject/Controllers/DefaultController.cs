using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Data;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            var values = context.Blogs.ToList();
            return View(values);
        }

        public ActionResult About()
        {

            return View();
        }
    }
}