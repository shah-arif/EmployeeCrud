// UnitOfWork.cs
using EmployeeCrud.Data;
using EmployeeCrud.Repositories.Implement;
using EmployeeCrud.Repositories.Interface;

namespace EmployeeCrud.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Employees = new EmployeeRepository(_dbContext);
        }

        public IEmployeeRepository Employees { get; }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
