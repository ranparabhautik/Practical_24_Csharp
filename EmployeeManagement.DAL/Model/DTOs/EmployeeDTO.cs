using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Model.DTOs
{
    public class EmployeeDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int DeptId { get; set; }
        public string Email { get; set; }
    }
}
