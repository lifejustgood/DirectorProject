using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DirectoryProject.Models;
using DirectoryProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DirectoryProject.Controllers
{
    public class HomeController : Controller
    {
        FolderContext db;

        public HomeController(FolderContext context)
        {
            db = context;
        }

        [Route("")]
        [Route("{rootFolderList}/{rootFolder}")]
        public ViewResult Index(string rootFolder, string rootFolderList)
        {
            IEnumerable<Folder> folders;

            string currentFolder = "";
            if(string.IsNullOrEmpty(rootFolder))
            {
                var initialRootFolder = db.Folders.FirstOrDefault(p => p.FolderRootId == null);
                folders = db.Folders
                    .Where(r => r.FolderRoot == initialRootFolder);

                currentFolder = initialRootFolder.Name;
                rootFolderList = currentFolder;
            }
            else
            {
                folders = db.Folders
                    .Where(r => r.FolderRoot == db.Folders.FirstOrDefault(p => p.Name == rootFolder));
                currentFolder = rootFolder;
                rootFolderList += "/ " + currentFolder; 
            }

            ViewBag.list = rootFolderList;


            var model = new FolderListViewModel
            {
                CurrentFolder = currentFolder,
                allFolderDescendents = folders
            };

            return View(model);
        }
        
    }
}