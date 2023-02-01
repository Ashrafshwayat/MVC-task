using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_2023.Controllers
{
    public class OPPPController : Controller
    {
        // GET: OPPP
        public ActionResult Index()
        {
            
            List<customer> OB = new List<customer>()
            {
                new customer
                {
                    Id= 1,
                    Name="ASHRAFshwayat",
                    Address="kkkkk",
                    Age="25"
                }

            };
            ViewBag.O = OB;    
            return View();
        }
    }
}