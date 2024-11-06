// EmployeeRepository.cs
using EmployeeCrud.Data;
using EmployeeCrud.Models.Entities;
using EmployeeCrud.Repositories.Interface;

namespace EmployeeCrud.Repositories.Implement
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public EmployeeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _dbContext.Employees.ToList();
        }

        public Employee? GetEmployeeById(Guid id)
        {
            return _dbContext.Employees.Find(id);
        }

        public void AddEmployee(Employee employee)
        {
            _dbContext.Employees.Add(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            _dbContext.Employees.Update(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            _dbContext.Employees.Remove(employee);
        }
    }
}
