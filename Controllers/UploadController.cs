 
using Microsoft.AspNetCore.Mvc;
using netcoreuploadAPI.Handler;

namespace netcoreuploadAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        private readonly IImageHandler _imageHandler;
        public UploadController(IImageHandler imageHandler)
        {
            _imageHandler = imageHandler;
        }
        [HttpPost]
        public async  Task<IActionResult> UploadImage(IFormFile file)
        {
return await _imageHandler.UploadImage(file);   

        }

    }
}
