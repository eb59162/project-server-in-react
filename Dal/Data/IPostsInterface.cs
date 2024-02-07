using ProjectReactServer.Models;

namespace Dal.Data
{
    public interface IPostsInterface
    {
        Task<List<PostTable>> Get();
       
        Task<bool > Put(int id,PostTable postTable);

        Task<bool> Post(PostTable posttable);
        

        Task<bool>Delete(int id);
    }
}
