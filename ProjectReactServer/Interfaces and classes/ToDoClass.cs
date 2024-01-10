using Microsoft.AspNetCore.Mvc;

namespace ProjectReactServer
{
    public class ToDoClass:IToDoiterface
    {
        public string Get ()
        { 
        return "your todo"; 
        }
        public void Put(string s)
        {
            Console.WriteLine(  "test "+s);
        }
        public string Post()
        {
            return "your todo";
        }
        public bool Delete()
        {
            return true;
        }
    }
}
