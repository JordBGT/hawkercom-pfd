using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using PFD_Team3.Models;
using PFD_Team3.DAL;

namespace PFD_Team3.Controllers
{
    public class RegisterUserController : Controller
    {

        private UserDAL userContext = new UserDAL();

        // GET: RegisterUserController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Success()
        {
            return View();
        }

        // GET: RegisterUserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegisterUserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegisterUserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User u)
        {
            if (ModelState.IsValid)
            {
                if (userContext.IsEmailExist(u.Email) == false)
                {
                    //Add user record to database
                    u.UserID = userContext.Add(u);
                    return RedirectToAction("Success","RegisterUser");
                }
                TempData["Message"] = "Email is already registered in our system.";
                return View(u);
            }
            else
            {
                //Input validation fails, return to the Create view
                //to display error message
                return View(u);
            }
        }

        // GET: RegisterUserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegisterUserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RegisterUserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegisterUserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
