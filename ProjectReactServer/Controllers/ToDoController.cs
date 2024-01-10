using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectReactServer.Controllers
{
    [ApiController]
    [Route("api/[contoller]")]
    //[Route("api/ToDo/[contoller]")]
    public class ToDoController : Controller
    {
        private readonly IToDoiterface _IToDoiterface;
       


        public ToDoController(IToDoiterface ToDoiterface)
        {
            _IToDoiterface = ToDoiterface;
        }


        [HttpGet]
        [Route("api/GetTodo")]

        public string GetToDo()
        {
            return _IToDoiterface.Get();
        }

        [HttpPut]
        [Route("api/PutToDO/{s}")]
        public void PutToDo(string s)
        {
            _IToDoiterface.Get();
        }
        [HttpPost]
        [Route("api/PostToDo")]
        public ActionResult< string> PostToDo()
        {
            return _IToDoiterface.Post();
        }
        [HttpDelete]
        [Route("api/DeleteToDo")]
        public bool DeleteToDo()
        {
           return _IToDoiterface.Delete();
        }
    }
}
