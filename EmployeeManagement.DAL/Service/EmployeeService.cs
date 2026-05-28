using AutoMapper;
using EmployeeManagement.DAL.Model.DTOs;
using EmployeeManagement.DAL.Model.Entity;
using EmployeeManagement.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IGenericRepository<Employee> _repo;
        private readonly IMapper _mapper;
        public EmployeeService(IGenericRepository<Employee> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateEmployee(EmployeeDTO dto)
        {
            var employee = _mapper.Map<Employee>(dto);
            await _repo.Create(employee);
        }

        public async Task DeleteEmployee(int id)
        {
            await _repo.Delete(id);
        }

        public async Task<object> GetEmployee(int? id)
        {
            if (id.HasValue)
            {
                return await _repo.GetById(id.Value);
            }
            return await _repo.GetAll();
        }

        public async Task UpdateEmployee(EmployeeDTO dto)
        {
            var employee = await _repo.GetById(dto.Id);
            _mapper.Map(dto, employee);
            await _repo.Update(employee);
        }
    }
}
