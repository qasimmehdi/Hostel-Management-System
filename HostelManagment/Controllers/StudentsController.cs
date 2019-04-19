using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HostelManagment.Models;

namespace HostelManagment.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Students u)
        {
            u.Add();
            return View();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(new Students().ShowAll());
        }

        [HttpPost]
        public ActionResult Index(int id)
        {
            return View(new Students().Search(id));
        }


        [HttpGet]
        public ActionResult Update(int id)
        {
            TempData["id"] = id;
            return View(new Students().UpItem(id));
        }

        [HttpPost]
        public ActionResult Update(Students Update_User)
        {
            Update_User.S_ID = (int)TempData["id"];
            Update_User.update();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            new Students().Delete(id);
            return RedirectToAction("Index");
        }

        
    }
}