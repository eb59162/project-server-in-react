using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectReactServer.Controllers
{
    [ApiController]
    [Route("api/[contoller]")]
    //[Route("api/Photos/[contoller]")]
    public class PhotosController : Controller
    {
        private readonly IPhotosItnterface _IPhotosIntrface;
      

        public PhotosController(IPhotosItnterface photosItnterface)
        {
            _IPhotosIntrface = photosItnterface;
        }

        [HttpGet]
        [Route("api/GetPhotos")]

        public ActionResult< string> GetPhotos()
        {
            return Ok(_IPhotosIntrface.Get());
        }

        [HttpPut]
        [Route("api/PutPhotos/{s}")]
        public void PutPhotos(string s)
        {
            _IPhotosIntrface.Get();
        }
        [HttpPost]
        [Route("api/PostToDo")]
        public ActionResult<string> PostPhoto()
        {
            return _IPhotosIntrface.Post();
        }
        [HttpDelete]
        [Route("api/DeletePhoto")]
        public bool DeletePhoto()
        {
            return _IPhotosIntrface.Delete();
        }
    }
}
