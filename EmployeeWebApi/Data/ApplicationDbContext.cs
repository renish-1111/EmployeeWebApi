using Microsoft.EntityFrameworkCore;
using EmployeeWebApi.Models.Entities;

namespace EmployeeWebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

        internal object Find(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
