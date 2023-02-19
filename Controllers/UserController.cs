using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PFD_Team3.DAL;
using PFD_Team3.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace PFD_Team3.Controllers
{
    public class UserController : Controller
    {

        private UserDAL userContext = new UserDAL();

        // GET: UserController
        public ActionResult Index()
        {
            if ((HttpContext.Session.GetString("Role") == null) ||
               (HttpContext.Session.GetString("Role") != "User"))
            {
                return RedirectToAction("Index", "Home");
            }
            ViewData["UserName"] = HttpContext.Session.GetString("UserName");
            return View();
        }

        public ActionResult UserHome()
        {
            if ((HttpContext.Session.GetString("Role") == null) ||
                (HttpContext.Session.GetString("Role") != "User"))
            {
                return RedirectToAction("Index", "Home");
            }
            ViewData["UserName"] = HttpContext.Session.GetString("UserName");
            return View();
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
           
            id = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            string name = HttpContext.Session.GetString("UserName");
            string email = HttpContext.Session.GetString("UserOfEmail");
            string password = HttpContext.Session.GetString("UserOfPassword");


            if ((HttpContext.Session.GetString("Role") == null) ||
                (HttpContext.Session.GetString("Role") != "User"))
            {
                return RedirectToAction("Index", "Home");
            }
            User user = userContext.GetDetails(id);
            
            UserViewModel userVM = new UserViewModel
            {
                UserID = user.UserID,
                UserName = name,
                Email = email,
                Password = password,
                Photo = user.UserName + ".jpg"
            };

            return View(userVM);
        }

        //public UserViewModel MapToUserVM(User user)
        //{

        //    UserViewModel userVM = new UserViewModel
        //    {
        //        UserID = user.UserID,
        //        UserName = user.UserName,
        //        Email = user.Email,
        //        Pwd = user.Pwd,
        //        Photo = user.UserName + ".jpg"
        //    };

        //    return userVM;
        //}


        
        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: UserController/Edit/5
        public ActionResult Edit(int? id)
        {
            // Stop accessing the action if not logged in
            // or account not in the "User" role
            if ((HttpContext.Session.GetString("Role") == null) ||
            (HttpContext.Session.GetString("Role") != "User"))
            {
                return RedirectToAction("Index", "Home");
            }
            if (id == null)
            { //Query string parameter not provided
              //Return to listing page, not allowed to edit
                return RedirectToAction("Index","Home");
            }

            User user = userContext.GetDetails(id.Value);
            if (user == null)
            {
                //Return to listing page, not allowed to edit
                return RedirectToAction("Index","Home");
            }
            return View(user);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                //Update staff record to database
                userContext.Update(user);
                HttpContext.Session.Clear();
                return RedirectToAction("Index" ,"Home");
            }
            else
            {
                //Input validation fails, return to the view
                //to display error message
                return View(user);
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
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

        //public ActionResult UploadPhoto(int id)
        //{
        //    id = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
        //    string name = HttpContext.Session.GetString("UserName");
        //    string email = HttpContext.Session.GetString("UserOfEmail");
        //    string password = HttpContext.Session.GetString("UserOfPassword");

        //    // Stop accessing the action if not logged in
        //    // or account not in the "User" role
        //    if ((HttpContext.Session.GetString("Role") == null) ||
        //    (HttpContext.Session.GetString("Role") != "User"))
        //    {
        //        return RedirectToAction("Index", "Home");
        //    }
        //    User user = userContext.GetDetails(id);

        //    UserViewModel userVM = new UserViewModel
        //    {
        //        UserID = user.UserID,
        //        UserName = name,
        //        Email = email,
        //        Password = password,
        //        Photo = user.UserName + ".jpg"
        //    };

        //    return View(userVM);   
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> UploadPhoto(UserViewModel userVM)
        //{

        //    if (userVM.fileToUpload != null &&
        //    userVM.fileToUpload.Length > 0)
        //    {
        //        try
        //        {
        //            // Find the filename extension of the file to be uploaded.
        //            string fileExt = Path.GetExtension(
        //             userVM.fileToUpload.FileName);
        //            // Rename the uploaded file with the staff’s name.
        //            string uploadedFile = userVM.UserName + fileExt;
        //            // Get the complete path to the images folder in server
        //            string savePath = Path.Combine(
        //             Directory.GetCurrentDirectory(),
        //             "wwwroot\\images", uploadedFile);
        //            // Upload the file to server
        //            using (var fileSteam = new FileStream(
        //             savePath, FileMode.Create))
        //            {
        //                await userVM.fileToUpload.CopyToAsync(fileSteam);
        //            }
        //            userVM.Photo = uploadedFile;

        //            ViewData["Message"] = "File uploaded successfully.";
        //        }
        //        catch (IOException)
        //        {
        //            //File IO error, could be due to access rights denied
        //            ViewData["Message"] = "File uploading fail!";
        //        }
        //        catch (Exception ex) //Other type of error
        //        {
        //            ViewData["Message"] = ex.Message;
        //        }
        //    }
        //    return View(userVM);
        //}
    }
}
