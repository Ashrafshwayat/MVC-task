using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_2023.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        //public string Index() 
        // {
        //     return "<a href='https://localhost:44363/Default/DownloadImage'><img style=\"width :50px\" src='img/el-salvador.png'/></a>"; 

        // }

        //   public ActionResult DownloadImage()
        //{
        //    var filePath = Server.MapPath("~/img/el-salvador.png");
        //    return File(filePath,"png","el-salvador");
        //}

        public string Index() {

            return ("<a download style=\"width :50px\" href='../img/el-salvador.png'><img src='../img/el-salvador.png'/></a>");
        }
        public string About()
        {
            return "About";
        }
        public string coun()
        {
            return "coun";
        }
    }

}