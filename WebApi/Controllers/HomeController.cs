using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Net;
using WebApiServices.Services.Interfaces;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {


        private readonly ILogger<HomeController> _logger;

        private readonly IEmployeeService _empService;

        public HomeController(ILogger<HomeController> logger, IEmployeeService empService)
        {
            _logger = logger;
            _empService = empService;
        }

        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            List<Employee> emps = _empService.GetEmployees();
            return emps;

        }

        [HttpGet]
        public IEnumerable<Manager> GetManagers()
        {
            List<Manager> managers = _empService.GetManagers();
            return managers;

        }

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IEnumerable<Supervisor> GetSupervisors()
        {
            List<Supervisor> supervisors = _empService.GetSupervisors();
            return supervisors;

        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public void AddEmployee([FromBody] Employee emp)
        {

            Employee employee = _empService.Add(emp);




        }


        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public void AddManager([FromBody] Manager manager)
        {

            Manager mgr = _empService.Add(manager);



        }


        [HttpPost]
        public void AddSupervisor([FromBody] Supervisor superviosr)
        {

            Supervisor super = _empService.Add(superviosr);




        }
    }
}
