using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Data;
using TravelTripProject.Models;


namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        Context context = new Context();
        // GET: Admin
        public ActionResult Index()
        {
            var values = context.Blogs.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBlog(int id)
        {
            var blog = context.Blogs.Find(id);
            context.Blogs.Remove(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}