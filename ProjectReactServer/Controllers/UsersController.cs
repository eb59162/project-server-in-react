using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectReactServer.Interfaces_and_classes;

namespace ProjectReactServer.Controllers
{
    [ApiController]
    [Route("api/[contoller]")]
    //[Route("api/User/[contoller]")]
    public class UsersController : Controller
    {
        private readonly IUserInterface _IUserInterface;
        


        public UsersController(IUserInterface userInterface)
        {
            _IUserInterface = userInterface;
        }


        [HttpGet]
        [Route("api/GetUser")]

        public string GetUser()
        {
            return _IUserInterface.Get();
        }

        [HttpPut]
        [Route("api/PutUser/{s}")]
        public void PutToDo(string s)
        {
            _IUserInterface.Get();
        }
        [HttpPost]
        [Route("api/PostUser")]
        public ActionResult<string> PostUser()
        {
            return _IUserInterface.Post();
        }
        [HttpDelete]
        [Route("api/DeleteUser")]
        public bool DeleteUser()
        {
            return _IUserInterface.Delete();
        }
    }
}
