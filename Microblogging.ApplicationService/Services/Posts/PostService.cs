
namespace Microblogging.ApplicationService.Services.Posts;

public class PostService : IPostService
{
    private readonly IStorageService _storageService;
    private readonly IGenericRepository<Post> _postRepository;

    public PostService(IStorageService storageService, IGenericRepository<Post> postRepository)
    {
        _storageService = storageService;
        _postRepository = postRepository;
    }

    public async Task<Post> CreatePostAsync(PostDto post, IFormFile image,int userId)
    {
        Post currentPost = Post.Initiate()
                                .Create(post, userId);

        if (image != null)
            currentPost.ImageUrl = await _storageService.UploadFileAsync(image);

        await _postRepository.AddAsync(currentPost);
        return currentPost;
    }

    public async Task<List<Post>> GetTimeLinePostAsync(int userId)
                                  => await _postRepository.FindAsync(query => query.Where(p => p.Id == userId));


}
