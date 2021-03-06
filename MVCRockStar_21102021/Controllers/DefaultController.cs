using MVCRockStar_21102021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRockStar_21102021.Controllers
{
    public class DefaultController : Controller
    {

        // GET: Default
        [MVCRockStar_21102021.Models.CustomFilter]
       public ViewResult GetId()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Riyan";
            emp.EmpSalary = 21000;

            ViewBag.Player = "Rohit Sharma";


            return View(emp);
        }
        public int GetNumber()
        {
            return 1211;
        }

        public ActionResult GetMeView()
        {
            return View("jungle");
        }

        public ActionResult GetToHotel()
        {
            return View("~/Views/New/RamaeInternational.cshtml");
        }

        public string getEmployeeId(int? eid)
        {
            return "My Employee Id "+eid;
        }

        public string testTime(int? id)
        {
            return "hello " + id;
        }

        public string testTime2(int? id,string Name)
        {
            return "hello " + id+" My Name is "+Name;
        }
        public string testTime3(int? id)
        {
            return "hello " + id + " My Name is " + Request.QueryString["Name"]+" Designation " + Request.QueryString["Designation"];
        }

        //[NonAction]
        private string GetEmployeeInfo()
        {
            
            ViewBag.EmployeeName = "Preeti";
            return "preeti";
        }

        public ActionResult GetEmployeeInfo2()
        {
            string Name = GetEmployeeInfo();
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = Name;
            obj.EmpSalary = 21000;

            ViewBag.Employee = obj;

            return View();
        }

        public ActionResult GetEmployeeInfo3()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Preeti";
            obj.EmpSalary = 21000;


            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Divya";
            obj1.EmpSalary = 22000;


            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Tajun";
            obj2.EmpSalary = 23000;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);


            ViewBag.Employee = listObj;

            return View();
        }

        public ActionResult MethodByViewModel()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Preeti";
            obj.EmpSalary = 21000;

            return View(obj);
        }

        public ActionResult GetEmployeeInfo4()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Preeti";
            obj.EmpSalary = 21000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Divya";
            obj1.EmpSalary = 22000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Tajun";
            obj2.EmpSalary = 23000;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);
            
            return View(listObj);
        }

        public ViewResult GetEmployeeInfo5()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Preeti";
            obj.EmpSalary = 21000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Divya";
            obj1.EmpSalary = 22000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Tajun";
            obj2.EmpSalary = 23000;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);

            ///End of Employee
            ///
            DepartmentModel dept = new Models.DepartmentModel();
            dept.DeptId = 1;
            dept.DeptName = "IT";

            DepartmentModel dept1 = new Models.DepartmentModel();
            dept1.DeptId = 2;
            dept1.DeptName = "Network";

            List<DepartmentModel> listDept = new List<DepartmentModel>();
            listDept.Add(dept);
            listDept.Add(dept1);
            //End of Dept

            EmpDept empdept = new Models.EmpDept();
            empdept.Emp = listObj;
            empdept.dept = listDept;

            return View(empdept);
        }

        public ViewResult getMepartialViewEx()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Preeti";
            obj.EmpSalary = 21000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Divya";
            obj1.EmpSalary = 22000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Tajun";
            obj2.EmpSalary = 23000;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);

            return View(listObj);
        }

        public PartialViewResult getMepartialViewEx2()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Preeti";
            obj.EmpSalary = 21000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Divya";
            obj1.EmpSalary = 22000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Tajun";
            obj2.EmpSalary = 23000;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);

            return PartialView("_MyPartialView",listObj);
        }

        public JsonResult TestResult(int? id)
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Preeti";
            obj.EmpSalary = 21000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Divya";
            obj1.EmpSalary = 22000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Tajun";
            obj2.EmpSalary = 23000;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);

            return Json(listObj,JsonRequestBehavior.AllowGet);
        }

        public RedirectResult GotoUrl()
        {

            return Redirect("http://www.google.com");
        }

        public RedirectResult GotoUrl2(int ? id)
        {

            return Redirect("~/Default/TestResult?id=1");
        }

        public RedirectToRouteResult GotoUrl3()
        {
            return RedirectToAction("GotoUrl2","Default");
        }

        public RedirectToRouteResult GotoUrl4()
        {
            return RedirectToAction("GotoUrl2", "Default",new {id=1 });
        }
        public ViewResult GetData(EmployeeModel emp)
        {

            return View();
        }
        public RedirectToRouteResult GotoUrl4(EmployeeModel emp)
        {
            return RedirectToAction("GotoUrl2", "Default", new { id = 1 });
        }

        public RedirectToRouteResult GotoUrl5()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Preeti";
            obj.EmpSalary = 21000;

            return RedirectToAction("GetData", "Default", obj);
        }

        public RedirectToRouteResult GotoUrl6()
        {
            return RedirectToRoute("Default22");
        }

        public FileResult getMeFileData()
        {
            return File("~/Web.config", "text/plain");
        }

        public FileResult getMeFileData2()
        {
            return File("~/WithConversionOptions.pdf", "application/pdf");
        }
        public FileResult getMeFileData3()
        {
            return File("~/Web.config", "application/xml","myweb");
        }

        public ContentResult DifferentContent(int? id)
        {
            if (id == 1) {
                return Content("Hello World");
            }
            else if (id == 2) {
                return Content("<p style=color:red>Hello World</p>");
            }
            else {
                return Content("<script>alert('Hello World')</script>");
            }
        }



    }
}