using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRockStar_21102021.Models
{

    public class CustomFilter : ActionFilterAttribute
    {
        //1 method
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
        }

        //2nd
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
        }

        //4th
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
        }

        //3rd
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            (filterContext.Result as ViewResult).ViewBag.Player = "Virat kohli";
            var result = (EmployeeModel)(filterContext.Result as ViewResult).Model;
            if (result != null)
            {
                result.EmpId = 2;
                result.EmpName = "Chakradhar";
                result.EmpSalary = 210000;

            }
        }

    }
}