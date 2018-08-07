using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ImageGallery.API.Services;

namespace ImageGallery.API.Controllers
{
    [Route("api/images")]
    public class ImagesController : Controller
    {
        private readonly IHostingEnvironment _hostEnvironment;

        public ImagesController(IGalleryRepository galleryRepository, 
            IHostingEnvironment hostingEnvironment) {

        }
    }
}
