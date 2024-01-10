namespace ProjectReactServer.Interfaces_and_classes
{
    public class PostsClass:IPostsInterface
    {
        public string Get()
        {
            return "your post";
        }
        public void Put(string s)
        {
            Console.WriteLine("test " + s);
        }
        public string Post()
        {
            return "your post";
        }
        public bool Delete()
        {
            return true;
        }
    }
}
