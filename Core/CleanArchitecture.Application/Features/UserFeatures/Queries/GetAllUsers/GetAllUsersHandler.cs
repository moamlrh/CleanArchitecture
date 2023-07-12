using AutoMapper;
using CleanArchitecture.Application.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features;

public class GetAllUsersHandler : IRequestHandler<GetAllUsersRequest, IEnumerable<GetAllUsersResponse>>
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;

    public GetAllUsersHandler(IMapper mapper, IUnitOfWork unitOfWork)
    {
        this.mapper = mapper;
        this.unitOfWork = unitOfWork;
    }
    public async Task<IEnumerable<GetAllUsersResponse>> Handle(GetAllUsersRequest request, CancellationToken cancellationToken)
    {
        // var users = await unitOfWork.UserRepository.GetAll();
        // var usersResponse = mapper.Map<IEnumerable<GetAllUsersResponse>>(users);
        // return usersResponse;
        return null;
    }
}
