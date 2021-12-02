using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdoNet.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext db = new Models.EmployeeContext();

        // GET: Employee
        public ActionResult Index()
        {
            return View(db.GetEmployees());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            int i = db.SaveEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int?id)
        {
            EmployeeModel emp = db.GetEmployeesById(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            int i = db.UpdateEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            EmployeeModel emp = db.GetEmployeesById(id);
            return View(emp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
            int i = db.DeleteEmployee(id);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult HtmlHelperExample()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpName = "Divya";
            return View(emp);
        }
        [HttpPost]
        public ActionResult HtmlHelperExample(string username)
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpName = "Divya";
            ViewBag.userName = username;
            return View(emp);
        }
    }
}