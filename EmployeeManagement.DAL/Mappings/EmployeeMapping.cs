using AutoMapper;
using EmployeeManagement.DAL.Model.DTOs;
using EmployeeManagement.DAL.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Mappings
{
    public class EmployeeMapping : Profile
    {
        public EmployeeMapping()
        {
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
        }
    }

}