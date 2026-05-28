using EmployeeManagement.DAL.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Service
{
    public interface IEmployeeService
    {

        Task<object> GetEmployee(int? id);
        Task CreateEmployee(EmployeeDTO dto);
        Task UpdateEmployee(EmployeeDTO dto);
        Task DeleteEmployee(int id);
    }
}
