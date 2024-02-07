using Microsoft.EntityFrameworkCore;
using ProjectReactServer.Models;

namespace Dal.Data
{
    public class PhotosClass:IPhotosItnterface
    {
        private readonly ProjectContext _context;
        public PhotosClass(ProjectContext context)
        {
            _context = context;
        }
        public async Task<List<PhotoTable>> Get()
        {
            var Photos = await _context.Photo.ToListAsync();
            return Photos;
        }
        public async Task<bool> Put(int id, PhotoTable photoTable)
        {
            var t = await _context.Photo.FirstOrDefaultAsync(x => x.Id == id);
            if (t == null) { return false; }
            t.Title = photoTable.Title;
            t.Url = photoTable.Url;
            var succussed = await _context.SaveChangesAsync() > 0;
            return succussed;
        }
        public async Task<bool> Post(PhotoTable photoTable)
        {
            var res = await _context.Photo.AddAsync(photoTable);
            var succesed = await _context.SaveChangesAsync() > 0;
            return succesed;
        }

      

        public async Task<bool> Delete(int id)
        {
            var searchId =await _context.Photo.FirstOrDefaultAsync(x => x.Id == id);
             _context.Photo.Remove(searchId);
            var successed = await _context.SaveChangesAsync() > 0;
            return successed;
        }
    }
}
