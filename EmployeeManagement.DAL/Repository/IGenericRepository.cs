using EmployeeManagement.DAL.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Repository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(int id);
    }
}
