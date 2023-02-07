using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace task3_mvc_ss.Controllers
{
    public class renderpageController : Controller
    {
        // GET: renderpage
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult renderpage()
        {
            return View();
        }
    }
}