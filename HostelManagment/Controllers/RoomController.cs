using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HostelManagment.Models;

namespace HostelManagment.Controllers
{
    public class RoomController : Controller
    {
        // GET: Room
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Room u)
        {
            u.Add();
            return View();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(new Room().ShowAll());
        }

        [HttpPost]
        public ActionResult Index(int id)
        {
            return View(new Room().Search(id));
        }


        [HttpGet]
        public ActionResult Update(int id)
        {
            TempData["id"] = id;
            return View(new Room().UpItems(id));
        }

        [HttpPost]
        public ActionResult Update(Room Update_User)
        {
            Update_User.Room_ID = (int)TempData["id"];
            Update_User.update();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            new Room().Delete(id);
            return RedirectToAction("Index");
        }
    }
}