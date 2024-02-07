using Microsoft.EntityFrameworkCore;

namespace ProjectReactServer.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {
        }

        public DbSet<PhotoTable> Photo { get; set; }
        public DbSet<PostTable> Post { get; set; }
        public DbSet<UserTable> User { get; set; }
        public DbSet<ToDoTable> ToDo { get; set; }

    }
}
