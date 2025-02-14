using Microblogging.Domain.Contracts.Services;
using Microsoft.AspNetCore.Http;


namespace Microblogging.Infrastructure.Services;

// dummy service 
public class LocalStorageService : IStorageService
{
    public Task<string> UploadFileAsync(IFormFile file)
    {
        // Implement local file storage logic here
        // For example, save the file to a local directory and return the file path
        return Task.FromResult("Local file path or URL");
    }
}
