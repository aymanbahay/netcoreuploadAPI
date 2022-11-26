using Microsoft.AspNetCore.Http;

namespace netcoreuploadAPI.Interface
{
    public interface IImageWriter
{
        Task<string> UploadImage(IFormFile file);
}
}
