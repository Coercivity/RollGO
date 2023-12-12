using AutoMapper;
using Domain.Entities;
using UserAPI.Controllers.Dtos;

namespace UserAPI.Mapping;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDto>();
    }
}