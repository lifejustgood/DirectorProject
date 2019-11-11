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
