using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HostelManagment.Models;

namespace HostelManagment.Controllers
{
    public class AllocationController : Controller
    {
        // GET: Allocation

        public ActionResult Add()
        {
            new Students().dropdown1();
            new Room().dropdown1();
            return View();
        }

        [HttpPost]
        public ActionResult Add(S_Allocation u)
        {
            u.Add();
            return View();
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View(new S_Allocation().ShowAll());
        }

        [HttpPost]
        public ActionResult Index(int id)
        {
            return View(new S_Allocation().Search(id));
        }


        [HttpGet]
        public ActionResult Update(int id)
        {
            new Students().dropdown1();
            new Room().dropdown1();
            TempData["id"] = id;
            return View(new S_Allocation().UpItem(id));
        }

        [HttpPost]
        public ActionResult Update(S_Allocation Update_User)
        {
            Update_User.Allocation_ID = (int)TempData["id"];
            Update_User.update();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            new S_Allocation().Delete(id);
            return RedirectToAction("Index");
        }
    }
}