

namespace Microblogging.ApplicationService.Posts.Command;


public class CreatePostCommandHandler(IPostService _postService) : IRequestHandler<CreatePostCommand, bool>
{

    public const string ApiRoute = "api/V1/CreatePost";

    public async Task<bool> Handle(CreatePostCommand req, CancellationToken cancellationToken)
    {
        var post = await _postService.CreatePostAsync(req.posts, req.file, req.userId);
        return true;
    }
}
