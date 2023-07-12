using AutoMapper;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Application.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features;

public class CreateUserHandler : IRequestHandler<CreateUserRequest>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public CreateUserHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task Handle(CreateUserRequest request, CancellationToken cancellationToken)
    {
        var userToCreate = mapper.Map<User>(request);
        await unitOfWork.UserRepository.CreateUser(userToCreate);
        await unitOfWork.SaveAsync();
    }
}
