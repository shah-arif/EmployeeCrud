using EmployeeCrud.Models;
using EmployeeCrud.Models.Entities;
using EmployeeCrud.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var allEmployees = _unitOfWork.Employees.GetAllEmployees();
            return Ok(allEmployees);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetEmployeeById(Guid id)
        {
            var employee = _unitOfWork.Employees.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto)
        {
            var employeeEntity = new Employee
            {
                Name = addEmployeeDto.Name,
                Email = addEmployeeDto.Email,
                Phone = addEmployeeDto.Phone,
                Salary = addEmployeeDto.Salary,
                CompanyId = addEmployeeDto.CompanyId,
                Company = addEmployeeDto.Company,
            };

            _unitOfWork.Employees.AddEmployee(employeeEntity);
            _unitOfWork.Save();

            return Ok(employeeEntity);
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdateEmployee(Guid id, UpdateEmployeeDto updateEmployeeDto)
        {
            var employee = _unitOfWork.Employees.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound();
            }

            employee.Name = updateEmployeeDto.Name;
            employee.Email = updateEmployeeDto.Email;
            employee.Phone = updateEmployeeDto.Phone;
            employee.Salary = updateEmployeeDto.Salary;

            _unitOfWork.Employees.UpdateEmployee(employee);
            _unitOfWork.Save();

            return Ok(employee);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteEmployee(Guid id)
        {
            var employee = _unitOfWork.Employees.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound();
            }

            _unitOfWork.Employees.DeleteEmployee(employee);
            _unitOfWork.Save();

            return Ok();
        }
    }
}