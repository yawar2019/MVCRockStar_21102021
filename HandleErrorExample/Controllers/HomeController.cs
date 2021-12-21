using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandleErrorExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(int id)
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HandleError(View ="MyFavoriteError")]
        public ActionResult HandleExceptionExample(string id)
        {
            int a = 10; int b = Convert.ToInt32(id);
            int c = (b/a);
            return Content(c.ToString());
        }
    }
}