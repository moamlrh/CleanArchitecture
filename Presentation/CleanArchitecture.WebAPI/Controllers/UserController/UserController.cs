using MediatR;
using Microsoft.AspNetCore.Mvc;
using CleanArchitecture.Application.Features;
namespace CleanArchitecture.WebApi.Controllers;
[ApiController]
[Route("/api/users")]
public class UserController : ControllerBase
{
    private readonly IMediator mediator;
    public UserController(IMediator _mediator)
    {
        mediator = _mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetUser([FromQuery] GetUserRequest request)
    {
        var user = await mediator.Send(request);
        return Ok(user);
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request)
    {
        await mediator.Send(request);
        return Ok();
    }
}