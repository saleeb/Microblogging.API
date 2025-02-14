
namespace Microblogging.Domain.Entities;

public class UserMaster : IdentityUser<int>
{
    public int UserId { get; set; }
    public string? Username { get; set; }
}
