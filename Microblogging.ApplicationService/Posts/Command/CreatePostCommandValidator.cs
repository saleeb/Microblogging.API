
namespace Microblogging.ApplicationService.Posts.Command;

public class CreatePostCommandValidator : AbstractValidator<CreatePostCommand>
{
    public CreatePostCommandValidator(IValidator<PostDto> postsValidator)
    {
        RuleFor(f => f.posts)
       .NotNull()
       .WithMessage("posts model is required")
       .Must(post => post.Text.Length > 140)
       .WithMessage("Text Should not be more than 140 char")
       .SetValidator(postsValidator);
    }
}
