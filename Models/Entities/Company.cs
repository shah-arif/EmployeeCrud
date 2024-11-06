namespace EmployeeCrud.Models.Entities
{
    public class Company
    {
        public string Id { get; set; } = string.Empty;
        public required string Name { get; set; }
        public required string Address { get; set; }
    }
}
