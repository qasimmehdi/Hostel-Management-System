using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HostelManagment.Models;

namespace HostelManagment.Controllers
{
    public class VisitorController : Controller
    {
        // GET: Visitor
        [Authorize]
        public ActionResult Add()
        {
            new Students().dropdown1();
            return View();
        }

        [HttpPost]
        public ActionResult Add(Visitor u)
        {
            u.Add();
            return View();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(new Visitor().ShowAll());
        }

        [HttpPost]
        public ActionResult Index(string id)
        {
            return View(new Visitor().Search(id));
        }


        [HttpGet]
        public ActionResult Update(string id)
        {
            new Students().dropdown1();
            TempData["id"] = id;
            return View(new Visitor().UpItem(id));
        }

        [HttpPost]
        public ActionResult Update(Visitor Update_User)
        {
            Update_User.CNIC = (string)TempData["id"];
            Update_User.update();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            new Visitor().Delete(id);
            return RedirectToAction("Index");
        }
    }
}