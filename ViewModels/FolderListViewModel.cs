using DirectoryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectoryProject.ViewModels
{
    public class FolderListViewModel
    {
        public IEnumerable<Folder> allFolderDescendents { get; set; }

        public string CurrentFolder { get; set; }
    }
}
