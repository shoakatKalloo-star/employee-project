using Domain.Models;
using System.Collections.Generic;

namespace WebApiServices.Services.Interfaces
{
    public interface IEmployeeService
    {

        List<Employee> GetEmployees();

        List<Manager> GetManagers();

        List<Supervisor> GetSupervisors();

        Employee Add(Employee employee);

        Manager Add(Manager Manager);


        Supervisor Add(Supervisor supervisor);
    }
}
