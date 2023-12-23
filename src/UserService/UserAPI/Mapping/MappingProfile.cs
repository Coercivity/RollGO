using AutoMapper;
using Domain.Entities;
using UserAPI.DTOs;

namespace UserAPI.Mapping;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDto>();
        CreateMap<UserDto, User>();
    }
}