using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Data;
using TravelTripProject.Models;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context context = new Context();
        BlogCommentViewModel blogComment = new BlogCommentViewModel();
        public ActionResult Index()
        {
            var blogs = context.Blogs.ToList();
            return View(blogs);
        }
        public ActionResult BlogDetails(int id)
        {
            //var blog = context.Blogs.Where(x => x.Id == id).ToList();
            blogComment.Value1 = context.Blogs.Where(x => x.Id == id).ToList();
            return View(blogComment);
        }
    }
}