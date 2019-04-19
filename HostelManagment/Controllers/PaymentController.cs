using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HostelManagment.Models;

namespace HostelManagment.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Fee
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Payment u)
        {
            u.Add();
            return View();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(new Payment().ShowAll());
        }

        [HttpPost]
        public ActionResult Index(int id)
        {
            return View(new Payment().Search(id));
        }


        [HttpGet]
        public ActionResult Update(int id)
        {
            TempData["id"] = id;
            return View(new Payment().UpItem(id));
        }

        [HttpPost]
        public ActionResult Update(Payment Update_User)
        {
            Update_User.Payment_ID = (int)TempData["id"];
            Update_User.update();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            new Payment().Delete(id);
            return RedirectToAction("Index");
        }
    }
}