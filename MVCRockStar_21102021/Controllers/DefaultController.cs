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
       public string GetId()
        {
            return "hello";
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
    }
}