using EmployeeCrud.Models.Entities;

namespace EmployeeCrud.Models
{
    public class AddEmployeeDto
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }
        public decimal Salary { get; set; }
        public string CompanyId { get; set; } = string.Empty;
        public Company? Company { get; set; }
        

    }
}
