using ProjectReactServer.Models;

namespace Dal.Data
{
    public interface IUserInterface
    {

        Task<List<UserTable>> Get();
        Task<bool> Put(int id, UserTable userTable);

        Task<bool> Post(UserTable usertable);


        Task<bool> Delete(int id);
       
    }
}
