using Dal.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectReactServer.Models;

namespace ProjectReactServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PhotosController : Controller
    {
        private readonly IPhotosItnterface _IPhotosIntrface;
        public PhotosController(IPhotosItnterface photosItnterface)
        {
            _IPhotosIntrface = photosItnterface;
        }

        [HttpGet]
        [Route("GetPhotos")]

        public async Task< ActionResult<List<PhotoTable>>> GetPhotos()
        {
            var res = await _IPhotosIntrface.Get();
            if (res.Count() == 0)
                return BadRequest();
            return Ok(res);
        }

        [HttpPut]
        [Route("PutPhotos/{id}")]
        public async Task<ActionResult<bool>> PutPhotos(int id,PhotoTable photoTable)
        {
            bool isOk = await _IPhotosIntrface.Put(id, photoTable);
            if (isOk) { return Ok(); }
            return BadRequest();
        }
        [HttpPost]
        [Route("PostPhoto")]
        public async Task<ActionResult<bool>> PostPhoto([FromBody] PhotoTable phototable)
        {
            bool isOk = await _IPhotosIntrface.Post(phototable);
            if (isOk) { return Ok(); }
            return BadRequest();
        }
        [HttpDelete]
        [Route("DeletePhoto/{id}")]
        public  ActionResult< bool>DeletePhoto( int id)
        {
            var res = _IPhotosIntrface.Delete(id);
            return Ok( res);
        }


      
    }
}
