using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
