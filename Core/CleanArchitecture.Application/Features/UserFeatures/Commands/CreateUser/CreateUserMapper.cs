using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features;


public class CreateUserMapper : Profile
{
    public CreateUserMapper()
    {
        CreateMap<CreateUserRequest, User>().ReverseMap();
        CreateMap<CreateUserResponse, User>().ReverseMap();
    }
}