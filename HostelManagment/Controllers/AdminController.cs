using HostelManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HostelManagment.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Admin u)
        {
            u.Add();
            return View();
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Admin().ShowAll());
        }

        [HttpPost]
        public ActionResult Index(int id)
        {
            return View(new Admin().Search(id));
        }


        [HttpGet]
        public ActionResult Update(int id)
        {
            new Students().dropdown1();
            new Room().dropdown1();
            TempData["id"] = id;
            return View(new Admin().UpItem(id));
        }

        [HttpPost]
        public ActionResult Update(Admin Update_User)
        {
            Update_User.A_ID = (int)TempData["id"];
            Update_User.update();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            new Admin().Delete(id);
            return RedirectToAction("Index");
        }
    }
}