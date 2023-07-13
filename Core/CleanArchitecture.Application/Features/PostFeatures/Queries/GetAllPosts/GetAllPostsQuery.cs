using MediatR;
using CleanArchitecture.Domain.Dtos;

namespace CleanArchitecture.Application.Features;

public record GetAllPostsQuery() : IRequest<IEnumerable<PostDto>>;