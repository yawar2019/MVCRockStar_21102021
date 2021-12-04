using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstApproach.Models;
using System.Data.Entity;

namespace CodeFirstApproach.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        private readonly EmployeeContext db = new EmployeeContext();
        public ActionResult GetEmployees()
        {
            return View(db.Employees.ToList());
        }

        public ActionResult GetDepartments()
        {
            return View(db.Departments.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            db.Employees.Add(emp);//insert query,add is predefined method
            int result = db.SaveChanges();//Execute query
            if (result > 0)
            {
                return RedirectToAction("GetEmployees");
            }  
            
            return View();
        }

        public ActionResult Edit(int? id)
        {
            Employee emp = db.Employees.Find(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            db.Entry(emp).State=EntityState.Modified;//Update query,add is predefined method

            int result = db.SaveChanges();//Execute query
            if (result > 0)
            {
                return RedirectToAction("GetEmployees");
            }

            return View();
        }
        public ActionResult Delete(int? id)
        {
            Employee emp = db.Employees.Find(id);
            return View(emp);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            Employee emp = db.Employees.Find(id);

            db.Employees.Remove(emp);
            int result = db.SaveChanges();//Execute query
            if (result > 0)
            {
                return RedirectToAction("GetEmployees");
            }

            return View();
        }

        public ActionResult UserDefinedControls()
        {
            return View();
        }

        public JsonResult getjsondata()
        {
            Employee emp = new Employee();
            emp.EmpId = 1;
            emp.EmpName = "test";
            emp.EmpSalary = 21000;

            return Json(emp,JsonRequestBehavior.AllowGet);
        }
    }
}