using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PFD_Team3.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PFD_Team3.DAL;
using PFD_Team3.Models;
using Microsoft.AspNetCore.Http;

namespace PFD_Team3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private LoginDAL loginContext = new LoginDAL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            var role = HttpContext.Session.GetString("Role");
            return View();
        }

        public IActionResult FoodArticle()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Account()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(IFormCollection formData) //Login to different account
        {
            string loginID = formData["emailLogin"].ToString().ToLower();
            string password = formData["passwordLogin"].ToString();


            if (loginContext.ValidateUser(loginID, password) == true)
            {
                //HttpContext.Session.SetString("LoginID", loginID);
                HttpContext.Session.SetString("Role", "User");
                HttpContext.Session.SetString("UserID", Convert.ToString(loginContext.GetUserID(loginID)));
                HttpContext.Session.SetString("UserName", loginContext.GetUserName(loginID));
                HttpContext.Session.SetString("UserOfEmail", loginContext.GetUserEmail(loginID));
                HttpContext.Session.SetString("UserOfPassword", loginContext.GetUserPassword(loginID));
                return RedirectToAction("PostDetails", "Post");
            }
            else
            {
                TempData["Message"] = "Invalid Login Credentials";
                return RedirectToAction("Login");
            }
        }

        public ActionResult LogOut()
        {
            HttpContext.Session.Clear();
            TempData["Message"] = "";
            return RedirectToAction("Index");
        }
    }
}
