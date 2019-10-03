using DirectoryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectoryProject.Iterfaces
{
    interface IFolders
    {
        IEnumerable<Folder> Folders { get; }

        Folder getRootFolder { get; }
    }
}
