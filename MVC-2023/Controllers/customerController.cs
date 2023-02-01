using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_2023.Models;

namespace MVC_2023.Controllers
{
    public class customerController : Controller
    {

        Entities ob = new Entities();
        // GET: customer
        public ActionResult DisplayCustomer()
           
        {
            List<string> country = new List<string>()
            {"jordan",
            "palastine",
            "qatar"

            };
            Session["username"] = "ashraf";
            ViewBag.c = country;
            
            return View();

            //var Customer = new Customer(1, "ashraf", "ajloun", "24");
            //return View(Customer);
        }
        public ActionResult Search() {  

            return View();  
        }
       
        public ActionResult info()
        {
            List<City> list = ob.Citys.ToList();
            return View(list);
        }
        
    }
}