using DirectoryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectoryProject
{
    public class DbFolders
    {
        private static Dictionary<string, Folder> folder;

        public static Dictionary<string, Folder> Folders
        {
            get
            {
                if (folder == null)
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

                    folder = new Dictionary<string, Folder>();
                    foreach (var item in list)
                    {
                        folder.Add(item.Name, item);
                    }
                }
                return folder;
            }
        }

        public static void Initial(FolderContext content)
        {
            if (!content.Folders.Any())
            {
                content.Folders.AddRange(Folders.Select(r => r.Value));
            }
            content.SaveChanges();
        }
    }
}
