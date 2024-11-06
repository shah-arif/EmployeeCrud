// IUnitOfWork.cs

// IUnitOfWork.cs
using EmployeeCrud.Repositories.Interface;

namespace EmployeeCrud.Repositories
{
    public interface IUnitOfWork
    {
        IEmployeeRepository Employees { get; }
        void Save();
    }
}
