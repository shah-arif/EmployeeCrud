using EmployeeCrud.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCrud.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
