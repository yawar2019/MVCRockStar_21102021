using MVCRockStar_21102021.scripts.Models;
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
        EmployeeEntities db = new EmployeeEntities();
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

        [Authorize]
        public ActionResult DashBoard()
        {
            return View();
        }

        [Authorize]
        public ActionResult ContactUs()
        {
            return View();
        }
        [Authorize]
        public ActionResult AboutUs()
        {
            return View();
        }

    }
}