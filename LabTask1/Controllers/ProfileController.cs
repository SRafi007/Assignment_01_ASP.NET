using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabTask1.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Home()
        {
            ViewBag.name = "Sadman Sakib Rafi";
            ViewBag.id = "19-40918-2";
            ViewBag.email = "sadmansakib.rafiaiub@gmail.com";
            ViewBag.phn_number = "01790084193";

            return View();
        }
        public ActionResult Education()
        {
            //return RedirectToAction("Home");
            return View();
        }
        public ActionResult Projects()
        {
            //return RedirectToAction("Home");
            return View();
        }
        public ActionResult Reference()

        {
            ViewBag.faculty = "TANVIR AHMED";
            ViewBag.department = "Lecturer, Department of Computer Science";
            ViewBag.institute = "American International University - Bangladesh (AIUB)";
            ViewBag.email = " tanvir.ahmed@aiub.edu";
            return View();
        }
    }
}