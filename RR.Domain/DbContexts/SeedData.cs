using Microsoft.EntityFrameworkCore;
using RR.Domain.DbModels;

namespace RR.Domain.DbContexts
{
    internal static class SeedData
    {
        internal static void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "HR" },
                new Department { Id = 2, Name = "QA" }
            );
        }
    }
}
