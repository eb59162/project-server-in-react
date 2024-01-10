namespace ProjectReactServer
{
    public class PhotosClass:IPhotosItnterface
    {
        public string Get()
        {
            return "your photo";
        }
        public void Put(string s)
        {
            Console.WriteLine("test " + s);
        }
        public string Post()
        {
            return "your photo";
        }
        public bool Delete()
        {
            return true;
        }
    }
}
