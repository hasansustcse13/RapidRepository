using AutoMapper;
using RR.API.DTOs;
using RR.Domain.DbModels;

namespace RR.API.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Department, DepartmentDto>()
                .ReverseMap();
        }
    }
}
