using Microsoft.EntityFrameworkCore;
using ProjectReactServer.Models;

namespace Dal.Data
{
    public class UsersClass:IUserInterface
    {
        private readonly ProjectContext _context;
        public UsersClass(ProjectContext context)
        {
            _context = context;
        }
        public async Task<List<UserTable>> Get()
        {
            var Users = await _context.User.ToListAsync();
            return Users;
        }

        public async Task <bool>Put(int id, UserTable userTable)
        {
            var t = await _context.User.FirstOrDefaultAsync(x => x.Id == id);
            if (t == null) { return false; }
            t.Title = userTable.Title;
            t.Email = userTable.Email;
            t.Phone = userTable.Phone;
            t.Address = userTable.Address;
            var succussed = await _context.SaveChangesAsync() > 0;
            return succussed;
        }
    public async Task<bool>Post(UserTable usertable)
        {
            var res = await _context.AddAsync(usertable);
            var successed = await _context.SaveChangesAsync() > 0;
            return successed;
        }
       public async Task<bool> Delete(int id )
        {
            var user = await _context.User.FirstOrDefaultAsync(x=>x.Id==id);
            if (user == null)
                return false;
            var delete = _context.User.Remove(user);

            var successed = await _context.SaveChangesAsync() > 0;
            return successed;
        }
    }
}
