

namespace Microblogging.Domain.Servicies.Post;

public interface IPostService
{
    Task<Entities.Post> CreatePostAsync(PostDto post, IFormFile image, int userId);
    Task<List<Entities.Post>> GetTimeLinePostAsync(int userId);

}
