using Microsoft.EntityFrameworkCore;
using ProjectReactServer.Models;

namespace Dal.Data
{
    public class PostsClass:IPostsInterface
    {
        private readonly ProjectContext _context;
        public PostsClass(ProjectContext context)
        {
            _context = context;
        }
        public async Task<List<PostTable>> Get()
        {
            var Posts = await _context.Post.ToListAsync();
            return Posts;
        }
        public async Task< bool> Put(int id,PostTable postTable)
        {
            var res = await _context.Post.FirstOrDefaultAsync(x=>x.Id==id);
            if (res == null)
                return false;
            res.IsLike = postTable.IsLike;
            res.Tochen = postTable.Tochen;
            var succesed = await _context.SaveChangesAsync() > 0;
            return succesed;
        }
        public async Task<bool> Post(PostTable postTable)
        {
            var res = await _context.Post.AddAsync(postTable);
            var succesed = await _context.SaveChangesAsync() > 0;
            return succesed;
        }
        public async Task<bool> Delete(int id)

        {
            var Post = await _context.Post.FirstOrDefaultAsync(x => x.Id == id);
            if (Post == null)
                return false;
                var delete = _context.Post.Remove(Post);
            var succussed = await _context.SaveChangesAsync() > 0;
            return succussed;
        }

    }
}
