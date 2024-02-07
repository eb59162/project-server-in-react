using ProjectReactServer.Models;

namespace Dal.Data
{
    public interface IPhotosItnterface
    {

        Task<List<PhotoTable>> Get();
        
        Task<bool>Put(int id,PhotoTable photoTable);

        Task<bool> Post(PhotoTable photoTable);

        Task<bool> Delete(int id );
        

    }
}
