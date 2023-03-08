using Microsoft.EntityFrameworkCore;
using RR.Domain.DbMapping;
using RR.Domain.DbModels;

namespace RR.Domain.DbContexts
{
    public class RRDbContext : DbContext
    {
        public RRDbContext(DbContextOptions<RRDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeMapper());
            modelBuilder.ApplyConfiguration(new DepartmentMapper());
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
