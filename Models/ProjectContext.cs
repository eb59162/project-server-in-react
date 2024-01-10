

using System.Data.Entity;

namespace ProjectReactServer.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {
        }

        public DbSet<PhotoTable> Photo { get; set; }

    
    }
}
