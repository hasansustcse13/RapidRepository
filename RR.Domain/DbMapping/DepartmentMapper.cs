using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RR.Domain.DbModels;

namespace RR.Domain.DbMapping
{
    internal class DepartmentMapper : BaseMapper<Department>
    {
        public override void Configure(EntityTypeBuilder<Department> builder)
        {
            base.Configure(builder);
            builder.ToTable("Department");
            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
        }
    }
}
