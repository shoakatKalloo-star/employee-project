using Domain.Models;
using EmployeeDataAccess.Repository.Interfaces;
using System.Collections.Generic;
using WebApiServices.Services.Interfaces;

namespace WebApiServices.Services
{
    public class EmployeeService : IEmployeeService
    {

        public IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee Add(Employee employee)
        {
            var empl = _employeeRepository.Add(employee);
            return empl;
        }

        public Manager Add(Manager Manager)
        {
            var manager = _employeeRepository.Add(Manager);
            return manager;
        }

        public Supervisor Add(Supervisor supervisor)
        {
            var supervisory = _employeeRepository.Add(supervisor);
            return supervisory;
        }

        public List<Employee> GetEmployees()
        {
            var employees = _employeeRepository.GetEmployees();
            return employees;
        }

        public List<Manager> GetManagers()
        {
            var managers = _employeeRepository.GetManagers();
            return managers;
        }

        public List<Supervisor> GetSupervisors()
        {

            var superviosors = _employeeRepository.GetSupervisors();
            return superviosors;
        }
    }
}
