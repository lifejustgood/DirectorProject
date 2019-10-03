using DirectoryProject.Iterfaces;
using DirectoryProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectoryProject.Repository
{
    public class FolderRepository : IFolders
    {
        private readonly FolderContext folderContext;

        public FolderRepository(FolderContext folderContext)
        {
            this.folderContext = folderContext;
        }
        public IEnumerable<Folder> Folders => folderContext.Folders.Include(r => r.FolderRoot);

        public Folder getRootFolder => folderContext.Folders.FirstOrDefault(r => r.FolderRoot == null);
    }
}
