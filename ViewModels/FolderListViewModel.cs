using DirectoryProject.Models;
using System.Collections.Generic;

namespace DirectoryProject.ViewModels
{
    public class FolderListViewModel
    {
        public IEnumerable<Folder> allFolderDescendents { get; set; }

        public string CurrentFolder { get; set; }
    }
}
