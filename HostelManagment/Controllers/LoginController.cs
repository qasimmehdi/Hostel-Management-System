using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HostelManagment.Models;
using System.Web.Security;

namespace HostelManagment.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Add()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Add(Login u)
        {
            if (u.check() == true)
            {
                FormsAuthentication.SetAuthCookie(u.S_Email,false); //Login
                TempData["ok"] = u.S_ID;                                                   // FormsAuthentication.SignOut(); Siggout
                                                                  // string a = HttpContext.User.Identity.Name; naam of user
                                                                    // bool a=  HttpContext.User.Identity.IsAuthenticated;
            }
            else
            {
                ModelState.AddModelError("", "Incorrect Email or Password");
                return View();
            }
            return RedirectToAction("Index", "Students");
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Login().ShowAll());
        }

        
        public ActionResult signout()
        {
            FormsAuthentication.SignOut();
            return View("~/Views//Home/Index.cshtml");
        }

        //[HttpPost]
        //public ActionResult Index(int id)
        //{
        //    return View(new Login().Search(id));
        //}


        //[HttpGet]
        //public ActionResult Update(int id)
        //{
        //    new Students().dropdown1();
        //    new Room().dropdown1();
        //    TempData["id"] = id;
        //    return View(new Login().UpItem(id));
        //}

        //[HttpPost]
        //public ActionResult Update(Login Update_User)
        //{
        //    Update_User.S_ID = (int)TempData["id"];
        //    Update_User.update();
        //    return RedirectToAction("Index");
        //}

        //public ActionResult Delete(int id)
        //{
        //    new Login().Delete(id);
        //    return RedirectToAction("Index");
        //}
    }
}