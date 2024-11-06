// IEmployeeRepository.cs

// IEmployeeRepository.cs
using EmployeeCrud.Models.Entities;

namespace EmployeeCrud.Repositories.Interface
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee? GetEmployeeById(Guid id);
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
    }
}




//using EmployeeCrud.Models.Entities;

//namespace EmployeeCrud.Repositories
//{
//    public interface IEmployeeRepository
//    {
//        IEnumerable<Employee> GetAllEmployees();
//        Employee? GetEmployeeById(Guid id);
//        Employee AddEmployee(Employee employee);
//        Employee? UpdateEmployee(Employee employee);
//        bool DeleteEmployee(Guid id);
//    }
//}

