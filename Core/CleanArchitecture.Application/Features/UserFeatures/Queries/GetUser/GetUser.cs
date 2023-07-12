using AutoMapper;
using CleanArchitecture.Application.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features;

public class GetUser : IRequestHandler<GetUserRequest, GetUserResponse>
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;

    public GetUser(IMapper mapper, IUnitOfWork unitOfWork)
    {
        this.mapper = mapper;
        this.unitOfWork = unitOfWork;
    }

    public async Task<GetUserResponse> Handle(GetUserRequest request, CancellationToken cancellationToken)
    {
        var user = await unitOfWork.UserRepository.GetUserById(request.Id);
        return mapper.Map<GetUserResponse>(user);
    }
}
