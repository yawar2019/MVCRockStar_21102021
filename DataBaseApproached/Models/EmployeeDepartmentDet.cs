using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBaseApproached.Models
{
    public class EmployeeDepartmentDet
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
        public string DeptName { get; set; }
    }
}