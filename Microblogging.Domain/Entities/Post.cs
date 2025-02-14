
using Microblogging.Domain.Models.DTOs;

namespace Microblogging.Domain.Entities;

public class Post
{
    public int Id { get; set; }
    public string? Username { get; set; }
    public string? Text { get; set; }
    public string? ImageUrl { get; set; }
    public DateTime CreatedAt { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    // Foreign key for User
    public int UserId { get; set; }
    // Navigation property
    public UserMaster CreatedBy { get; set; }


    public static Post Initiate() => new();

    public Post Create(PostDto post,int userId)
    {
        UserId = userId;
        Text = post.Text;
        CreatedAt = DateTime.Now;
        Latitude = post.Latitude;
        Longitude = post.Longitude;
        return this;
    }
}
