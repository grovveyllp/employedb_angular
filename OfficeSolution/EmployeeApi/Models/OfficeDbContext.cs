using Microsoft.EntityFrameworkCore;

namespace EmployeeApi.Models
{
    public sealed class OfficeDbContext : DbContext
    {
        public OfficeDbContext(DbContextOptions<OfficeDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
