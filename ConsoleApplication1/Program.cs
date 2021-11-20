using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new[] { 100, 200, 300, 400, 500 };

            //var sal = from a in arr
            //          where a > 200
            //          select a;
            //foreach (var item in sal)
            //{
            //    Console.WriteLine(item);
            //}

            EmployeeModel emp = new ConsoleApplication1.EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "james";
            emp.EmpSalary = 3000;

            EmployeeModel emp1 = new ConsoleApplication1.EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "james1";
            emp1.EmpSalary =1000;

            EmployeeModel emp2 = new ConsoleApplication1.EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "james2";
            emp2.EmpSalary = 2000;

            List<EmployeeModel> listemp = new List<EmployeeModel>();
            listemp.Add(emp);
            listemp.Add(emp1);
            listemp.Add(emp2);

            var emplist = from empinfo in listemp
                          where empinfo.EmpSalary > 1000
                          select empinfo;
            foreach (var item in emplist)
            {
                Console.WriteLine(item.EmpId);
                Console.WriteLine(item.EmpName);
                Console.WriteLine(item.EmpSalary);
            }
            Console.ReadLine();
        }
    }

    internal class EmployeeModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
    }
}
