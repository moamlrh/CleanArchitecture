using MediatR;
using Microsoft.AspNetCore.Mvc;
using CleanArchitecture.Application.Features;
namespace CleanArchitecture.WebApi.Controllers;
[ApiController]
[Route("/api/users")]
public class UserController : ControllerBase
{
    private readonly ISender _sender;
    public UserController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    public async Task<IActionResult> GetUser([FromQuery] GetUserRequest request)
    {
        var user = await _sender.Send(request);
        return Ok(user);
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request)
    {
        await _sender.Send(request);
        return Ok();
    }
}