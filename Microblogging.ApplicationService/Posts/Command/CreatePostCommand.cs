


namespace Microblogging.ApplicationService.Posts.Command;

//This is the request for Hanlder
public record CreatePostCommand(PostDto posts, IFormFile file,int userId) : IRequest<bool>
{

}