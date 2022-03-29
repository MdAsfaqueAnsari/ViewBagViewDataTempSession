using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBagViewDataTempSession.Models;

namespace ViewBagViewDataTempSession.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmpModel emp = new EmpModel();

            emp.Name = "Asfaque";
            emp.Mobile = 95888253;
            emp.Email = "mdasu@gmail.com";
           


            ViewBag.demo = "This is ViewBag";
            ViewBag.demo1 = 9585585454;
            ViewBag.Date = DateTime.Now;
            ViewBag.flo = 77.154f;
            ViewBag.don = 447.24;


            ViewData["Test1"] = "This is ViewData";
            ViewData["Test2"] = 72587455;
            ViewData["Test3"]= DateTime.Now;
            ViewData["Test4"] = 77.5f;
            ViewData["Test5"] = 77.25;


            TempData["Tem1"] = "This is TempData";
            TempData["Tem2"] = 95367463;
            TempData["Tem3"] = DateTime.Now;
            TempData["Tem4"] = 54.15f;
            TempData["Tem5"] = 545.21;


            Session["Name"] = "This is Session Data";

            return View(emp);

           // return RedirectToAction("Test");
        }

        public ActionResult Test()
        {
            var view = ViewBag.flo;
            var viewdata = ViewData["Test1"];
            var Temp = TempData["Tem1"];
            return View();
        }
    }
}