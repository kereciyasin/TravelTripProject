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
            var values = context.Blogs.Take(10).ToList();
            return View(values);
        }

        public ActionResult About()
        {

            return View();
        }

        public PartialViewResult Partial1()
        {
            var values = context.Blogs.OrderByDescending(x => x.Id).Take(2).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial2()
        {
            var values = context.Blogs.Where(x => x.Id == 1).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial3()
        {
            var values = context.Blogs.ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial4()
        {
            var values = context.Blogs.Take(3).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial5()
        {
            var values = context.Blogs.Take(3).OrderByDescending(x => x.Id).ToList();
            return PartialView(values);
        }
    }
}