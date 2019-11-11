using Microsoft.EntityFrameworkCore;

namespace DirectoryProject.Models
{
    public class FolderContext : DbContext
    {
        public DbSet<Folder> Folders { get; set; }

        public FolderContext(DbContextOptions<FolderContext> options) : base(options)
        {
        }
    }
}
