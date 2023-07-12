using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features;


public class GetAllUsersMapper : Profile
{
    public GetAllUsersMapper()
    {
        CreateMap<GetAllUsersResponse, User>().ReverseMap();
        CreateMap<GetUserRequest, User>().ReverseMap();
    }
}