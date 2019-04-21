using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HostelManagment.Models;

namespace HostelManagment.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Add()
        {
            new Hostel().dropdown1();
            return View();
        }

        [HttpPost]
        public ActionResult Add(Employees u)
        {
            u.Add();
            return View();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(new Employees().ShowAll());
        }

        [HttpPost]
        public ActionResult Index(int id)
        {
            return View(new Employees().Search(id));
        }


        [HttpGet]
        public ActionResult Update(int id)
        {
            new Hostel().dropdown1();
            TempData["id"] = id;
            return View(new Employees().UpItem(id));
        }

        [HttpPost]
        public ActionResult Update(Employees Update_User)
        {
            Update_User.Emp_ID = (int)TempData["id"];
            Update_User.update();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            new Employees().Delete(id);
            return RedirectToAction("Index");
        }
    }
}