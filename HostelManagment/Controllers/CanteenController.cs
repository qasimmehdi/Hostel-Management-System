using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HostelManagment.Models;

namespace HostelManagment.Controllers
{
    public class CanteenController : Controller
    {
        // GET: Canteen
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Canteen u)
        {
            u.Add();
            return View();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(new Canteen().ShowAll());
        }

        [HttpPost]
        public ActionResult Index(int id)
        {
            return View(new Canteen().Search(id));
        }


        [HttpGet]
        public ActionResult Update(int id)
        {
            TempData["id"] = id;
            return View(new Canteen().UpItem(id));
        }

        [HttpPost]
        public ActionResult Update(Canteen Update_User)
        {
            Update_User.Canteen_MGR = (int)TempData["id"];
            Update_User.update();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            new Canteen().Delete(id);
            return RedirectToAction("Index");
        }
    }
}