using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features;


public class GetUserMapper : Profile
{
    public GetUserMapper()
    {
        CreateMap<GetUserResponse, User>().ReverseMap();
        CreateMap<GetUserRequest, User>().ReverseMap();
    }
}