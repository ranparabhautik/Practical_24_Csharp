using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Model.Entity
{
    public class Employee:BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public DateTime JoiningDate { get; set; } = DateTime.Now;
        public bool Status { get; set; } = true;
        public int DeptId { get; set; }
    }
}
