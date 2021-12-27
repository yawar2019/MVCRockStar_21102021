using MVCRockStar_21102021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCRockStar_21102021.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        EmployeeEntities1 db = new EmployeeEntities1();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserDetail user)
        {
            var result = db.UserDetails.Where(s => s.UserName == user.UserName && s.Password == user.Password).SingleOrDefault();
            if (result != null)
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return Redirect("~/Login/DashBoard");
            }
            else
            {
                ViewBag.msg = "Invalid UserName/PassWord";
            }
            return View();
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("~/Login/Login");
        }

        [Authorize(Roles ="Admin,Manager")]
        public ActionResult DashBoard()
        {
            return View();
        }

        [Authorize(Roles="Admin")]
        public ActionResult ContactUs()
        {
            return View();
        }
        [Authorize(Roles = "Manager")]
        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult ConsumeService()
        {
            ServiceReference1.WebService1SoapClient obj = new ServiceReference1.WebService1SoapClient();
         string result=   obj.Add(10, 12).ToString();
            return Content(result);
        }


    }
}