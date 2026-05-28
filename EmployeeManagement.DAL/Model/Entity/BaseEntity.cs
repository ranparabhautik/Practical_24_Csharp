using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Model.Entity
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}

