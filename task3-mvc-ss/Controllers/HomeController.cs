using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using task3_mvc_ss.Models;

namespace task3_mvc_ss.Controllers
{
    public class HomeController : Controller
    {
        task3Entities ob = new task3Entities();
        // GET: Home
        public ActionResult Index()
        {
            var ash= ob.Employees.ToList(); 
            return View(ash);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
