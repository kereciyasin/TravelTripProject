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
            //var blogs = context.Blogs.ToList();
            blogComment.Value1 = context.Blogs.ToList();
            blogComment.Value3 = context.Blogs.OrderByDescending(x => x.Id).Take(3).ToList();
            return View(blogComment);
        }
        public ActionResult BlogDetails(int id)
        {
            //var blog = context.Blogs.Where(x => x.Id == id).ToList();
            blogComment.Value1 = context.Blogs.Where(x => x.Id == id).ToList();
            blogComment.Value2 = context.Comments.Where(x => x.BlogId == id).ToList();
            return View(blogComment);
        }
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult AddComment(Comment comment)
        {
            comment.Date = DateTime.Now;
            context.Comments.Add(comment);
            context.SaveChanges();
            return RedirectToAction("BlogDetails", new { id = comment.BlogId });
        }
    }
}