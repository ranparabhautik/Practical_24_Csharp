using EmployeeManagement.DAL.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.DAL.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Department>().HasData(

                new Department { Id = 1, DName = "IT" },
                new Department { Id = 2, DName = "HR" },
                new Department { Id = 3, DName = "Sales" }

                );
        }
    }
}
