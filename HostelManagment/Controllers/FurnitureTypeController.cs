using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HostelManagment.Models;

namespace HostelManagment.Controllers
{
    public class FurnitureTypeController : Controller
    {
        // GET: FurnitureType
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Furniture_type u)
        {
            u.Add();
            return View();
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Furniture_type().ShowAll());
        }

        [HttpPost]
        public ActionResult Index(int id)
        {
            return View(new Furniture_type().Search(id));
        }


        [HttpGet]
        public ActionResult Update(int id)
        {
            TempData["id"] = id;
            return View(new Furniture_type().UpItem(id));
        }

        [HttpPost]
        public ActionResult Update(Furniture_type Update_User)
        {
            Update_User.Furniture_ID = (int)TempData["id"];
            Update_User.update();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            new Furniture_type().Delete(id);
            return RedirectToAction("Index");
        }
    }
}