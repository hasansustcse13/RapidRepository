using System.Collections.Generic;

namespace RR.Domain.DbModels
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
