using Dal.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectReactServer.Models;


namespace ProjectReactServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UsersController : Controller
    {
        private readonly IUserInterface _IUserInterface;
        public UsersController(IUserInterface userInterface)
        {
            _IUserInterface = userInterface;
        }

        [HttpGet]
        [Route("GetUser")]

        public async Task<ActionResult<List<UserTable>>> GetToDo()
        {
            var res = await _IUserInterface.Get();
            if (res.Count()== 0)
               return BadRequest();
            return Ok(res);
        }
        [HttpPut]
        [Route("PutUser/{id}")]
        public async Task<ActionResult<bool>> PutUser(int id, [FromBody] UserTable usertable)
        {
            bool isOk = await _IUserInterface.Put(id, usertable);
            if (isOk) { return Ok(); }
            return BadRequest();
        }
        [HttpPost]
        [Route("PostUser")]
        public async Task<ActionResult<bool>> PostToDo([FromBody] UserTable usertable)
        {
            bool isOk = await _IUserInterface.Post(usertable);
            if (isOk) { return Ok(); }
            return BadRequest();
        }
        [HttpDelete]
        [Route("DeleteUser/{id}")]
        public async Task <ActionResult<bool>> DeleteUser(int id)
        {
            var res =await _IUserInterface.Delete(id);
           if (res){ return Ok(res); }
            return BadRequest();
        }
    }
}
