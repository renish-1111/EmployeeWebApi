namespace EmployeeWebApi.Models.Entities
{
    public class Employee
    {
        public Employee()
        {
        }

        public Employee(Guid id, string name, string email, string phone, decimal salary)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            Salary = salary;
        }
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }
        public decimal Salary { get; set; }
    }
}
