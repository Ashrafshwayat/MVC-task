using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using taskMvc_2_1_2023.Models;

namespace taskMvc_2_1_2023.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {

            List<Student> students = new List<Student>();

            students.Add(new Student() { Id = 1, Name = "Ashraf", Major = "math", Faclity = "math2" });

            students.Add(new Student() { Id = 2, Name = "Odat", Major = "engineer", Faclity = "engineer" });

            students.Add(new Student() { Id = 3, Name = "Malik", Major = "islamic law", Faclity = "islamic" });
           
            return View(students);

        }
    }
}