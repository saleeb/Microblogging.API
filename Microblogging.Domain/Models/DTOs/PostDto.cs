

namespace Microblogging.Domain.Models.DTOs;

public class PostDto
{
    public string Text { get; set; }
    public IFormFile Image { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}
