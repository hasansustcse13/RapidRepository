using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RR.Domain.DbModels;

namespace RR.Domain.DbMapping
{
    internal class EmployeeMapper : BaseMapper<Employee>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            base.Configure(builder);
            builder.ToTable("Employee");
            builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();

            builder.HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
