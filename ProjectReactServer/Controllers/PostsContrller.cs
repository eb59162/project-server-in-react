using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectReactServer.Interfaces_and_classes;

namespace ProjectReactServer.Controllers
{
    [ApiController]
    //[Route("api/[controller]")]
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

        public string GetPost()
        {
            return _IPostsInterface.Get();
        }

        [HttpPut]
        [Route("PutPost/{s}")]
        public void PutPost(string s)
        {
            _IPostsInterface.Get();
        }
        [HttpPost]
        [Route("PostPosts")]
        public ActionResult<string> PostPosts()
        {
            return _IPostsInterface.Post();
        }
        [HttpDelete]
        [Route("DeletePost")]
        public bool DeletePost()
        {
            return _IPostsInterface.Delete();
        }

    }
}
