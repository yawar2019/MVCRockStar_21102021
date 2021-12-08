using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstApproach.Models
{
    public class RegisterationModel
    {
        public int EmpId { get; set; }
        [Required(ErrorMessage ="EmpName Cannot be Empty")]
        public string  EmpName { get; set; }
        [Required(ErrorMessage = "Password Cannot be Empty")]
        public string Password { get; set; }
        [Required(ErrorMessage = "ConfirmPassword Cannot be Empty")]
        [Compare("Password",ErrorMessage ="Pwd and CPwd Not Matches")]
        public string ConfirmPassword { get; set; }
        [Range(10000,50000,ErrorMessage ="Salary should between 10000 to 50000")]
        public int EmpSalary { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [StringLength(10,ErrorMessage ="More then 10not allowed")]
        public string Address { get; set; }
    }
}