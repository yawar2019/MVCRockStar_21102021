using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace CodeFirstApproach.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext():base("ConStr")
        { }

        public DbSet<Employee> Employees { get; set; }//Table
        public DbSet<Department> Departments { get; set; }//Table
    }
}