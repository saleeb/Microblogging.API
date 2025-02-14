

namespace Microblogging.Domain.Models.ViewModels;

public class PostsViewModel
{
    public string Text { get; set; }
    public string ImageBase64 { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}
