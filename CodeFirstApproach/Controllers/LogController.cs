using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApproach.Controllers
{
    public class LogController : Controller
    {
        // GET: Log
        public ActionResult Index()
        {
            try
            {
                int a = 10, b = 0;
                int c = a / b;
            }
            catch(Exception ex)
            {
                Log(ex);
            }
            return View();
        }
        public void Log(Exception ex)
        {
            string message = string.Format("Time:{0}", DateTime.Now);
            message += string.Format("Message", ex.Message);
            string path = Server.MapPath("~/Errorlog/ErrorLog.txt");
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(message);
            writer.Close();
        }
    }
}