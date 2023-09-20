using Domain.Models;
using System.Collections.Generic;


namespace EmployeeDataAccess.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();

        List<Manager> GetManagers();

        List<Supervisor> GetSupervisors();

        Employee Add(Employee employee);

        Manager Add(Manager Manager);


        Supervisor Add(Supervisor supervisor);
    }
}
