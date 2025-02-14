
namespace Microblogging.API.Controllers;

[Route(LoginQueryHandler.ApiRoute)]
[ApiController]
public class AuthController(ISender sender) : ControllerBase
{

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginModelRequest userRequest, CancellationToken cancellationToken)
    {
        var user = await sender.Send(new LoginQuery(userRequest), cancellationToken);
        if (!string.IsNullOrEmpty(user))
            return Ok(new { Token = user });
        return Unauthorized();
    }
}
