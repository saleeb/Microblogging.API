


namespace Microblogging.API.Controllers;

[ApiController]
public class PostsController(ISender _sender, UserManager<UserMaster> _userManager) : ControllerBase
{

    [Authorize]
    [HttpPost]
    [Route(CreatePostCommandHandler.ApiRoute)]
    [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<bool>> CreatePost(PostDto posts, IFormFile File)
    {
        var currentUserDetails = await _userManager.GetUserAsync(User);

        if (currentUserDetails is not null)
            return Unauthorized();


        return Ok(await _sender.Send(new CreatePostCommand(posts, File, currentUserDetails!.UserId)));
    }


    [Authorize]
    [HttpPost]
    [Route(CreatePostCommandHandler.ApiRoute)]
    [ProducesResponseType(typeof(List<PostsViewModel>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<List<PostsViewModel>>> Timeline()
    {
        var currentUserDetails = await _userManager.GetUserAsync(User);

        if (currentUserDetails is not null)
            return Unauthorized();


        return Ok(await _sender.Send(new GetTimeLineReqest(currentUserDetails!.UserId)));
    }
}
