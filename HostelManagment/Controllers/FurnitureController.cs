using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HostelManagment.Models;

namespace HostelManagment.Controllers
{
    public class FurnitureController : Controller
    {
        // GET: Furniture
        public ActionResult Add()
        {
            new Room().dropdown1();     //isse room id ka dropdown bnaega
            return View();
        }

        [HttpPost]
        public ActionResult Add(Furniture u)
        {
            u.Add();
            return View();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(new Furniture().ShowAll());
        }

        [HttpPost]
        public ActionResult Index(int id)
        {
            return View(new Furniture().Search(id));
        }


        [HttpGet]
        public ActionResult Update(int id)
        {
            new Room().dropdown1();     //isse room id ka dropdown bnaega
            TempData["id"] = id;
            return View(new Furniture().UpItem(id));
        }

        [HttpPost]
        public ActionResult Update(Furniture Update_User)
        {
            Update_User.Furniture_ID = (int)TempData["id"];
            Update_User.update();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            new Furniture().Delete(id);
            return RedirectToAction("Index");
        }
    }
}