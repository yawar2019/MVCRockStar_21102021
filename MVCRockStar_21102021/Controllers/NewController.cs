using MVCRockStar_21102021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRockStar_21102021.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult RamaeInternational()
        {
            return View();
        }

        [HttpPost]
        [MVCRockStar_21102021.Models.CustomFilter]
        public ActionResult RamaeInternational(EmployeeModel emp)
        {
            return View();
        }
    }
}