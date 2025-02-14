

namespace Microblogging.ApplicationService.mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Post, PostsViewModel>();
    }
}

