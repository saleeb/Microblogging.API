



namespace Microblogging.ApplicationService.Posts.Query;

public class GetTimeLineRequestHandler(IPostService _postService, IMapper _mapper) : IRequestHandler<GetTimeLineReqest, List<PostsViewModel>>
{
    public const string ApiRoute = "api/V1/GetTimeLine";

    public async Task<List<PostsViewModel>> Handle(GetTimeLineReqest request, CancellationToken cancellationToken)
                  => _mapper.Map<List<PostsViewModel>>(await _postService.GetTimeLinePostAsync(request.userId));

}
