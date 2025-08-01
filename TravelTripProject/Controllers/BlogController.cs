using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Data;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context context = new Context();
        public ActionResult Index()
        {
            var blogs = context.Blogs.ToList();
            return View(blogs);
        }
    }
}