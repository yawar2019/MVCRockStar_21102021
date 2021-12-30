using AdoNet.Models;
using System;
using System.Collections;
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
            ViewBag.ddlEmployee = new SelectList(db.GetEmployees(), "EmpId", "EmpName");
            return View(emp);
        }
        [HttpPost]
        public ActionResult HtmlHelperExample(string username,string pwd,bool agreement,string gender,string country)
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpName = "Divya";
            ViewBag.userinfo = username+","+pwd+","+agreement+","+gender+","+ country;
            return View(emp);
        }

        public ActionResult ConsumeWcfService()
        {
            ServiceReference1.Service1Client s1 = new ServiceReference1.Service1Client("NetTcpBinding_IService1");
            var result=s1.GetData(12).ToString();
            return Content(result);
        }
    }
}