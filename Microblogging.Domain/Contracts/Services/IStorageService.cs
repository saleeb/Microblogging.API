using Microsoft.AspNetCore.Http;

namespace Microblogging.Domain.Contracts.Services;

public interface IStorageService
{
    Task<string> UploadFileAsync(IFormFile file);
    // Add other methods as needed, e.g., GetFileAsync, DeleteFileAsync
}