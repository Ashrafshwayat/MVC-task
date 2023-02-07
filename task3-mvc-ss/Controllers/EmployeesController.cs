using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using task3_mvc_ss.Models;

namespace task3_mvc_ss.Controllers
{
    public class EmployeesController : Controller
    {
        private task3Entities db = new task3Entities();

        // GET: Employees
        public ActionResult Index(string searchBy, string search)
        {
          if(searchBy== "First Name")
            {
                var result = db.Employees.Where(x=>x.First_Name.Contains(search) || search==null).ToList(); 
                return View(result);
            }
            else
            {
               return View(db.Employees.Where(x => x.Last_name.Contains(search) || search == null).ToList());
            }
        }

        //public ActionResult Order()
        //{
        //    return View();
        //}

        public PartialViewResult _Order()
        {
            var d = db.orders.OrderByDescending(c => c.OrderDate).FirstOrDefault();
            return PartialView("_Order", d);
        }


        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,First_Name,Last_name,E_mail,Phone,Age,Job_Title,Gender,imge,CV")] Employee employee, HttpPostedFileBase imge, HttpPostedFileBase CV)
        {
            if (ModelState.IsValid)
            {
                if (imge != null && imge.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(imge.FileName);
                    var path = Path.Combine(Server.MapPath("~/images"), fileName);
                    imge.SaveAs(path);
                    employee.imge = fileName;
                }
                if (CV != null && CV.ContentLength > 0)
                {
                    var fileName = CV.FileName;
                    var path = Path.Combine(Server.MapPath("~/CV"), fileName);
                    CV.SaveAs(path);
                    employee.CV = fileName;
                }

                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,First_Name,Last_name,E_mail,Phone,Age,Job_Title,Gender,imge,CV")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
       
    }
}
