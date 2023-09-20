using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDataAccess
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Supervisor> Supervisors { get; set; }
    }
}
