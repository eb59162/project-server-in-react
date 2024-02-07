using Dal.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectReactServer.Models;

namespace ProjectReactServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsContrller : Controller
     {
        private readonly IPostsInterface _IPostsInterface;
       
        public PostsContrller(IPostsInterface postsInterface)
        {
            _IPostsInterface = postsInterface;
        }


        [HttpGet]
        [Route("GetPost")]

        public async Task<ActionResult<List<PostTable>>> GetPost()
        { 
            var res = await _IPostsInterface.Get();
            if (res.Count() == 0)
                return BadRequest();
            return Ok(res);
        }

        [HttpPut]
        [Route("PutPost/{id}")]
        public async Task <ActionResult< bool>>  PutPost(int id, [FromBody]PostTable postTable )
        {
            var res =await _IPostsInterface.Put(id,postTable);
            if (res)
                return Ok();
            return BadRequest();
        }
        [HttpPost]
        [Route("PostPosts")]
        public async Task<ActionResult<bool> >PostPosts([FromBody]PostTable postTable)
        {
            bool isOk = await _IPostsInterface.Post(postTable);
            if (isOk) { return Ok(); }
            return BadRequest();
        }
        [HttpDelete]
        [Route("DeletePost/{id}")]
        public async Task <ActionResult<bool>> DeletePost(int id)
        {
            bool  res =await _IPostsInterface.Delete(id);
            if (res) { return Ok(); }
            return BadRequest();
        }

    }
}
