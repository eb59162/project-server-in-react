namespace ProjectReactServer.Interfaces_and_classes
{
    public class UsersClass:IUserInterface
    {
        public string Get()
        {
            return "your user name";
        }
        public void Put(string s)
        {
            Console.WriteLine("test " + s);
        }
        public string Post()
        {
            return "your user name";
        }
        public bool Delete()
        {
            return true;
        }
    }
}
