using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HostelManagment.Models;

namespace HostelManagment.Controllers
{
    public class HostelController : Controller
    {
        // GET: Hostel
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Hostel u)
        {
            u.Add();
            return View();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(new Hostel().ShowAll());
        }

        [HttpPost]
        public ActionResult Index(int id)
        {
            return View(new Hostel().Search(id));
        }


        [HttpGet]
        public ActionResult Update(int id)
        {
            TempData["id"] = id;
            return View(new Hostel().UpItems(id));
        }

        [HttpPost]
        public ActionResult Update(Hostel Update_User)
        {
            Update_User.Building_ID = (int)TempData["id"];
            Update_User.update();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            new Hostel().Delete(id);
            return RedirectToAction("Index");
        }
    }
}