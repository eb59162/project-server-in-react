using ProjectReactServer;
using ProjectReactServer.Interfaces_and_classes;

namespace Dal
{
    public class ToDoData : IToDoiterface
    {
        public bool Delete()
        {
            return true;
        }

        public string Get()
        {
            return "rtrftf";
        }

        public string Post()
        {
            return "rtrftf";
        }

        public void Put(string s)
        {
            Console.WriteLine(  "put==idcun");
        }
    }
}