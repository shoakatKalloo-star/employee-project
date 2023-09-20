using Domain.Models;
using EmployeeDataAccess.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;


namespace EmployeeDataAccess.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private AppDbContext dbContext;

        public EmployeeRepository()
        {
            dbContext = new AppDbContext(null);

        }

        public Employee Add(Employee employee)
        {
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();
            return employee;
        }

        public Manager Add(Manager manager)
        {
            dbContext.Managers.Add(manager);
            dbContext.SaveChanges();
            return manager;
        }

        public Supervisor Add(Supervisor supervisor)
        {
            dbContext.Supervisors.Add(supervisor);
            dbContext.SaveChanges();
            return supervisor;
        }

        public List<Employee> GetEmployees()
        {
            return dbContext.Employees.ToList();
        }

        List<Manager> IEmployeeRepository.GetManagers()
        {
            return dbContext.Managers.ToList();
        }



        List<Supervisor> IEmployeeRepository.GetSupervisors()
        {
            return dbContext.Supervisors.ToList();
        }
    }

}
