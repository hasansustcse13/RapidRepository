using RR.Domain.DbModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RR.Service.Interfaces
{
    public interface IDepartmentService
    {
        Task<Department> InsertDepartmentAsync(Department department);
        Task<IEnumerable<Department>> GetAllDepartmentsAsync();
    }
}
