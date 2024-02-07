using Dal.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectReactServer.Models;



namespace ProjectReactServer.Controllers
{
    [ApiController]

    [Route("api/[controller]")]

    public class ToDoController : Controller
    {
        private readonly IToDointerface _IToDointerface;
        public ToDoController(IToDointerface ToDoiterface)
        {
            _IToDointerface = ToDoiterface;
        }

        [HttpGet]
        [Route("GetToDo")]

        public async Task<ActionResult<List<ToDoTable>>> GetToDo()
        {
            var res = await _IToDointerface.Get();
            if (res.Count() == 0)
                return BadRequest();
            return Ok(res);
        }

        [HttpPut]
        [Route("PutToDo/{id}")]
        public async Task<ActionResult<bool>> PutToDo(int id, [FromBody] ToDoTable todotable)
        {
            bool isOk = await _IToDointerface.Put(id, todotable);
            if (isOk) { return Ok(); }
            return BadRequest();
        }

        [HttpPost]
        [Route("PostToDo")]
        public async Task<ActionResult<bool>> PostToDo([FromBody] ToDoTable todotable)
        {
            bool isOk = await _IToDointerface.Post(todotable);
            if (isOk) { return Ok(); }
            return BadRequest();
        }
        [HttpDelete]
        [Route("DeleteToDo/{id}")]
        public async Task<ActionResult<bool>> DeleteToDo(int id)
        {
            bool isOk = await _IToDointerface.Delete(id);
            if (isOk) { return Ok(); }
            return BadRequest();
        }
    }
}
