using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRockStar_21102021.Models
{
    public class DepartmentModel
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }

    public class EmpDept
    {
        public List<EmployeeModel> Emp { get; set; }
        public List<DepartmentModel> dept { get; set; }
    }
}