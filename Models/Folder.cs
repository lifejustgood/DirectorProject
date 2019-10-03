using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectoryProject.Models
{
    public class Folder
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? FolderRootId { get; set; }
        public Folder FolderRoot { get; set; }
    }
}
