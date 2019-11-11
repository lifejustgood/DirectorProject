using DirectoryProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace DirectoryProject
{
    public class DbFolders
    {     
        public static List<Folder> Folders 
        {
            get
            {
                var list = new List<Folder>(){
                        new Folder { Name = "Creating Digital Images", FolderRootId = null }
                    };

                list.Add(new Folder { Name = "Resources", FolderRoot = list.FirstOrDefault(r => r.Name == "Creating Digital Images") });
                list.Add(new Folder { Name = "Evidence", FolderRoot = list.FirstOrDefault(r => r.Name == "Creating Digital Images") });
                list.Add(new Folder { Name = "Graphic Products", FolderRoot = list.FirstOrDefault(r => r.Name == "Creating Digital Images") });

                list.Add(new Folder { Name = "Primary Sources", FolderRoot = list.FirstOrDefault(r => r.Name == "Resources") });
                list.Add(new Folder { Name = "Secondary Sources", FolderRoot = list.FirstOrDefault(r => r.Name == "Resources") });

                list.Add(new Folder { Name = "Process", FolderRoot = list.FirstOrDefault(r => r.Name == "Graphic Products") });
                list.Add(new Folder { Name = "Final Product", FolderRoot = list.FirstOrDefault(r => r.Name == "Graphic Products") });

                return list;
            }
        }

        public static void Initial(FolderContext content)
        {
            if (!content.Folders.Any())
            {
                content.Folders.AddRange(Folders);
            }
            content.SaveChanges();
        }
    }
}
