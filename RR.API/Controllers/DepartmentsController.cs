using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RR.API.DTOs;
using RR.Domain.DbModels;
using RR.Service.Interfaces;
using System.Threading.Tasks;

namespace RR.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        private readonly IMapper _mapper;

        public DepartmentsController(IMapper mapper, IDepartmentService departmentService)
        {
            _mapper = mapper;
            _departmentService = departmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var departments = await _departmentService.GetAllDepartmentsAsync();
            return Ok(_mapper.Map<DepartmentDto[]>(departments));
        }

        [HttpPost]
        public async Task<IActionResult> InsertAsync(DepartmentDto dto)
        {
            var department = _mapper.Map<Department>(dto);
            await _departmentService.InsertDepartmentAsync(department);
            dto.Id = department.Id;
            return Ok(dto);
        }
    }
}
