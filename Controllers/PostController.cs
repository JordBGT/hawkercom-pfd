using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PFD_Team3.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using PFD_Team3.DAL;
using System.IO;

namespace PFD_Team3.Controllers
{
    public class PostController : Controller
    {
        private PostDAL postContext = new PostDAL();
        private PostVMDAL postVMContext = new PostVMDAL(); 
        // GET: PostController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PostController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult PostDetails()
        {
            List<PostViewModel> postVMList = postVMContext.GetUsernameByID();
            ViewData["UserName"] = HttpContext.Session.GetString("UserName");

            return View(postVMList);
        }

        // GET: PostController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PostController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Post post)
        {
            int id = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            if (ModelState.IsValid)
            {
                if (post.fileToUpload != null && post.fileToUpload.Length > 0)
                {
                    try
                    {
                        // Find the filename extension of the file to be uploaded.
                        string fileExt = Path.GetExtension(post.fileToUpload.FileName);
                        // Rename the uploaded file with the staff’s name.
                        string uploadedFile = post.fileToUpload + fileExt;
                        // Get the complete path to the images folder in server
                        string savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", uploadedFile);
                        // Upload the file to server
                        using (var fileSteam = new FileStream(
                         savePath, FileMode.Create))
                        {
                            await post.fileToUpload.CopyToAsync(fileSteam);
                        }
                        post.FileSubmitted = uploadedFile;
                        post.PostID = postContext.Add(post, id);
                        ViewData["Message"] = "File uploaded successfully.";
                    }
                    catch (IOException)
                    {
                        //File IO error, could be due to access rights denied
                        ViewData["Message"] = "File uploading fail!";
                    }
                    catch (Exception ex) //Other type of error
                    {
                        ViewData["Message"] = ex.Message;
                    }
                }
                else
                {
                    post.PostID = postContext.Add(post, id);
                    return RedirectToAction("PostDetails", "Post");
                }
                
            }
            return View(post);
       
        }

        public ActionResult UploadPhoto(int id)
        {
            id = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            //string name = HttpContext.Session.GetString("UserName");
            //string email = HttpContext.Session.GetString("UserOfEmail");
            //string password = HttpContext.Session.GetString("UserOfPassword");

            // Stop accessing the action if not logged in
            // or account not in the "User" role
            if ((HttpContext.Session.GetString("Role") == null) ||
            (HttpContext.Session.GetString("Role") != "User"))
            {
                return RedirectToAction("Index", "Home");
            }
            Post post = postContext.GetDetails(id);

            Post postDisplay = new Post
            {
                UserID = id,
                Title = post.Title,
                HawkerName = post.HawkerName,
                HawkerStore = post.HawkerStore,
                Rating = post.Rating,
                Description = post.Description,
                FileSubmitted = post.fileToUpload + ".jpg"
            };

            return View(post);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UploadPhoto(Post post)
        {
            if (post.fileToUpload != null &&
            post.fileToUpload.Length > 0)
            {
                try
                {
                    // Find the filename extension of the file to be uploaded.
                    string fileExt = Path.GetExtension(
                     post.fileToUpload.FileName);
                    // Rename the uploaded file with the staff’s name.
                    string uploadedFile = post.fileToUpload + fileExt;
                    // Get the complete path to the images folder in server
                    string savePath = Path.Combine(
                     Directory.GetCurrentDirectory(),
                     "wwwroot\\images", uploadedFile);
                    // Upload the file to server
                    using (var fileSteam = new FileStream(
                     savePath, FileMode.Create))
                    {
                        await post.fileToUpload.CopyToAsync(fileSteam);
                    }
                    post.FileSubmitted = uploadedFile;
                    postContext.UpdateFileSubmitted(post, post.PostID);
                    ViewData["Message"] = "File uploaded successfully.";
                }
                catch (IOException)
                {
                    //File IO error, could be due to access rights denied
                    ViewData["Message"] = "File uploading fail!";
                }
                catch (Exception ex) //Other type of error
                {
                    ViewData["Message"] = ex.Message;
                }
            }
            return View(post);
        }

        // GET: PostController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PostController/Edit/5
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

        // GET: PostController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PostController/Delete/5
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
