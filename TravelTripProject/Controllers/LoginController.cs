using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProject.Data;
using TravelTripProject.Models;

namespace TravelTripProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context Context = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            // Check if admin credentials match any record in the database
            var user = Context.Admins.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);

            if (user != null)
            {
                // Set auth cookie for the session
                FormsAuthentication.SetAuthCookie(user.Username, false);

                // Store the username in the session
                Session["Username"] = user.Username.ToString();

                // Redirect to the Admin dashboard after successful login
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                // If login fails, stay on the login page
                return View();
            }
        }
        public ActionResult Logout()
        {
            // Clear the session and redirect to the login page
            Session.Clear();
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }

    }
}