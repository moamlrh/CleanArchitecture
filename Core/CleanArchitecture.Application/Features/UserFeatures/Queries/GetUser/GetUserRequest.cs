using MediatR;

namespace CleanArchitecture.Application.Features;

public record GetUserRequest(Guid Id) : IRequest<GetUserResponse>;