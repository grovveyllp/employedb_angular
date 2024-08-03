
using EmployeeApi.Models;
using EmployeeApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetEmployees()
        {
            var employees = _employeeRepository.GetEmployees();
            return Ok(employees);
        }

        [HttpGet]
        [Route("id")]
        public IActionResult GetEmployee(int id)
        {
            var employee = _employeeRepository.GetEmployee(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(Employee employee)
        {
            return Ok(employee);
        }

        [HttpPost]
        [Route("update")]
        public IActionResult Update(int id)
        {
            var employee = new Employee();
            return Ok(employee);
        }
    }
}
