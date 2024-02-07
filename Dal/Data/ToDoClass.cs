using ProjectReactServer;
using System.Threading.Tasks;
using ProjectReactServer.Models;
using Microsoft.EntityFrameworkCore;

namespace Dal.Data
{
    public class ToDoClass : IToDointerface
    {
        private readonly ProjectContext _context;
        public ToDoClass(ProjectContext context)
        {
            _context = context;
        }
        public async Task<bool> Delete(int id)
        {
            var todotable = await _context.ToDo.FirstOrDefaultAsync(x => x.Id == id);
            if (todotable == null) { return false; }
            var delete =  _context.ToDo.Remove(todotable);
            var succussed = await _context.SaveChangesAsync()>0;
            return succussed;
        }

        public async Task <List<ToDoTable>>  Get()
        {
            var ToDos = await _context.ToDo.ToListAsync();
            return ToDos ;
        }

        public async Task<bool> Post(ToDoTable todotable)
        {
            var res = await _context.ToDo.AddAsync(todotable);
            var succesed =await _context.SaveChangesAsync() > 0;
            return succesed;
        }

      public async Task<bool> Put(int id, ToDoTable todotable)
        {
            var t = await _context.ToDo.FirstOrDefaultAsync(x => x.Id == id);
            if (t == null) { return false; }
            t.Description = todotable.Description;
            t.Name = todotable.Name;
            t.IsComplete = todotable.IsComplete;
            t.Date = todotable.Date;
            var succussed = await _context.SaveChangesAsync() > 0;
            return succussed;
        }
    }
}