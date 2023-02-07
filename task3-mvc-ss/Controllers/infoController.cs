using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using task3_mvc_ss.Models;

namespace task3_mvc_ss.Controllers
{
    public class infoController : Controller
    {
        // GET: info
        public ActionResult Index(info myinfo)
        {
            if (!string.IsNullOrEmpty(myinfo.but1))
            {
                Response.Write("First name :" +myinfo.but1);
            }
            if (!string.IsNullOrEmpty(myinfo.but2))
            {
                Response.Write("First name :" + myinfo.but2);
            }
            return View();
        }

    }
}