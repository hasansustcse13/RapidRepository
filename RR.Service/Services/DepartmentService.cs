using RR.Domain.DbModels;
using RR.Domain.Repositories;
using RR.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RR.Service.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IRepository<Department> _repository;

        public DepartmentService(IRepository<Department> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Department>> GetAllDepartmentsAsync()
        {
            return await _repository.GetAll();
        }

        public async Task<Department> InsertDepartmentAsync(Department department)
        {
            await _repository.Insert(department);
            await _repository.SaveChangesAsync();
            return department;
        }
    }
}
