using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace finalTaskCodeFirstSchool.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        // POST: Account/Login
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            // Hardcoded user validation for demonstration, replace with actual authentication logic
            if (username == "admin" && password == "password")
            {
                FormsAuthentication.SetAuthCookie(username, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Invalid credentials!";
                return View();
            }
        }

        // GET: Account/Logout
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}